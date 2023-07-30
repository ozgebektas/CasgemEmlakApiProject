using EmlakProject.WebUI.Models.Contact;
using EmlakProject.WebUI.Models.Customer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace EmlakProject.WebUI.ViewComponents.Default
{
    public class _ContactPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ContactPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(ContactViewModel viewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(viewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("https://localhost:7130/api/Contact", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return View("Index");

            }
            return View();
        }
    }
}
