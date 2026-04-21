using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class ProductFeature
    {
        public int ProductFeatureID { get; set; }

        public string Feature_TR { get; set; }
        public string Feature_EN { get; set; }

        // İlişki
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
