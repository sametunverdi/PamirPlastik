namespace PamirPlastik.WebUI.DTOs.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string Name_TR { get; set; }
        public string Name_EN { get; set; }
        public string Description_TR { get; set; }
        public string Description_EN { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ProductCode { get; set; } 
        public bool Status { get; set; }
        public int CategoryID { get; set; }
        public int ProductCount { get; set; }
    }
}
