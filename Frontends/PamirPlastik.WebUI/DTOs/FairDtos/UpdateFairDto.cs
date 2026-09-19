namespace PamirPlastik.WebUI.DTOs.FairDtos
{
    public class UpdateFairDto
    {
        public int FairID { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Date { get; set; }
        public string? Stand { get; set; }
        public string? Img1 { get; set; }
        public Microsoft.AspNetCore.Http.IFormFile? Img1File { get; set; }
        public string? Img2 { get; set; }
        public Microsoft.AspNetCore.Http.IFormFile? Img2File { get; set; }
        public bool IsFuture { get; set; }
    }
}
