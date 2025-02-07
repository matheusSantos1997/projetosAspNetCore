using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CadastroPessoa.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pessoas",
                columns: table => new
                {
                    idPessoa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomePessoa = table.Column<string>(type: "text", nullable: false),
                    documento = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    contatoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pessoas", x => x.idPessoa);
                });

            migrationBuilder.CreateTable(
                name: "contatos",
                columns: table => new
                {
                    idContato = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomeContato = table.Column<string>(type: "text", nullable: false),
                    telefone = table.Column<string>(type: "text", nullable: false),
                    pessoaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contatos", x => x.idContato);
                    table.ForeignKey(
                        name: "FK_Contato_PessoaId",
                        column: x => x.pessoaId,
                        principalTable: "pessoas",
                        principalColumn: "idPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    idProduto = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomeProduto = table.Column<string>(type: "text", nullable: false),
                    tipoProduto = table.Column<string>(type: "text", nullable: false),
                    preco = table.Column<string>(type: "text", nullable: false),
                    pessoaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.idProduto);
                    table.ForeignKey(
                        name: "FK_Produto_PessoaId",
                        column: x => x.pessoaId,
                        principalTable: "pessoas",
                        principalColumn: "idPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contatos_pessoaId",
                table: "contatos",
                column: "pessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_produtos_pessoaId",
                table: "produtos",
                column: "pessoaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contatos");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "pessoas");
        }
    }
}
