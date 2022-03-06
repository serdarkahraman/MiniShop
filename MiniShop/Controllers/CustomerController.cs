using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MiniShop.Entities;
using MiniShop.Entities.DTO;
using MiniShop.Repositories;
using MiniShop.Repositories.Interfaces;

namespace MiniShop.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepositoryManager repository;
        private readonly IMapper mapper;

        public CustomerController(IRepositoryManager repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await repository.Customer.GetAll();

            var customerDto = mapper.Map<IEnumerable<CustomerDto>>(customers);

            return Ok(customerDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerDto customer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var customerEntity = mapper.Map<Customer>(customer);

            repository.Customer.CreateCustomer(customerEntity, customerType: "Customer");

            await repository.SaveAsync();

            var response = mapper.Map<CustomerDto>(customerEntity);

            return CreatedAtRoute("CustomerId", new { response.Id }, response);
        }

        [HttpGet("{Id:int}", Name = "CustomerId")]
        public async Task<IActionResult> GetCustomerById(int Id)
        {
            var customer = await repository.Customer.GetById(Id);

            if (customer == null)
                return NotFound();

            var reponse = mapper.Map<CustomerDto>(customer);

            return Ok(reponse);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetCustomerByName(string name)
        {
            var customer = await repository.Customer.GetByName(name);

            if (customer == null)
                return NotFound();

            var response = mapper.Map<CustomerDto>(customer);

            return Ok(response);
        }
    }
}
