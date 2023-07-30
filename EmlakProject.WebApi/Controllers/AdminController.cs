using EmlakProject.DataAccessLayer.Abstract;
using EmlakProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmlakProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AdminController : ControllerBase
	{
		private readonly IAdminService _adminService;

		public AdminController(IAdminService adminService)
		{
			_adminService = adminService;
		}
		[HttpGet]
		public IActionResult GetList()
		{
			var admin = _adminService.GetList();
			return Ok(admin);
		}
		[HttpGet("{id}")]

		public IActionResult GetById(string id)
		{
			var admin = _adminService.GetById(id);
			return Ok(admin);

		}
		[HttpPost]

		public IActionResult Add(Admin admin)
		{
			_adminService.Add(admin);
			return Ok(_adminService.GetList());
		}

		[HttpDelete]
		public IActionResult Delete(string id)
		{
			var admin = _adminService.GetById(id);
			if (admin == null)
			{
				return BadRequest("kullanıcı Bıulunamadı");

			}

			_adminService.Deletet(id);
			return Ok("kullanıcı bilgileri silindi");

		}
		[HttpPut]

		public IActionResult UpdateContact(string id, Admin admin)
		{
			var adm = _adminService.GetById(id);
			if (adm == null)
			{
				return BadRequest("Kullanıcı biligileri Bulunamadı");
			}
			else
			{
				_adminService.Update(id, admin);
				return Ok("admin bilgileri Güncellendi");
			}
		}
	}
	
}
