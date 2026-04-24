using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class ProductImage
    {
        public int ProductImageID { get; set; } // Resim Id
        public string ImageUrl { get; set; } // Resmin dosya yolu

        // İlişki
        public int ProductID { get; set; } // Resmin hangi ürüne ait olduğu
        public Product Product { get; set; } // Resim üzerinden ürüne gitmek için
    }
}
