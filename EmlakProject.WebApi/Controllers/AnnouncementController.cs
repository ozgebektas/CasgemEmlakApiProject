using EmlakProject.DataAccessLayer.Abstract;
using EmlakProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmlakProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var announcement = _announcementService.GetList();
            return Ok(announcement);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var announcement = _announcementService.GetById(id);
            if (announcement == null)
            {
                return BadRequest("ilan bulunamadı");
            }
            else
            {
                return Ok(announcement);
            }
        }
        [HttpPost]

        public IActionResult AddAnnouncement(Announcement announcement)
        {
            _announcementService.AddAnnouncement(announcement);
            return CreatedAtAction("GetList", new { id = announcement.AnnouncementID }, announcement);
        }

        [HttpDelete]
        public IActionResult DeleteAnnouncement(string id)
        {
            var announcement = _announcementService.GetById(id);
            if (announcement == null)
            {
                return BadRequest("ilan Bıulunamadı");

            }
            else
            {
                _announcementService.DeleteAnnouncement(id);
                return Ok("ilan silindi");
            }
        }
        [HttpPut]

        public IActionResult UpdateAnnouncement(string id, Announcement announcement)
        {
            var announcement1 = _announcementService.GetById(id);
            if (announcement1 == null)
            {
                return BadRequest("ilan Bulunamadı");
            }
            else
            {
                _announcementService.UpdateAnnouncement(id, announcement);
                return Ok("ilan Güncellendi");
            }
        }

    }
}
