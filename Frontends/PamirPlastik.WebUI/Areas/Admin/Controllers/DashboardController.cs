using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class DashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            // Yeni Kurumsal Ziyaretçi İstatistikleri (F5 Korumalı)
            ViewBag.TodayVisitor = "0";
            ViewBag.WeeklyVisitor = "0";
            ViewBag.MonthlyVisitor = "0";
            ViewBag.TotalVisitorCount = "0";

            var visitorClient = _httpClientFactory.CreateClient();
            try 
            {
                var visitorRes = await visitorClient.GetAsync("https://localhost:7184/api/Visitor/GetStats");
                if (visitorRes.IsSuccessStatusCode)
                {
                    var vData = await visitorRes.Content.ReadAsStringAsync();
                    dynamic? vStats = JsonConvert.DeserializeObject(vData);
                    ViewBag.TodayVisitor = vStats?.today ?? "0";
                    ViewBag.WeeklyVisitor = vStats?.weekly ?? "0";
                    ViewBag.MonthlyVisitor = vStats?.monthly ?? "0";
                    ViewBag.TotalVisitorCount = vStats?.total ?? "0";
                }
            } 
            catch { }

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
                        ViewBag.ActiveProductCount = stats.ActiveProductCount;
                        ViewBag.CategoryCount = stats.TotalCategoryCount;
                        ViewBag.ActiveCategoryCount = stats.ActiveCategoryCount;
                        ViewBag.UnreadMessageCount = stats.UnreadMessageCount;
                        ViewBag.UpcomingFairCount = stats.UpcomingFairCount;
                        
                        ViewBag.TotalFairCount = stats.TotalFairCount;
                        ViewBag.TotalJobApplicationCount = stats.TotalJobApplicationCount;
                        ViewBag.TotalContactMessageCount = stats.TotalContactMessageCount;
                        ViewBag.TotalColorCount = stats.TotalColorCount;
                        ViewBag.TotalSocialMediaCount = stats.TotalSocialMediaCount;

                        ViewBag.CategoryNames = JsonConvert.SerializeObject(stats.CategoryNames);
                        ViewBag.CategoryProductCounts = JsonConvert.SerializeObject(stats.CategoryProductCounts);
                        ViewBag.Last7Days = JsonConvert.SerializeObject(stats.Last7Days);
                        ViewBag.Last7DaysMessageCounts = JsonConvert.SerializeObject(stats.Last7DaysMessageCounts);
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