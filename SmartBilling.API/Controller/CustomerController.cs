using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SmartBilling.Core.Contracts;
using SmartBilling.Core.Entities;

namespace SmartBilling.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        public IActionResult Create(Customer customer)
        {
            _service.AddCustomer(customer); 
            return Ok("Customer Created");

        }
    }
}
