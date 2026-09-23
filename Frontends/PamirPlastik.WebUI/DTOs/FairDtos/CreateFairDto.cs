using Newtonsoft.Json;
namespace PamirPlastik.WebUI.DTOs.FairDtos
{
    public class CreateFairDto
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Date { get; set; }
        public string? Stand { get; set; }
        public string? Img1 { get; set; }
        [JsonIgnore]
        public Microsoft.AspNetCore.Http.IFormFile? Img1File { get; set; }
        public string? Img2 { get; set; }
        [JsonIgnore]
        public Microsoft.AspNetCore.Http.IFormFile? Img2File { get; set; }
        public bool IsFuture { get; set; }
    }
}
