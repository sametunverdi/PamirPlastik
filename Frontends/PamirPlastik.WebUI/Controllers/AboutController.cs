using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace PamirPlastik.WebUI.Controllers
{
    public class AboutController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
