namespace PamirPlastik.WebUI.DTOs.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactID { get; set; }
        public string? Title_TR { get; set; }
        public string? Title_EN { get; set; }
        public string? Description_TR { get; set; }
        public string? Description_EN { get; set; }
        public string? PhoneTitle_TR { get; set; }
        public string? PhoneTitle_EN { get; set; }
        public string? Phone { get; set; }
        public string? PhoneDescription_TR { get; set; }
        public string? PhoneDescription_EN { get; set; }
        public string? EmailTitle_TR { get; set; }
        public string? EmailTitle_EN { get; set; }
        public string? Email { get; set; }
        public string? EmailDescription_TR { get; set; }
        public string? EmailDescription_EN { get; set; }
        public string? MapLocation { get; set; }
        public string? MapTitle_TR { get; set; }
        public string? MapTitle_EN { get; set; }
        public string? Address_TR { get; set; }
        public string? Address_EN { get; set; }
    }
}
