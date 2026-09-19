using System;
namespace PamirPlastik.Domain.Entities
{
    public class ProductColor
    {
        public int ProductColorID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        
        public int ColorID { get; set; }
        public Color Color { get; set; }
    }
}
