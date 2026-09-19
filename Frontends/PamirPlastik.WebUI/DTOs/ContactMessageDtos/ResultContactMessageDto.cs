namespace PamirPlastik.WebUI.DTOs.ContactMessageDtos
{
    public class ResultContactMessageDto
    {
        public int ContactMessageID { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Company { get; set; }
        public string? Subject { get; set; }
        public string? MessageDetail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
