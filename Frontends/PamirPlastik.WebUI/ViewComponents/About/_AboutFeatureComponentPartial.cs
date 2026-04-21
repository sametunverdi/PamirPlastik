using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Dto.AboutDtos;

namespace PamirPlastik.WebUI.ViewComponents.About
{
    public class _AboutFeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(List<ResultAboutFeatureDto> features)
        {
            return View(features);
        }
    }
}