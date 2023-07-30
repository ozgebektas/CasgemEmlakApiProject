using EmlakProject.DataAccessLayer.Abstract;
using EmlakProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmlakProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var property = _propertyService.GetProperties();
            return Ok(property);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(string id) 
        {
            var property=_propertyService.GetById(id);
            if(property == null)
            {
                return BadRequest("Böyle bir ürün bulunamadı");
            }
            else
            {
                return Ok(property);
            }
        }
        [HttpPost]

        public IActionResult AddProperty(Property property)
        {
            _propertyService.AddProperty(property);
            return CreatedAtAction("GetList", new { id = property.PropertyId }, property);
        }

        [HttpDelete]
        public IActionResult DeleteProperty(string id)
        {
            var property = _propertyService.GetById(id);
            if (property == null)
            {
                return BadRequest("Ürün Bıulunamadı");

            }
            else
            {
                _propertyService.DeleteProperty(id);
                return Ok("ürün silindi");
            }
        }
        [HttpPut]
       
        public IActionResult UpdateProperty(string id, Property property)
        {
            var proper=_propertyService.GetById(id);
            if(proper == null)
            {
                return BadRequest("Ürün Bulunamadı");
            }
            else
            {
                _propertyService.Update(id, property);
                return Ok("Ürün Güncellendi");
            }
        }

    }
}
