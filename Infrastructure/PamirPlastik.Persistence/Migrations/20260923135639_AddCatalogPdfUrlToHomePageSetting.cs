using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PamirPlastik.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCatalogPdfUrlToHomePageSetting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors");

            migrationBuilder.DropIndex(
                name: "IX_ProductColors_ProductID",
                table: "ProductColors");

            migrationBuilder.DropColumn(
                name: "ProductColorID",
                table: "ProductColors");

            migrationBuilder.AddColumn<string>(
                name: "CatalogPdfUrl",
                table: "HomePageSettings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ShowOnHome",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors",
                columns: new[] { "ProductID", "ColorID" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors");

            migrationBuilder.DropColumn(
                name: "CatalogPdfUrl",
                table: "HomePageSettings");

            migrationBuilder.DropColumn(
                name: "ShowOnHome",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "ProductColorID",
                table: "ProductColors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors",
                column: "ProductColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ProductID",
                table: "ProductColors",
                column: "ProductID");
        }
    }
}
