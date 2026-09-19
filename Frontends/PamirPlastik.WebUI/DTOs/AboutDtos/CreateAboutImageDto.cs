namespace PamirPlastik.WebUI.DTOs.AboutDtos
{
    public class CreateAboutImageDto
    {
        public int AboutId { get; set; } = 1;
        public string? ImageUrl { get; set; }
        public Microsoft.AspNetCore.Http.IFormFile? ImageFile { get; set; }
        public string? AltText_TR { get; set; }
        public string? AltText_EN { get; set; }
    }
}
