namespace PamirPlastik.WebUI.DTOs.SocialMediaDtos
{
    public class UpdateSocialMediaDto
    {
        public int SocialMediaID { get; set; }
        public string? PlatformName { get; set; }
        public string? Url { get; set; }
        public string? IconClass { get; set; }
        public bool IsActive { get; set; }
    }
}
