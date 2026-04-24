using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class ContactMessage
    {
        public int ContactMessageID { get; set; }

        // Formdan Gelen Alanlar (HTML'deki inputlara birebir uygun)
        public string FullName { get; set; } // Ad Soyad
        public string Email { get; set; } // E-Posta
        public string Company { get; set; } // Şirket / Kurum
        public string Subject { get; set; } // İletişim Konusu (Select kutusundan gelen)
        public string MessageDetail { get; set; } // Mesajınızın Detayı (Textarea)

        // Arka Plan Bilgileri (Admin Paneli İçin)
        public DateTime SendDate { get; set; } // Mesajın gönderildiği tarih
        public bool IsRead { get; set; } // Admin paneli için "Okundu/Okunmadı" durumu
    }
}
