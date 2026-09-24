namespace PamirPlastik.WebUI.DTOs.DeveloperSettingDtos
{
    public class UpdateDeveloperSettingDto
    {
        public int DeveloperSettingID { get; set; }
        public string? SignatureText { get; set; }
        public string? DeveloperName { get; set; }
        public string? DeveloperUrl { get; set; }
    }
}
