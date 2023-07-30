using EmlakProject.DataAccessLayer.Abstract;
using EmlakProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmlakProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult GetCustomer()
        {
            var customers=_customerService.GetAll();
            return Ok(customers);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var customer = _customerService.GetCustomer(id);
            if(customer == null)
            {
                return BadRequest("Bu id ye ait bir kullanıcı bulunamadı");
            }
            else
            {
                return Ok(customer);

            }
            
        }
        [HttpPost]

        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.Save(customer);
            return CreatedAtAction("GetCustomer", new { id = customer.CustomerID }, customer);
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(string id)
        {
            var customer=_customerService.GetCustomer(id);
            if( customer == null )
            {
                return BadRequest("Üye Bulunammadı");

            }
            else
            {
                _customerService.Delete(id);
                return Ok("kullanıcı silindi");
            }
        }
    }
}
