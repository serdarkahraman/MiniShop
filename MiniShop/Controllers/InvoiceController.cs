using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Entities;
using MiniShop.Entities.DTO;
using MiniShop.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShop.Controllers
{
    [Route("api/invoices")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public InvoiceController(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("{billNumber}")]
        public async Task<IActionResult> GetInvoice(string billNumber)
        {
            if (billNumber == null) 
                return BadRequest();

            var invoice = await _repository.Invoice.GetTotalInvoiceAmount(billNumber);

            if (invoice == null)
                return NotFound();

            var invoiceDto = _mapper.Map<InvoiceDto>(invoice);

            return Ok(invoiceDto.Total);
        }

        [HttpPost]
        public async Task<IActionResult> GenerateInvoiceCustomer(int customerId, [FromBody] CreateInvoiceDto invoiceDto)
        {
            decimal invoiceSubtotal = 0;

            var user = await _repository.Customer.GetById(customerId);

            if (user == null) 
                return NotFound();

            invoiceSubtotal = await ApplyDiscount(invoiceDto, invoiceSubtotal, user);

            var invoiceEntity = _mapper.Map<Invoice>(invoiceDto);

            invoiceEntity.Total = invoiceSubtotal;

            _repository.Invoice.GenerateInvoiceForCustomer(customerId, invoiceEntity);

            await _repository.SaveAsync();

            return Ok();
        }

        private async Task<decimal> ApplyDiscount(CreateInvoiceDto invoiceDto, decimal invoiceSubtotal, Customer customer)
        {
            var discounts = await _repository.Discount.GetAllDiscounts();
            foreach (var discount in discounts)
            {
                if (discount.Equals(customer.CustomerType) && discount.IsRatePercentage)
                {
                    var discountValue = invoiceDto.OrderTotal * (discount.Rate / 100);
                    invoiceSubtotal = invoiceDto.OrderTotal - discountValue;
                }

                foreach (var detail in invoiceDto.InvoiceDetails)
                {
                    if (detail.ProductCost >= 100 && !discount.IsRatePercentage)
                    {
                        invoiceSubtotal -= discount.Rate;
                    }
                }
            }
            
            return invoiceSubtotal;
        }
    }
}
