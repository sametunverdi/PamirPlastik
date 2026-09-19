using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.CategoryDtos;
using PamirPlastik.WebUI.DTOs.ContactDtos;
using PamirPlastik.WebUI.DTOs.ContactMessageDtos;
using PamirPlastik.WebUI.DTOs.ProductDtos;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            


            try 
            {
                var response = await client.GetAsync("https://localhost:7184/api/Statistics");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var stats = JsonConvert.DeserializeObject<PamirPlastik.WebUI.DTOs.StatisticsDtos.ResultDashboardStatisticsDto>(jsonData);
                    
                    if (stats != null)
                    {
                        ViewBag.ProductCount = stats.TotalProductCount;
                        ViewBag.CategoryCount = stats.TotalCategoryCount;
                        ViewBag.UnreadMessageCount = stats.UnreadMessageCount;
                        ViewBag.UpcomingFairCount = stats.UpcomingFairCount;
                    }
                }
            } 
            catch (Exception) 
            {
                // API is down or something
            }

            return View();
        }
    }
}
