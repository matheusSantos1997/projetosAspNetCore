using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MP.ApiDotNet6.Infra.Data.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pessoa",
                columns: table => new
                {
                    idpessoa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    documento = table.Column<string>(type: "text", nullable: false),
                    celular = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pessoa", x => x.idpessoa);
                });

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    idproduto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    coderp = table.Column<string>(type: "text", nullable: false),
                    preco = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.idproduto);
                });

            migrationBuilder.CreateTable(
                name: "compra",
                columns: table => new
                {
                    idcompra = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idproduto = table.Column<int>(type: "integer", nullable: false),
                    idpessoa = table.Column<int>(type: "integer", nullable: false),
                    datacompra = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compra", x => x.idcompra);
                    table.ForeignKey(
                        name: "FK_compra_pessoa_idpessoa",
                        column: x => x.idpessoa,
                        principalTable: "pessoa",
                        principalColumn: "idpessoa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_compra_produto_idproduto",
                        column: x => x.idproduto,
                        principalTable: "produto",
                        principalColumn: "idproduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_compra_idpessoa",
                table: "compra",
                column: "idpessoa");

            migrationBuilder.CreateIndex(
                name: "IX_compra_idproduto",
                table: "compra",
                column: "idproduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "compra");

            migrationBuilder.DropTable(
                name: "pessoa");

            migrationBuilder.DropTable(
                name: "produto");
        }
    }
}
