using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObligatorioAPI.Migrations
{
    /// <inheritdoc />
    public partial class agregoProductoColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Colores_IDColor",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_IDColor",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "IDColor",
                table: "Productos");

            migrationBuilder.CreateTable(
                name: "ProductoColores",
                columns: table => new
                {
                    ProductoID = table.Column<int>(type: "int", nullable: false),
                    ColorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoColores", x => new { x.ProductoID, x.ColorID });
                    table.ForeignKey(
                        name: "FK_ProductoColores_Colores_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Colores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoColores_Productos_ProductoID",
                        column: x => x.ProductoID,
                        principalTable: "Productos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoColores_ColorID",
                table: "ProductoColores",
                column: "ColorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoColores");

            migrationBuilder.AddColumn<int>(
                name: "IDColor",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IDColor",
                table: "Productos",
                column: "IDColor");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Colores_IDColor",
                table: "Productos",
                column: "IDColor",
                principalTable: "Colores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
