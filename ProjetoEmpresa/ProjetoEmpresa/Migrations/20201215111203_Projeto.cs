using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoEmpresa.Migrations
{
    public partial class Projeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    empresaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uf = table.Column<string>(maxLength: 2, nullable: false),
                    nomeFantasia = table.Column<string>(nullable: false),
                    cnpj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.empresaId);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    idfornecedor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    empresaId = table.Column<int>(nullable: false),
                    nome = table.Column<string>(nullable: false),
                    pessoa = table.Column<string>(nullable: false),
                    cpf_cnpj = table.Column<string>(nullable: false),
                    rg = table.Column<string>(nullable: true),
                    datahora = table.Column<DateTime>(nullable: false),
                    nascimento = table.Column<int>(nullable: false),
                    telefone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.idfornecedor);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Empresas_empresaId",
                        column: x => x.empresaId,
                        principalTable: "Empresas",
                        principalColumn: "empresaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_empresaId",
                table: "Fornecedores",
                column: "empresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
