using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Persistencia.Migrations
{
    public partial class TB_Productos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                schema: "prods",
                columns: table => new
                {
                    IdProducto = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nombre = table.Column<string>(maxLength: 60, nullable: true),
                    NombreBuscador = table.Column<string>(maxLength: 200, nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    UrlImagen = table.Column<string>(nullable: true),
                    TieneImagen = table.Column<bool>(nullable: false),
                    Disponible = table.Column<bool>(nullable: false),
                    AgotarPorInventario = table.Column<bool>(nullable: false),
                    ListaFavor = table.Column<bool>(nullable: false),
                    Peso = table.Column<double>(nullable: false),
                    SecuenciaPagina = table.Column<int>(nullable: false),
                    SecuenciaIdRemision = table.Column<int>(nullable: false),
                    IdMarca = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Productos_Marcas_IdMarca",
                        column: x => x.IdMarca,
                        principalSchema: "prods",
                        principalTable: "Marcas",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdMarca",
                schema: "prods",
                table: "Productos",
                column: "IdMarca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos",
                schema: "prods");
        }
    }
}
