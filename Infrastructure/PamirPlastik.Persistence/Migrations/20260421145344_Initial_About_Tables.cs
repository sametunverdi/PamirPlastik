using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PamirPlastik.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial_About_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutFeatures_Abouts_AboutID",
                table: "AboutFeatures");

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

            migrationBuilder.DropColumn(
                name: "CtaSubText_EN",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "CtaSubText_TR",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "CtaTitle_EN",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "CtaTitle_TR",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "FacilitySectionBadge_EN",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "FacilitySectionBadge_TR",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "FacilitySectionTitle_EN",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "FacilitySectionTitle_TR",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MetaDescription_EN",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MetaDescription_TR",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MetaTitle_EN",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MetaTitle_TR",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MissionBadge_EN",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MissionBadge_TR",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MissionSubText_EN",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MissionSubText_TR",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MissionText_EN",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MissionText_TR",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Stat1Label_EN",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Stat1Label_TR",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AboutFeatures");

            migrationBuilder.RenameColumn(
                name: "VisionText_TR",
                table: "Abouts",
                newName: "VisionTitle_TR");

            migrationBuilder.RenameColumn(
                name: "VisionText_EN",
                table: "Abouts",
                newName: "VisionTitle_EN");

            migrationBuilder.RenameColumn(
                name: "VisionSubText_TR",
                table: "Abouts",
                newName: "VisionDescription_TR");

            migrationBuilder.RenameColumn(
                name: "VisionSubText_EN",
                table: "Abouts",
                newName: "VisionDescription_EN");

            migrationBuilder.RenameColumn(
                name: "VisionBadge_TR",
                table: "Abouts",
                newName: "SubTitle_TR");

            migrationBuilder.RenameColumn(
                name: "VisionBadge_EN",
                table: "Abouts",
                newName: "SubTitle_EN");

            migrationBuilder.RenameColumn(
                name: "StoryTitle_TR",
                table: "Abouts",
                newName: "SeoTitle_TR");

            migrationBuilder.RenameColumn(
                name: "StoryTitle_EN",
                table: "Abouts",
                newName: "SeoTitle_EN");

            migrationBuilder.RenameColumn(
                name: "StorySubtitle_TR",
                table: "Abouts",
                newName: "SeoDescription_TR");

            migrationBuilder.RenameColumn(
                name: "StorySubtitle_EN",
                table: "Abouts",
                newName: "SeoDescription_EN");

            migrationBuilder.RenameColumn(
                name: "StoryQuote_TR",
                table: "Abouts",
                newName: "MissionTitle_TR");

            migrationBuilder.RenameColumn(
                name: "StoryQuote_EN",
                table: "Abouts",
                newName: "MissionTitle_EN");

            migrationBuilder.RenameColumn(
                name: "StoryParagraph3_TR",
                table: "Abouts",
                newName: "MissionDescription_TR");

            migrationBuilder.RenameColumn(
                name: "StoryParagraph3_EN",
                table: "Abouts",
                newName: "MissionDescription_EN");

            migrationBuilder.RenameColumn(
                name: "StoryParagraph2_TR",
                table: "Abouts",
                newName: "MainTitle_TR");

            migrationBuilder.RenameColumn(
                name: "StoryParagraph2_EN",
                table: "Abouts",
                newName: "MainTitle_EN");

            migrationBuilder.RenameColumn(
                name: "StoryParagraph1_TR",
                table: "Abouts",
                newName: "HighlightQuote_TR");

            migrationBuilder.RenameColumn(
                name: "StoryParagraph1_EN",
                table: "Abouts",
                newName: "HighlightQuote_EN");

            migrationBuilder.RenameColumn(
                name: "Stat2Value",
                table: "Abouts",
                newName: "Description2_TR");

            migrationBuilder.RenameColumn(
                name: "Stat2Label_TR",
                table: "Abouts",
                newName: "Description2_EN");

            migrationBuilder.RenameColumn(
                name: "Stat2Label_EN",
                table: "Abouts",
                newName: "Description1_TR");

            migrationBuilder.RenameColumn(
                name: "Stat1Value",
                table: "Abouts",
                newName: "Description1_EN");

            migrationBuilder.RenameColumn(
                name: "AboutID",
                table: "Abouts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AboutID",
                table: "AboutFeatures",
                newName: "AboutId");

            migrationBuilder.RenameColumn(
                name: "AboutFeatureID",
                table: "AboutFeatures",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_AboutFeatures_AboutID",
                table: "AboutFeatures",
                newName: "IX_AboutFeatures_AboutId");

            migrationBuilder.AddColumn<string>(
                name: "FeatureType",
                table: "AboutFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ValueOrIcon",
                table: "AboutFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AboutImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AltText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AltText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutImages_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutImages_AboutId",
                table: "AboutImages",
                column: "AboutId");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutFeatures_Abouts_AboutId",
                table: "AboutFeatures",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutFeatures_Abouts_AboutId",
                table: "AboutFeatures");

            migrationBuilder.DropTable(
                name: "AboutImages");

            migrationBuilder.DropColumn(
                name: "FeatureType",
                table: "AboutFeatures");

            migrationBuilder.DropColumn(
                name: "ValueOrIcon",
                table: "AboutFeatures");

            migrationBuilder.RenameColumn(
                name: "VisionTitle_TR",
                table: "Abouts",
                newName: "VisionText_TR");

            migrationBuilder.RenameColumn(
                name: "VisionTitle_EN",
                table: "Abouts",
                newName: "VisionText_EN");

            migrationBuilder.RenameColumn(
                name: "VisionDescription_TR",
                table: "Abouts",
                newName: "VisionSubText_TR");

            migrationBuilder.RenameColumn(
                name: "VisionDescription_EN",
                table: "Abouts",
                newName: "VisionSubText_EN");

            migrationBuilder.RenameColumn(
                name: "SubTitle_TR",
                table: "Abouts",
                newName: "VisionBadge_TR");

            migrationBuilder.RenameColumn(
                name: "SubTitle_EN",
                table: "Abouts",
                newName: "VisionBadge_EN");

            migrationBuilder.RenameColumn(
                name: "SeoTitle_TR",
                table: "Abouts",
                newName: "StoryTitle_TR");

            migrationBuilder.RenameColumn(
                name: "SeoTitle_EN",
                table: "Abouts",
                newName: "StoryTitle_EN");

            migrationBuilder.RenameColumn(
                name: "SeoDescription_TR",
                table: "Abouts",
                newName: "StorySubtitle_TR");

            migrationBuilder.RenameColumn(
                name: "SeoDescription_EN",
                table: "Abouts",
                newName: "StorySubtitle_EN");

            migrationBuilder.RenameColumn(
                name: "MissionTitle_TR",
                table: "Abouts",
                newName: "StoryQuote_TR");

            migrationBuilder.RenameColumn(
                name: "MissionTitle_EN",
                table: "Abouts",
                newName: "StoryQuote_EN");

            migrationBuilder.RenameColumn(
                name: "MissionDescription_TR",
                table: "Abouts",
                newName: "StoryParagraph3_TR");

            migrationBuilder.RenameColumn(
                name: "MissionDescription_EN",
                table: "Abouts",
                newName: "StoryParagraph3_EN");

            migrationBuilder.RenameColumn(
                name: "MainTitle_TR",
                table: "Abouts",
                newName: "StoryParagraph2_TR");

            migrationBuilder.RenameColumn(
                name: "MainTitle_EN",
                table: "Abouts",
                newName: "StoryParagraph2_EN");

            migrationBuilder.RenameColumn(
                name: "HighlightQuote_TR",
                table: "Abouts",
                newName: "StoryParagraph1_TR");

            migrationBuilder.RenameColumn(
                name: "HighlightQuote_EN",
                table: "Abouts",
                newName: "StoryParagraph1_EN");

            migrationBuilder.RenameColumn(
                name: "Description2_TR",
                table: "Abouts",
                newName: "Stat2Value");

            migrationBuilder.RenameColumn(
                name: "Description2_EN",
                table: "Abouts",
                newName: "Stat2Label_TR");

            migrationBuilder.RenameColumn(
                name: "Description1_TR",
                table: "Abouts",
                newName: "Stat2Label_EN");

            migrationBuilder.RenameColumn(
                name: "Description1_EN",
                table: "Abouts",
                newName: "Stat1Value");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Abouts",
                newName: "AboutID");

            migrationBuilder.RenameColumn(
                name: "AboutId",
                table: "AboutFeatures",
                newName: "AboutID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AboutFeatures",
                newName: "AboutFeatureID");

            migrationBuilder.RenameIndex(
                name: "IX_AboutFeatures_AboutId",
                table: "AboutFeatures",
                newName: "IX_AboutFeatures_AboutID");

            migrationBuilder.AddColumn<string>(
                name: "CtaSubText_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CtaSubText_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CtaTitle_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CtaTitle_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FacilitySectionBadge_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FacilitySectionBadge_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FacilitySectionTitle_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FacilitySectionTitle_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MetaTitle_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionBadge_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionBadge_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionSubText_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionSubText_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionText_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionText_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Stat1Label_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Stat1Label_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AboutFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "AboutSliderImages",
                columns: table => new
                {
                    AboutSliderImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutID = table.Column<int>(type: "int", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSliderImages", x => x.AboutSliderImageID);
                    table.ForeignKey(
                        name: "FK_AboutSliderImages_Abouts_AboutID",
                        column: x => x.AboutID,
                        principalTable: "Abouts",
                        principalColumn: "AboutID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MetaDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FairDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StandNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Text_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text_TR = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    BadgeText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BadgeText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MetaDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryButtonText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryButtonText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryButtonUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryButtonText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryButtonText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryButtonUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEnd_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEnd_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleHighlight_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleHighlight_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleMain_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleMain_TR = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Label_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Title_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_TR = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    ButtonText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    StatLabel_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatLabel_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleHighlight_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleHighlight_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleMain_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleMain_TR = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    MetaDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageName = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Address_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteName_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteName_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    MonthlyDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    BoxDimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoxQuantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoxWeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    LoadingCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ColorHex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorName_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorName_TR = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Feature_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature_TR = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ImageAlt_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt_TR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_AboutSliderImages_AboutID",
                table: "AboutSliderImages",
                column: "AboutID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AboutFeatures_Abouts_AboutID",
                table: "AboutFeatures",
                column: "AboutID",
                principalTable: "Abouts",
                principalColumn: "AboutID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
