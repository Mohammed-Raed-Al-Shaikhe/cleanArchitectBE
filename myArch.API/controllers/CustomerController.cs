using Microsoft.AspNetCore.Mvc;
using myArch.Application.services;
using myArch.Application.interfaces;
using myArch.Infrastructure.Entities;

namespace myArch.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task <IActionResult> Add(Customer customer) 
        {
            await _service.CreateAsync(customer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}