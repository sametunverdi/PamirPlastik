using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PamirPlastik.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutFeatures",
                columns: table => new
                {
                    AboutFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Title_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutFeatures", x => x.AboutFeatureID);
                });

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoryTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StorySubtitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StorySubtitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryParagraph1_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryParagraph1_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryParagraph2_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryParagraph2_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryQuote_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryQuote_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryParagraph3_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoryParagraph3_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacilitySectionBadge_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacilitySectionBadge_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacilitySectionTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacilitySectionTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stat1Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stat1Label_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stat1Label_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stat2Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stat2Label_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stat2Label_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisionBadge_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisionBadge_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisionText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisionText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisionSubText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisionSubText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MissionBadge_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MissionBadge_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MissionText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MissionText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MissionSubText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MissionSubText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CtaTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CtaTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CtaSubText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CtaSubText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "AboutSliderImages",
                columns: table => new
                {
                    AboutSliderImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSliderImages", x => x.AboutSliderImageID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MetaTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Fairs",
                columns: table => new
                {
                    FairID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StandNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FairDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImagePath1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fairs", x => x.FairID);
                });

            migrationBuilder.CreateTable(
                name: "HeroBadges",
                columns: table => new
                {
                    HeroBadgeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroBadges", x => x.HeroBadgeID);
                });

            migrationBuilder.CreateTable(
                name: "HeroSections",
                columns: table => new
                {
                    HeroSectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BadgeText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleMain_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleHighlight_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEnd_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryButtonText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryButtonText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BadgeText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleMain_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleHighlight_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEnd_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryButtonText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryButtonText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryButtonUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryButtonUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MetaTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroSections", x => x.HeroSectionID);
                });

            migrationBuilder.CreateTable(
                name: "HeroStats",
                columns: table => new
                {
                    HeroStatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroStats", x => x.HeroStatID);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturingFeatures",
                columns: table => new
                {
                    ManufacturingFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturingFeatures", x => x.ManufacturingFeatureID);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturingSections",
                columns: table => new
                {
                    ManufacturingSectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleMain_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleHighlight_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleMain_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleHighlight_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatLabel_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatLabel_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturingSections", x => x.ManufacturingSectionID);
                });

            migrationBuilder.CreateTable(
                name: "SeoSettings",
                columns: table => new
                {
                    SeoSettingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeoSettings", x => x.SeoSettingID);
                });

            migrationBuilder.CreateTable(
                name: "SiteSettings",
                columns: table => new
                {
                    SiteSettingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteName_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteName_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.SiteSettingID);
                });

            migrationBuilder.CreateTable(
                name: "TrendyolSettings",
                columns: table => new
                {
                    TrendyolSettingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthlyDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewCount = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrendyolSettings", x => x.TrendyolSettingID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoxDimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoxWeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadingCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoxQuantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    MetaTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductColors",
                columns: table => new
                {
                    ProductColorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorName_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorHex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColors", x => x.ProductColorID);
                    table.ForeignKey(
                        name: "FK_ProductColors_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    ProductFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feature_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.ProductFeatureID);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ProductImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ProductImageID);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ProductID",
                table: "ProductColors",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductID",
                table: "ProductFeatures",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductID",
                table: "ProductImages",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutFeatures");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "AboutSliderImages");

            migrationBuilder.DropTable(
                name: "Fairs");

            migrationBuilder.DropTable(
                name: "HeroBadges");

            migrationBuilder.DropTable(
                name: "HeroSections");

            migrationBuilder.DropTable(
                name: "HeroStats");

            migrationBuilder.DropTable(
                name: "ManufacturingFeatures");

            migrationBuilder.DropTable(
                name: "ManufacturingSections");

            migrationBuilder.DropTable(
                name: "ProductColors");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "SeoSettings");

            migrationBuilder.DropTable(
                name: "SiteSettings");

            migrationBuilder.DropTable(
                name: "TrendyolSettings");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
