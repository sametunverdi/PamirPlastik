using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class TrendyolSetting
    {
        public int TrendyolSettingID { get; set; }

        public string StoreUrl { get; set; }
        // "https://www.trendyol.com/magaza/pamir-plastik"

        public string Rating { get; set; }
        // "4.8"

        public string MonthlyDelivery { get; set; }
        // "10k+"

        public string ReviewCount { get; set; }
        // "5k+"
    }
}
