using EmlakProject.DataAccessLayer.Abstract;
using EmlakProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmlakProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var values = _categoryService.GetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var prop = _categoryService.GetByIdCategory(id);
            if (prop == null)
            {
                return NotFound("Mülk bulunamadı");
            }
            return Ok(prop);
        }


        [HttpPost]
        public IActionResult Add(Category category)
        {
            _categoryService.AddCategory(category);
            return CreatedAtAction("GetList", new { id = category.CategoryID }, category);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, Category category)
        {
            var prop = _categoryService.GetByIdCategory(id);
            if (prop == null)
            {
                return NotFound("Mülk bulunamadı");
            }
            _categoryService.UpdateCategory(id, category);
            return Ok($"{category.CategoryID} ID ye sahip mülk güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var prop = _categoryService.GetByIdCategory(id);
            if (prop == null)
            {
                return NotFound("Mülk bulunamadı");
            }
            _categoryService.Delete(prop.CategoryID);
            return Ok($"{prop.CategoryID} ID ye sahip mülk silindi.");
        }
    }
}
