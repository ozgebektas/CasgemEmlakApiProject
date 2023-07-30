using Microsoft.AspNetCore.Mvc;

namespace EmlakProject.WebUI.ViewComponents.Default
{
    public class _HeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
