using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class HeroBadge
    {
        public int HeroBadgeID { get; set; }   // Kaydın benzersiz numarası

        public string Text_TR { get; set; }    // Badge yazısı TR → "ISO 9001 Sertifikalı"
        public string Text_EN { get; set; }    // Badge yazısı EN → "ISO 9001 Certified"

        public string IconName { get; set; }   // İkon adı → "shield-check", "leaf", "truck"

        public bool IsActive { get; set; }     // Gösterilsin mi? → true/false
    }
}
