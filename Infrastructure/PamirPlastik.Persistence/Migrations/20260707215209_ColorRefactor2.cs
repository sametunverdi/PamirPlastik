using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PamirPlastik.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ColorRefactor2 : Migration
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
                name: "ColorHex",
                table: "ProductColors");

            migrationBuilder.DropColumn(
                name: "ColorName",
                table: "ProductColors");

            migrationBuilder.RenameColumn(
                name: "ProductColorID",
                table: "ProductColors",
                newName: "ColorID");

            migrationBuilder.AlterColumn<int>(
                name: "ColorID",
                table: "ProductColors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors",
                columns: new[] { "ProductID", "ColorID" });

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
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_Colors_ColorID",
                table: "ProductColors");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors");

            migrationBuilder.DropIndex(
                name: "IX_ProductColors_ColorID",
                table: "ProductColors");

            migrationBuilder.RenameColumn(
                name: "ColorID",
                table: "ProductColors",
                newName: "ProductColorID");

            migrationBuilder.AlterColumn<int>(
                name: "ProductColorID",
                table: "ProductColors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ColorHex",
                table: "ProductColors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColorName",
                table: "ProductColors",
                type: "nvarchar(max)",
                nullable: true);

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
