using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class CorrecionArticulosPorLista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticulosPorLista_ListasEscolares_ListaEscolarIdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista");

            migrationBuilder.DropIndex(
                name: "IX_ArticulosPorLista_ListaEscolarIdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista");

            migrationBuilder.DropColumn(
                name: "ListaEscolarIdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista");

            migrationBuilder.RenameColumn(
                name: "IdLista",
                schema: "mkt",
                table: "ArticulosPorLista",
                newName: "IdListaEscolar");

            migrationBuilder.CreateIndex(
                name: "IX_ArticulosPorLista_IdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista",
                column: "IdListaEscolar");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticulosPorLista_ListasEscolares_IdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista",
                column: "IdListaEscolar",
                principalSchema: "mkt",
                principalTable: "ListasEscolares",
                principalColumn: "IdListaEscolar",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticulosPorLista_ListasEscolares_IdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista");

            migrationBuilder.DropIndex(
                name: "IX_ArticulosPorLista_IdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista");

            migrationBuilder.RenameColumn(
                name: "IdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista",
                newName: "IdLista");

            migrationBuilder.AddColumn<int>(
                name: "ListaEscolarIdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArticulosPorLista_ListaEscolarIdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista",
                column: "ListaEscolarIdListaEscolar");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticulosPorLista_ListasEscolares_ListaEscolarIdListaEscolar",
                schema: "mkt",
                table: "ArticulosPorLista",
                column: "ListaEscolarIdListaEscolar",
                principalSchema: "mkt",
                principalTable: "ListasEscolares",
                principalColumn: "IdListaEscolar",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
