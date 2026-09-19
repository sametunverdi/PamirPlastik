namespace PamirPlastik.WebUI.DTOs.ProductDtos
{
    public class UpdateProductImageDto
    {
        public int ProductImageID { get; set; }
        public int ProductId { get; set; }
        public string? ImageUrl { get; set; }
        public Microsoft.AspNetCore.Http.IFormFile? ImageFile { get; set; }
    }
}
