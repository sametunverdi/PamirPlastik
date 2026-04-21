using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class ProductImage
    {
        public int ProductImageID { get; set; }

        public string ImagePath { get; set; }
        public string ImageAlt_TR { get; set; }
        public string ImageAlt_EN { get; set; }

        public bool IsMain { get; set; }
        public int Order { get; set; }

        // İlişki
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
