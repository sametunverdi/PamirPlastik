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
        public int ProductID { get; set; }
        public string ColorName { get; set; } 
        public string ColorHex { get; set; }  
        public Product Product { get; set; }
    }
}
