using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Persistencia.Migrations
{
    public partial class TB_DistintivosPagina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DistintivosPagina",
                schema: "prods",
                columns: table => new
                {
                    IdDistintivo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Tipo = table.Column<int>(nullable: false),
                    Texto = table.Column<string>(maxLength: 6, nullable: true),
                    CodigoColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistintivosPagina", x => x.IdDistintivo);
                });

            migrationBuilder.CreateTable(
                name: "DistintivosProductos",
                schema: "prods",
                columns: table => new
                {
                    IdDistintivo = table.Column<int>(nullable: false),
                    IdProducto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistintivosProductos", x => new { x.IdProducto, x.IdDistintivo });
                    table.ForeignKey(
                        name: "FK_DistintivosProductos_DistintivosPagina_IdDistintivo",
                        column: x => x.IdDistintivo,
                        principalSchema: "prods",
                        principalTable: "DistintivosPagina",
                        principalColumn: "IdDistintivo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistintivosProductos_Productos_IdProducto",
                        column: x => x.IdProducto,
                        principalSchema: "prods",
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistintivosProductos_IdDistintivo",
                schema: "prods",
                table: "DistintivosProductos",
                column: "IdDistintivo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistintivosProductos",
                schema: "prods");

            migrationBuilder.DropTable(
                name: "DistintivosPagina",
                schema: "prods");
        }
    }
}
