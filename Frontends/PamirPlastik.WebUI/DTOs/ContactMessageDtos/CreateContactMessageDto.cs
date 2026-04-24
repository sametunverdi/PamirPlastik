namespace PamirPlastik.WebUI.DTOs.ContactMessageDtos
{
    public class CreateContactMessageDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; } = DateTime.Now; // Tarihi arka planda biz basıyoruz
        public bool IsRead { get; set; } = false; // Okunmadı olarak biz gönderiyoruz
    }
}
