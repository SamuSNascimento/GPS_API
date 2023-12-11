using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoAlteradoRegistroFolha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FolhaPagamento_RegistroPonto_IdRegistroDePonto",
                table: "FolhaPagamento");

            migrationBuilder.DropIndex(
                name: "IX_FolhaPagamento_IdRegistroDePonto",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "IdRegistroDePonto",
                table: "FolhaPagamento");

            migrationBuilder.AddColumn<int>(
                name: "IdFolhaDePagamento",
                table: "RegistroPonto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RegistroPonto_IdFolhaDePagamento",
                table: "RegistroPonto",
                column: "IdFolhaDePagamento");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroPonto_FolhaPagamento_IdFolhaDePagamento",
                table: "RegistroPonto",
                column: "IdFolhaDePagamento",
                principalTable: "FolhaPagamento",
                principalColumn: "IdFolhaPagemento",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroPonto_FolhaPagamento_IdFolhaDePagamento",
                table: "RegistroPonto");

            migrationBuilder.DropIndex(
                name: "IX_RegistroPonto_IdFolhaDePagamento",
                table: "RegistroPonto");

            migrationBuilder.DropColumn(
                name: "IdFolhaDePagamento",
                table: "RegistroPonto");

            migrationBuilder.AddColumn<int>(
                name: "IdRegistroDePonto",
                table: "FolhaPagamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamento_IdRegistroDePonto",
                table: "FolhaPagamento",
                column: "IdRegistroDePonto");

            migrationBuilder.AddForeignKey(
                name: "FK_FolhaPagamento_RegistroPonto_IdRegistroDePonto",
                table: "FolhaPagamento",
                column: "IdRegistroDePonto",
                principalTable: "RegistroPonto",
                principalColumn: "IdRegistroPonto",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
