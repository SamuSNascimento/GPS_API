using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class MarcoZero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalarioBase = table.Column<double>(type: "float", nullable: false),
                    ContaBancaria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.IdFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_Endereco_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ferias",
                columns: table => new
                {
                    IdFerias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoFerias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferias", x => x.IdFerias);
                    table.ForeignKey(
                        name: "FK_Ferias_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistroPonto",
                columns: table => new
                {
                    IdRegistroPonto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHoraEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorasExtras = table.Column<double>(type: "float", nullable: false),
                    Faltas = table.Column<int>(type: "int", nullable: false),
                    Atrasos = table.Column<int>(type: "int", nullable: false),
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroPonto", x => x.IdRegistroPonto);
                    table.ForeignKey(
                        name: "FK_RegistroPonto_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    IdTelefone = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroFixo = table.Column<int>(type: "int", nullable: false),
                    NumeroCell = table.Column<int>(type: "int", nullable: false),
                    DDD_Telefone = table.Column<int>(type: "int", nullable: false),
                    DDD_Celular = table.Column<int>(type: "int", nullable: false),
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.IdTelefone);
                    table.ForeignKey(
                        name: "FK_Telefone_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdFuncionario = table.Column<int>(type: "int", nullable: false),
                    NivelDeAcesso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FolhaPagamento",
                columns: table => new
                {
                    IdFolhaPagemento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalarioBase = table.Column<double>(type: "float", nullable: false),
                    Beneficios = table.Column<double>(type: "float", nullable: false),
                    HorasExtras = table.Column<double>(type: "float", nullable: false),
                    Adicionais = table.Column<double>(type: "float", nullable: false),
                    Deducoes = table.Column<double>(type: "float", nullable: false),
                    Impostos = table.Column<double>(type: "float", nullable: false),
                    ContribuicoesPrevidenciarias = table.Column<double>(type: "float", nullable: false),
                    DataFolhaPagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdFuncionario = table.Column<int>(type: "int", nullable: false),
                    IdRegistroDePonto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolhaPagamento", x => x.IdFolhaPagemento);
                    table.ForeignKey(
                        name: "FK_FolhaPagamento_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FolhaPagamento_RegistroPonto_IdRegistroDePonto",
                        column: x => x.IdRegistroDePonto,
                        principalTable: "RegistroPonto",
                        principalColumn: "IdRegistroPonto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdFuncionario",
                table: "Endereco",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_IdFuncionario",
                table: "Ferias",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamento_IdFuncionario",
                table: "FolhaPagamento",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamento_IdRegistroDePonto",
                table: "FolhaPagamento",
                column: "IdRegistroDePonto");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_CPF",
                table: "Funcionario",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegistroPonto_IdFuncionario",
                table: "RegistroPonto",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_IdFuncionario",
                table: "Telefone",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Email",
                table: "Usuario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdFuncionario",
                table: "Usuario",
                column: "IdFuncionario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UserName",
                table: "Usuario",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Ferias");

            migrationBuilder.DropTable(
                name: "FolhaPagamento");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "RegistroPonto");

            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
