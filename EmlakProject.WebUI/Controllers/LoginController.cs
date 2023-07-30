using Amazon.Runtime;
using EmlakProject.WebUI.Models.Admin;
using EmlakProject.WebUI.Models.Contact;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmlakProject.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public LoginController(IHttpClientFactory httpClientFactory)
        {

            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index(AdminLoginDto adminLoginDto)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7130/api/Admin");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AdminLoginDto>>(jsonData);
                var admin = values.FirstOrDefault(x => x.Password == adminLoginDto.Password && x.Email == adminLoginDto.Email);
                if (admin != null)
                {
                    var user = admin.Username;
                    HttpContext.Session.SetString("Username", admin.Username);
                    return RedirectToAction("Index", "Default");

                }

            }
            return View();
        }
    }
}
