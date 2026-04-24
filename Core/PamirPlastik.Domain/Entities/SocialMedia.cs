using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }

        public string PlatformName { get; set; } // Örn: "Instagram"
        public string IconClass { get; set; } // Örn: "fa-brands fa-instagram"
        public string Url { get; set; } // Örn: "https://instagram.com/pamirplastik"

        public bool IsActive { get; set; } // Admin panelinden gizleyip açmak için
    }
}
