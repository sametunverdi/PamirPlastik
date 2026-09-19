using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class Color
    {
        public int ColorID { get; set; }
        public string? Name_TR { get; set; }
        public string? Name_EN { get; set; }
        public string? HexCode { get; set; }
        
        public List<ProductColor>? ProductColors { get; set; }
    }
}
