using AutoMapper; 
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
    [Route("api/discounts")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public DiscountController(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDiscounts()
        {
            var discounts = await _repository.Discount.GetAllDiscounts();

            var discountsDto = _mapper.Map<IEnumerable<DiscountDto>>(discounts);

            return Ok(discountsDto);
        }

        [HttpGet("{type}")]
        public async Task<IActionResult> GetDiscount(string type)
        {
            var discount = await _repository.Discount.GetDiscountPercentageByType(type);

            if (discount == null) 
                return NotFound();

            var discountPercentage = _repository.Discount.DiscountPercentage(discount);

            if (discountPercentage != null)
                return Ok(discountPercentage);

            return NotFound(); 
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscount([FromBody] CreateDiscountDto discountDto)
        {
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            var discountEntity = _mapper.Map<DiscountType>(discountDto);

            _repository.Discount.CreateDiscountType(discountEntity);

            await _repository.SaveAsync();

            return Ok();
        }
    }
}
