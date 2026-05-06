using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SmartBilling.Application.Services;
using SmartBilling.Core.Contracts;
using SmartBilling.Core.Entities;

namespace SmartBilling.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        public readonly IInvoiceService _service;

        public InvoiceController(IInvoiceService service)
        {
            _service = service;
        }
        [HttpPost]

        public IActionResult Create(Invoice invoice)
        {
            _service.AddInvoice(invoice);
            return Ok("Invoice Created");
        }
    }
}
