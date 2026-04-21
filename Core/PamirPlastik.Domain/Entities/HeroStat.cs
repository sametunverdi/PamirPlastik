using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class HeroStat
    {
        public int HeroStatID { get; set; }        // Kaydın benzersiz numarası

        public string Value { get; set; }          // Sayısal değer → "25+", "150+", "50+"

        public string Label_TR { get; set; }       // Sayının altındaki TR yazı → "Yıl Deneyim"
        public string Label_EN { get; set; }       // Sayının altındaki EN yazı → "Years Experience"

        public bool IsActive { get; set; }         // Gösterilsin mi? → true/false
    }
}
