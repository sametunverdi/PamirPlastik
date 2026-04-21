using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PamirPlastik.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_about_relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutID",
                table: "AboutSliderImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AboutID",
                table: "AboutFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AboutSliderImages_AboutID",
                table: "AboutSliderImages",
                column: "AboutID");

            migrationBuilder.CreateIndex(
                name: "IX_AboutFeatures_AboutID",
                table: "AboutFeatures",
                column: "AboutID");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutFeatures_Abouts_AboutID",
                table: "AboutFeatures",
                column: "AboutID",
                principalTable: "Abouts",
                principalColumn: "AboutID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AboutSliderImages_Abouts_AboutID",
                table: "AboutSliderImages",
                column: "AboutID",
                principalTable: "Abouts",
                principalColumn: "AboutID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutFeatures_Abouts_AboutID",
                table: "AboutFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_AboutSliderImages_Abouts_AboutID",
                table: "AboutSliderImages");

            migrationBuilder.DropIndex(
                name: "IX_AboutSliderImages_AboutID",
                table: "AboutSliderImages");

            migrationBuilder.DropIndex(
                name: "IX_AboutFeatures_AboutID",
                table: "AboutFeatures");

            migrationBuilder.DropColumn(
                name: "AboutID",
                table: "AboutSliderImages");

            migrationBuilder.DropColumn(
                name: "AboutID",
                table: "AboutFeatures");
        }
    }
}
