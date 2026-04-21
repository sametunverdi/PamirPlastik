using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class ProductColor
    {
        public int ProductColorID { get; set; }

        public string ColorName_TR { get; set; }
        public string ColorName_EN { get; set; }
        public string ColorHex { get; set; }

        // İlişki
        public int ProductID { get; set; }
        public Product Product { get; set; }    }
}
