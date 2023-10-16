using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLINICA_ALPHAVILLE.Migrations
{
    public partial class CLINICAALPHAVILLE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListaPacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Profissao = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    HorariosDisponiveis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeDoPai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeDaMae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responsavel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atendimento1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atendimento2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atendimento3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atendimento4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atendimento5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaPacientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListaPacientes");
        }
    }
}
