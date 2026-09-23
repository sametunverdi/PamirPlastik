using System.Collections.Generic;

namespace PamirPlastik.WebUI.DTOs.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string? Name_TR { get; set; }
        public string? Name_EN { get; set; }
        public string? ShortDescription_TR { get; set; }
        public string? ShortDescription_EN { get; set; }
        public string? FullDescription_TR { get; set; }
        public string? FullDescription_EN { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ProductCode { get; set; } 
        public bool Status { get; set; }
        public int CategoryID { get; set; }
        public int ProductCount { get; set; }
        public string? CategoryName { get; set; }
        public int BoxCount { get; set; }
        public string? Capacity { get; set; }
        public bool IsDishwasherSafe { get; set; }
        public bool IsFoodSafe { get; set; }
        public string? Material { get; set; }
        public string? BoxSize { get; set; }
        public string? BoxWeight { get; set; }
        public List<ResultProductImageDto>? Images { get; set; }
        public List<ResultProductColorDto>? Colors { get; set; }
        public string? MainImageUrl { get; set; }
        public bool IsFeatured { get; set; }
        public string? Slug_TR { get; set; }
        public string? Slug_EN { get; set; }
    }
}

