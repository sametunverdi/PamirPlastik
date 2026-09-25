using Microsoft.AspNetCore.Http;
using System;

namespace PamirPlastik.WebUI.DTOs.JobApplicationDtos
{
    public class CreateJobApplicationDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Message { get; set; }
        public string? CvPdfUrl { get; set; }
        public IFormFile CvFile { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
    }
}
