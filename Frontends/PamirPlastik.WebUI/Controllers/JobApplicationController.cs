using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.JobApplicationDtos;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.WebUI.Controllers
{
    public class JobApplicationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public JobApplicationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitApplication(CreateJobApplicationDto createJobApplicationDto)
        {
            if (createJobApplicationDto.CvFile != null && createJobApplicationDto.CvFile.Length > 0)
            {
                var extension = Path.GetExtension(createJobApplicationDto.CvFile.FileName);
                if (extension.ToLower() == ".pdf")
                {
                    var newFileName = Guid.NewGuid() + extension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/cvs/", newFileName);
                    
                    if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/cvs/")))
                    {
                        Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/cvs/"));
                    }

                    using (var stream = new FileStream(location, FileMode.Create))
                    {
                        await createJobApplicationDto.CvFile.CopyToAsync(stream);
                    }
                    createJobApplicationDto.CvPdfUrl = "/cvs/" + newFileName;
                }
            }

            createJobApplicationDto.ApplicationDate = DateTime.Now;

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createJobApplicationDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7184/api/JobApplications", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Ba\u015Fvurunuz ba\u015Far\u0131yla al\u0131nm\u0131\u015Ft\u0131r. \u0130nsan kaynaklar\u0131 ekibimiz en k\u0131sa s\u00FCrede CV'nizi inceleyecektir.";
                return RedirectToAction("Index", "Contact");
            }

            TempData["ErrorMessage"] = "Ba\u015Fvurunuz g\u00F6nderilirken bir hata olu\u015Ftu. L\u00FCtfen tekrar deneyin.";
            return RedirectToAction("Index", "Contact");
        }
    }
}
