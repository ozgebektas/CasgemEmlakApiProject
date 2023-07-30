using EmlakProject.WebUI.Models.Customer;
using EmlakProject.WebUI.Models.Property;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmlakProject.WebUI.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PropertyController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async  Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7130/api/Property");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<PropertyViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
