using Microsoft.AspNetCore.Mvc;

namespace PamirPlastik.WebUI.ViewComponents.About
{
    public class _AboutUicCTAComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
