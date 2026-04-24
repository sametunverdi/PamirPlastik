using Microsoft.AspNetCore.Mvc;

namespace PamirPlastik.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
