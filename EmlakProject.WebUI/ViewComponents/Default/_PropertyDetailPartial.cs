using Microsoft.AspNetCore.Mvc;

namespace EmlakProject.WebUI.ViewComponents.Default
{
    public class _PropertyDetailPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
