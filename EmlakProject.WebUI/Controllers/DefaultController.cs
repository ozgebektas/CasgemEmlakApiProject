using Microsoft.AspNetCore.Mvc;

namespace EmlakProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
