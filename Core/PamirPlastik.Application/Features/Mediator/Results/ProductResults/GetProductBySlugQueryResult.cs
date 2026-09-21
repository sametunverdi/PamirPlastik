using System;
using System.Collections.Generic;

namespace PamirPlastik.Application.Features.Mediator.Results.ProductResults
{
    public class GetProductBySlugQueryResult
    {
        public int ProductID { get; set; }
        public string? Name_TR { get; set; }
        public string? Name_EN { get; set; }
        public string? Slug_TR { get; set; }
        public string? Slug_EN { get; set; }
        public string? ShortDescription_TR { get; set; }
        public string? ShortDescription_EN { get; set; }
        public string? FullDescription_TR { get; set; }
        public string? FullDescription_EN { get; set; }
        public string? ProductCode { get; set; }
        public int BoxCount { get; set; }
        public string? Capacity { get; set; }
        public string? Material { get; set; }
        public string? BoxSize { get; set; }
        public string? BoxWeight { get; set; }
        public bool IsDishwasherSafe { get; set; }
        public bool IsFoodSafe { get; set; }
        public string? MainImageUrl { get; set; }
        public bool IsFeatured { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        
        public List<ResultProductColorDto>? Colors { get; set; }
        public List<ResultProductImageDto>? Images { get; set; }
    }
}
