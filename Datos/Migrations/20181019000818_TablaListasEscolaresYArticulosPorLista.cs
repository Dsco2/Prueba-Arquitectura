using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Persistencia.Migrations
{
    public partial class TablaListasEscolaresYArticulosPorLista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "mkt");

            migrationBuilder.CreateTable(
                name: "ListasEscolares",
                schema: "mkt",
                columns: table => new
                {
                    IdListaEscolar = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Anio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListasEscolares", x => x.IdListaEscolar);
                });

            migrationBuilder.CreateTable(
                name: "ArticulosPorLista",
                schema: "mkt",
                columns: table => new
                {
                    IdArticulo = table.Column<int>(nullable: false),
                    IdLista = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    ListaEscolarIdListaEscolar = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticulosPorLista", x => new { x.IdArticulo, x.IdLista });
                    table.ForeignKey(
                        name: "FK_ArticulosPorLista_Articulos_IdArticulo",
                        column: x => x.IdArticulo,
                        principalSchema: "prods",
                        principalTable: "Articulos",
                        principalColumn: "IdArticulo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticulosPorLista_ListasEscolares_ListaEscolarIdListaEscolar",
                        column: x => x.ListaEscolarIdListaEscolar,
                        principalSchema: "mkt",
                        principalTable: "ListasEscolares",
                        principalColumn: "IdListaEscolar",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticulosPorLista_ListaEscolarIdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista",
                column: "ListaEscolarIdListaEscolar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticulosPorLista",
                schema: "mkt");

            migrationBuilder.DropTable(
                name: "ListasEscolares",
                schema: "mkt");
        }
    }
}
