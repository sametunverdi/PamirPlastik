using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class ManufacturingFeature
    {
        public int ManufacturingFeatureID { get; set; }

        // ── TR ALANLAR ───────────────────────────────────────────
        public string Title_TR { get; set; }       // "Geniş Makine Parkuru"
        public string Description_TR { get; set; } // Açıklama TR

        // ── EN ALANLAR ───────────────────────────────────────────
        public string Title_EN { get; set; }       // "Wide Machine Park"
        public string Description_EN { get; set; } // Açıklama EN

        // ── DİL BAĞIMSIZ ─────────────────────────────────────────
        public string IconName { get; set; }       // İkon adı → "archive", "shield-check", "globe"
        public bool IsActive { get; set; }         // Gösterilsin mi?
    }
}
