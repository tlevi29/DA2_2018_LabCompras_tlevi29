using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DA2_2018_LabCompras_tlevi29.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    ContaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativa = table.Column<bool>(nullable: false),
                    NomeTitular = table.Column<string>(nullable: false),
                    Saldo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.ContaID);
                });

            migrationBuilder.CreateTable(
                name: "Despesas",
                columns: table => new
                {
                    DespesaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Categoria = table.Column<string>(nullable: false),
                    NomeDespesa = table.Column<string>(nullable: false),
                    Pago = table.Column<bool>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesas", x => x.DespesaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Despesas");
        }
    }
}
