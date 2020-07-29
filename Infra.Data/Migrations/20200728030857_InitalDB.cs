using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class InitalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Data_Nascimento = table.Column<DateTime>(nullable: false),
                    RG = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Clientes", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Enderecos",
                columns: table => new
                {
                    EnderecoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    ClienteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Enderecos", x => x.EnderecoID);
                    table.ForeignKey(
                        name: "FK_tb_Enderecos_tb_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "tb_Clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Enderecos_ClienteID",
                table: "tb_Enderecos",
                column: "ClienteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Enderecos");

            migrationBuilder.DropTable(
                name: "tb_Clientes");
        }
    }
}
