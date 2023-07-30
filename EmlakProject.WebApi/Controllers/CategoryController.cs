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
            var category = _categoryService.GetList();
            return Ok(category);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var category = _categoryService.GetById(id);
            if (category == null)
            {
                return BadRequest("kategori bulunamadı");
            }
            else
            {
                return Ok(category);
            }
        }
        [HttpPost]

        public IActionResult AddCategory(Category category)
        {
            _categoryService.Add(category);
            return CreatedAtAction("GetList", new { id = category.CategoryID }, category);
        }

        [HttpDelete]
        public IActionResult DeleteCategory(string id)
        {
            var category = _categoryService.GetById(id);
            if (category == null)
            {
                return BadRequest("kategori Bıulunamadı");

            }
            else
            {
                _categoryService.Delete(id);
                return Ok("kategori silindi");
            }
        }
        [HttpPut]

        public IActionResult UpdateCategory(string id, Category category)
        {
            var cate = _categoryService.GetById(id);
            if (cate == null)
            {
                return BadRequest("kategori Bulunamadı");
            }
            else
            {
                _categoryService.Update(id, category);
                return Ok("kategori Güncellendi");
            }
        }

    }
}
