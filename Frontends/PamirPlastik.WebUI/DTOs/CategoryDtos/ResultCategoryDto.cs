namespace PamirPlastik.WebUI.DTOs.CategoryDtos
{
    public class ResultCategoryDto
    {
        public int CategoryID { get; set; }
        public string? Name_TR { get; set; }
        public string? Name_EN { get; set; }
        public string? Description_TR { get; set; }
        public string? Description_EN { get; set; }
        public string? ImageUrl { get; set; }
        public string? Slug { get; set; }
        public bool Status { get; set; }
        public int ProductCount { get; set; }
    }
}
