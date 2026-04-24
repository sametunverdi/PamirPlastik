using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }

        // 1. ÜST BÖLÜM (Genel Merkez Yazısı)
        public string Title_TR { get; set; }
        public string Title_EN { get; set; }
        public string Description_TR { get; set; }
        public string Description_EN { get; set; }

        // 2. TELEFON BÖLÜMÜ DETAYLARI
        public string PhoneTitle_TR { get; set; } // HTML'deki "Hızlı Destek Hattı"
        public string PhoneTitle_EN { get; set; }
        public string Phone { get; set; } // "+90 212 555 01 23"
        public string PhoneDescription_TR { get; set; } // HTML'deki "7/24 Teknik Destek"
        public string PhoneDescription_EN { get; set; }

        // 3. E-POSTA BÖLÜMÜ DETAYLARI
        public string EmailTitle_TR { get; set; } // HTML'deki "Global Satış / Export"
        public string EmailTitle_EN { get; set; }
        public string Email { get; set; } // "info@pamirplastik.com"
        public string EmailDescription_TR { get; set; } // HTML'deki "Geri Dönüş: ~120 Dakika"
        public string EmailDescription_EN { get; set; }

        // 4. HARİTA BÖLÜMÜ DETAYLARI
        public string MapLocation { get; set; } // Harita iframe linki
        public string MapTitle_TR { get; set; } // Harita üstündeki "Fabrika & Merkez" başlığı
        public string MapTitle_EN { get; set; }
        public string Address_TR { get; set; } // "İkitelli OSB..." adres metni
        public string Address_EN { get; set; }
    }
}
