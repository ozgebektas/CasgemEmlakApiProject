using EmlakProject.DataAccessLayer.Abstract;
using EmlakProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmlakProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult GetList()
        {
           var contact=_contactService.GetList();
            return Ok(contact);
        }
        [HttpGet("{id}")]

        public IActionResult GetById(string id)
        {
            var contact = _contactService.GetById(id);
            return Ok(contact);

        }

        [HttpPost]

        public IActionResult AddContact(Contact contact)
        {
            _contactService.AddContact(contact);
            return Ok(_contactService.GetList());
        }


        [HttpDelete]
        public IActionResult DeleteContact(string id)
        {
            var contact = _contactService.GetById(id);
            if (contact == null)
            {
                return BadRequest("iletişim Bıulunamadı");

            }
          
                _contactService.DeleteContact(id);
                return Ok("iletişim biligileri silindi");
            
        }
        [HttpPut]

        public IActionResult UpdateContact(string id, Contact contact)
        {
            var cnt = _contactService.GetById(id);
            if (cnt == null)
            {
                return BadRequest("iletişim biligileri Bulunamadı");
            }
            else
            {
                _contactService.Update(id, contact);
                return Ok("iletişim bilgileri Güncellendi");
            }
        }
    }
}
