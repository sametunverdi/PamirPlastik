using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.AboutDtos;
using System.Text;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

                [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            
            // 1. Fetch About Data
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Abouts");
            
            // 2. Fetch Features
            var featuresResponse = await client.GetAsync("https://localhost:7184/api/AboutFeatures");
            if (featuresResponse.IsSuccessStatusCode)
            {
                var featuresJson = await featuresResponse.Content.ReadAsStringAsync();
                ViewBag.Features = JsonConvert.DeserializeObject<List<ResultAboutFeatureDto>>(featuresJson);
            }
            else
            {
                ViewBag.Features = new List<ResultAboutFeatureDto>();
            }

            // 3. Fetch Images
            var imagesResponse = await client.GetAsync("https://localhost:7184/api/AboutImages");
            if (imagesResponse.IsSuccessStatusCode)
            {
                var imagesJson = await imagesResponse.Content.ReadAsStringAsync();
                ViewBag.Images = JsonConvert.DeserializeObject<List<ResultAboutImageDto>>(imagesJson);
            }
            else
            {
                ViewBag.Images = new List<ResultAboutImageDto>();
            }

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var about = JsonConvert.DeserializeObject<ResultAboutDto>(jsonData);
                
                if (about != null && about.Id > 0)
                {
                    var updateDto = new UpdateAboutDto
                    {
                        Id = about.Id,
                        SeoTitle_TR = about.SeoTitle_TR,
                        SeoTitle_EN = about.SeoTitle_EN,
                        SeoDescription_TR = about.SeoDescription_TR,
                        SeoDescription_EN = about.SeoDescription_EN,
                        MainTitle_TR = about.MainTitle_TR,
                        MainTitle_EN = about.MainTitle_EN,
                        SubTitle_TR = about.SubTitle_TR,
                        SubTitle_EN = about.SubTitle_EN,
                        Description1_TR = about.Description1_TR,
                        Description1_EN = about.Description1_EN,
                        Description2_TR = about.Description2_TR,
                        Description2_EN = about.Description2_EN,
                        HighlightQuote_TR = about.HighlightQuote_TR,
                        HighlightQuote_EN = about.HighlightQuote_EN,
                        VisionTitle_TR = about.VisionTitle_TR,
                        VisionTitle_EN = about.VisionTitle_EN,
                        VisionDescription_TR = about.VisionDescription_TR,
                        VisionDescription_EN = about.VisionDescription_EN,
                        MissionTitle_TR = about.MissionTitle_TR,
                        MissionTitle_EN = about.MissionTitle_EN,
                        MissionDescription_TR = about.MissionDescription_TR,
                        MissionDescription_EN = about.MissionDescription_EN
                    };
                    return View(updateDto);
                }
            }

            return View(new UpdateAboutDto());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UpdateAboutDto updateAboutDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateAboutDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            if (updateAboutDto.Id > 0)
            {
                // Update
                var responseMessage = await client.PutAsync("https://localhost:7184/api/Abouts", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    TempData["SuccessMessage"] = "Hakkımızda bilgileri başarıyla güncellendi.";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                // Create if not exists
                var responseMessage = await client.PostAsync("https://localhost:7184/api/Abouts", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    TempData["SuccessMessage"] = "Hakkımızda bilgileri başarıyla güncellendi.";
                    return RedirectToAction("Index");
                }
            }

            TempData["ErrorMessage"] = "Bir hata oluştu. Lütfen alanları kontrol edin.";
            return View(updateAboutDto);
        }
    }
}
