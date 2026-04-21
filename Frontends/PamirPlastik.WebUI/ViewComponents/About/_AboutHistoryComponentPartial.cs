using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Dto.AboutDtos;

namespace PamirPlastik.WebUI.ViewComponents.About
{
    public class _AboutHistoryComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(ResultAboutDto aboutDetail)
        {
            return View(aboutDetail);
        }
    }
}
