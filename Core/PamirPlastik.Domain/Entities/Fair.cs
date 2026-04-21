using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class Fair
    {
        public int FairID { get; set; }

        // ── TR ALANLAR ──────────────────────────────
        public string Name_TR { get; set; }
        // "Ambiente Frankfurt" (TR için aynı kalabilir)

        public string Description_TR { get; set; }
        // "Dünyanın en prestijli ev gereçleri fuarında..."

        public string ImageAlt_TR { get; set; }
        // SEO için → "Ambiente Frankfurt Fuarı Pamir Plastik Standı"

        // ── EN ALANLAR ──────────────────────────────
        public string Name_EN { get; set; }
        // "Ambiente Frankfurt"

        public string Description_EN { get; set; }
        // "We take our place on the global stage..."

        public string ImageAlt_EN { get; set; }
        // "Ambiente Frankfurt Fair Pamir Plastik Stand"

        // ── DİL BAĞIMSIZ ────────────────────────────
        public string Location { get; set; }
        // "Frankfurt / Almanya"

        public string StandNo { get; set; }
        // "Hall 9.2 / B51"

        public DateTime FairDate { get; set; }
        // 2026-02-07 → görünürde "07 Şubat" olacak

        public string ImagePath1 { get; set; }
        // "/uploads/fairs/ambiente-1.webp" → normal görsel

        public string ImagePath2 { get; set; }
        // "/uploads/fairs/ambiente-2.webp" → hover görseli

        public bool IsActive { get; set; }
        // false yapınca o fuar kartı hiç görünmez
    }
}
