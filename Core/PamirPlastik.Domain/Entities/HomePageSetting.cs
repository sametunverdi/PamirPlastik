using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class HomePageSetting
    {
        public int HomePageSettingID { get; set; }

        // --- Hero Section ---
        public string? HeroTitleTop_TR { get; set; }
        public string? HeroTitleTop_EN { get; set; }
        public string? HeroTitleMain_TR { get; set; }
        public string? HeroTitleMain_EN { get; set; }
        public string? HeroDescription_TR { get; set; }
        public string? HeroDescription_EN { get; set; }
        public string? HeroImageUrl { get; set; }
        public string? ExperienceYear { get; set; }
        public string? ProductTypeCount { get; set; }
        public string? ExportCountryCount { get; set; }

        // --- Production Power Section ---
        public string? ProdTitleTop_TR { get; set; }
        public string? ProdTitleTop_EN { get; set; }
        public string? ProdTitleMain_TR { get; set; }
        public string? ProdTitleMain_EN { get; set; }
        public string? ProdDescription_TR { get; set; }
        public string? ProdDescription_EN { get; set; }
        public string? ProdImageUrl { get; set; }
        
        public string? ProdItem1Title_TR { get; set; }
        public string? ProdItem1Title_EN { get; set; }
        public string? ProdItem1Desc_TR { get; set; }
        public string? ProdItem1Desc_EN { get; set; }
        public string? ProdItem1Icon { get; set; }

        public string? ProdItem2Title_TR { get; set; }
        public string? ProdItem2Title_EN { get; set; }
        public string? ProdItem2Desc_TR { get; set; }
        public string? ProdItem2Desc_EN { get; set; }
        public string? ProdItem2Icon { get; set; }

        public string? ProdItem3Title_TR { get; set; }
        public string? ProdItem3Title_EN { get; set; }
        public string? ProdItem3Desc_TR { get; set; }
        public string? ProdItem3Desc_EN { get; set; }
        public string? ProdItem3Icon { get; set; }

        // --- Ecommerce Stats Section ---
        public string? EcomStoreScore { get; set; }
        public string? EcomDeliveryMonthly { get; set; }
        public string? EcomCommentCount { get; set; }
        public string? EcomStoreLink { get; set; }

        // --- Global Network Section ---
        public string? GlobExportCountry { get; set; }
        public string? GlobContinent { get; set; }
        public string? GlobDealer { get; set; }
        public string? GlobSectorYear { get; set; }

        // --- Categories Component Titles ---
        public string? CatTitleTop_TR { get; set; }
        public string? CatTitleTop_EN { get; set; }
        public string? CatTitleMain_TR { get; set; }
        public string? CatTitleMain_EN { get; set; }
        public string? CatDescription_TR { get; set; }
        public string? CatDescription_EN { get; set; }

        // --- Featured Products Component Titles ---
        public string? FeatTitleTop_TR { get; set; }
        public string? FeatTitleTop_EN { get; set; }
        public string? FeatTitleMain_TR { get; set; }
        public string? FeatTitleMain_EN { get; set; }

        // --- Fairs Component Titles ---
        public string? FairTitleTop_TR { get; set; }
        public string? FairTitleTop_EN { get; set; }
        public string? FairTitleMain_TR { get; set; }
        public string? FairTitleMain_EN { get; set; }
        public string? FairDescription_TR { get; set; }
        public string? FairDescription_EN { get; set; }
    }
}
