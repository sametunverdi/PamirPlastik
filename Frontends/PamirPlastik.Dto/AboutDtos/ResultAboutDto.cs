using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Dto.AboutDtos
{
    public class ResultAboutDto
    {
        public int AboutID { get; set; }

        // Tarihçe Bölümü (Sol ve Sağ Taraf)
        public string StoryTitle { get; set; }
        public string StorySubtitle { get; set; }
        public string StoryParagraph1 { get; set; }
        public string StoryParagraph2 { get; set; }
        public string StoryQuote { get; set; }
        public string StoryParagraph3 { get; set; }

        // Tesis ve İstatistik Bölümü
        public string FacilitySectionBadge { get; set; }
        public string FacilitySectionTitle { get; set; }
        public string Stat1Value { get; set; }
        public string Stat1Label { get; set; }
        public string Stat2Value { get; set; }
        public string Stat2Label { get; set; }

        // Vizyon & Misyon Bölümü
        public string VisionBadge { get; set; }
        public string VisionText { get; set; }
        public string MissionBadge { get; set; }
        public string MissionText { get; set; }

        // SEO
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
    }
}