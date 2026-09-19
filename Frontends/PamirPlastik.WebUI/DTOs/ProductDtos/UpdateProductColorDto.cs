namespace PamirPlastik.WebUI.DTOs.ProductDtos
{
    public class UpdateProductColorDto
    {
        public int ProductColorID { get; set; }
        public int ProductId { get; set; }
        public string? ColorName { get; set; }
        public string? ColorHex { get; set; }
    }
}
