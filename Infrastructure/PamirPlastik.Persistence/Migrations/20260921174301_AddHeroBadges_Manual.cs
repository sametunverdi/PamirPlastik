using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PamirPlastik.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddHeroBadges_Manual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop ColorHex fixed

            // Drop ColorName fixed

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PlatformName",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IconClass",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription_TR",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription_EN",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name_TR",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name_EN",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Material",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MainImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullDescription_TR",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullDescription_EN",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Capacity",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BoxWeight",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BoxSize",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Slug_EN",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug_TR",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ColorID",
                table: "ProductColors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Title_TR",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title_EN",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneTitle_TR",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneTitle_EN",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneDescription_TR",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneDescription_EN",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MapTitle_TR",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MapTitle_EN",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MapLocation",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailTitle_TR",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailTitle_EN",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailDescription_TR",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailDescription_EN",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description_TR",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description_EN",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address_TR",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address_EN",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "ContactMessages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MessageDetail",
                table: "ContactMessages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "ContactMessages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ContactMessages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "ContactMessages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name_TR",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name_EN",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description_TR",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description_EN",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VisionTitle_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VisionTitle_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VisionDescription_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VisionDescription_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SubTitle_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SubTitle_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SeoTitle_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SeoTitle_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SeoDescription_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SeoDescription_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MissionTitle_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MissionTitle_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MissionDescription_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MissionDescription_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MainTitle_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MainTitle_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HighlightQuote_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HighlightQuote_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description2_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description2_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description1_TR",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description1_EN",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "AboutImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AltText_TR",
                table: "AboutImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AltText_EN",
                table: "AboutImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ValueOrIcon",
                table: "AboutFeatures",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title_TR",
                table: "AboutFeatures",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title_EN",
                table: "AboutFeatures",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FeatureType",
                table: "AboutFeatures",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description_TR",
                table: "AboutFeatures",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description_EN",
                table: "AboutFeatures",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HexCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorID);
                });

            migrationBuilder.CreateTable(
                name: "Fairs",
                columns: table => new
                {
                    FairID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFuture = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fairs", x => x.FairID);
                });

            migrationBuilder.CreateTable(
                name: "HomePageSettings",
                columns: table => new
                {
                    HomePageSettingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeroTitleTop_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroTitleTop_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroTitleMain_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroTitleMain_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductTypeCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportCountryCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroBadge1_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroBadge1_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroBadge2_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroBadge2_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroBadge3_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroBadge3_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdTitleTop_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdTitleTop_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdTitleMain_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdTitleMain_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem1Title_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem1Title_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem1Desc_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem1Desc_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem1Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem2Title_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem2Title_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem2Desc_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem2Desc_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem2Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem3Title_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem3Title_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem3Desc_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem3Desc_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdItem3Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EcomStoreScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EcomDeliveryMonthly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EcomCommentCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EcomStoreLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobExportCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobContinent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobDealer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobSectorYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatTitleTop_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatTitleTop_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatTitleMain_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatTitleMain_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatTitleTop_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatTitleTop_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatTitleMain_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatTitleMain_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FairTitleTop_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FairTitleTop_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FairTitleMain_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FairTitleMain_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FairDescription_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FairDescription_EN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageSettings", x => x.HomePageSettingID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ColorID",
                table: "ProductColors",
                column: "ColorID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_Colors_ColorID",
                table: "ProductColors",
                column: "ColorID",
                principalTable: "Colors",
                principalColumn: "ColorID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "HeroBadge1_TR", table: "HomePageSettings");
            migrationBuilder.DropColumn(name: "HeroBadge1_EN", table: "HomePageSettings");
            migrationBuilder.DropColumn(name: "HeroBadge2_TR", table: "HomePageSettings");
            migrationBuilder.DropColumn(name: "HeroBadge2_EN", table: "HomePageSettings");
            migrationBuilder.DropColumn(name: "HeroBadge3_TR", table: "HomePageSettings");
            migrationBuilder.DropColumn(name: "HeroBadge3_EN", table: "HomePageSettings");
    }
    }
}
