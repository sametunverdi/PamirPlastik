namespace PamirPlastik.WebUI.DTOs.AboutDtos
{
    public class ResultAboutDto
    {
        public int Id { get; set; }
        public string? MainTitle_TR { get; set; }
        public string? MainTitle_EN { get; set; }
        public string? SubTitle_TR { get; set; }
        public string? SubTitle_EN { get; set; }
        public string? Description1_TR { get; set; }
        public string? Description1_EN { get; set; }
        public string? Description2_TR { get; set; }
        public string? Description2_EN { get; set; }
        public string? HighlightQuote_TR { get; set; }
        public string? HighlightQuote_EN { get; set; }
        public string? VisionTitle_TR { get; set; }
        public string? VisionTitle_EN { get; set; }
        public string? VisionDescription_TR { get; set; }
        public string? VisionDescription_EN { get; set; }
        public string? MissionTitle_TR { get; set; }
        public string? MissionTitle_EN { get; set; }
        public string? MissionDescription_TR { get; set; }
        public string? MissionDescription_EN { get; set; }

        public string? SeoTitle_TR { get; set; }
        public string? SeoTitle_EN { get; set; }
        public string? SeoDescription_TR { get; set; }
        public string? SeoDescription_EN { get; set; }

        // İçindeki listeleri de unutmadık kanka:
        public List<ResultAboutFeatureDto>? Features { get; set; }
        public List<ResultAboutImageDto>? Images { get; set; }
    }
}
