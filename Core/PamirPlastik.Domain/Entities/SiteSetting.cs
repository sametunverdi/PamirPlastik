using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class SiteSetting
    {
        public int SiteSettingID { get; set; }

        // ── LOGO & MARKA ─────────────────────────────
        public string LogoPath { get; set; }
        // "/uploads/logo.webp"

        public string SiteName_TR { get; set; }
        // "Pamir Plastik"

        public string SiteName_EN { get; set; }
        // "Pamir Plastik"

        // ── İLETİŞİM ────────────────────────────────
        public string Phone { get; set; }
        // "+90 212 000 00 00"

        public string Email { get; set; }
        // "info@pamirplastik.com"

        public string Address_TR { get; set; }
        // "İstanbul, Türkiye"

        public string Address_EN { get; set; }
        // "Istanbul, Turkey"

        // ── SOSYAL MEDYA ─────────────────────────────
        public string Instagram { get; set; }
        // "https://instagram.com/pamirplastik"

        public string Facebook { get; set; }
        // "https://facebook.com/pamirplastik"

        public string Linkedin { get; set; }
        // "https://linkedin.com/company/pamirplastik"

        public string Youtube { get; set; }
        // "https://youtube.com/pamirplastik"
    }
}
