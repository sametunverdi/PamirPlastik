namespace PamirPlastik.WebUI.DTOs.AboutDtos
{
    public class CreateAboutFeatureDto
    {
        public int AboutId { get; set; } = 1;
        public string? FeatureType { get; set; }
        public string? ValueOrIcon { get; set; }
        public string? Title_TR { get; set; }
        public string? Title_EN { get; set; }
        public string? Description_TR { get; set; }
        public string? Description_EN { get; set; }
    }
}
