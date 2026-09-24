using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.JobApplicationDtos;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class JobApplicationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public JobApplicationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/JobApplications");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultJobApplicationDto>>(jsonData);
                return View(values);
            }
            return View(new List<ResultJobApplicationDto>());
        }

        
        [Route("DeleteApplication/{id}")]
        public async Task<IActionResult> DeleteApplication(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7184/api/JobApplications/{id}");
            TempData["SuccessMessage"] = "İş başvurusu başarıla silindi.";
            return RedirectToAction("Index");
        }
    }
}
