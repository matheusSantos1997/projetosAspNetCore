using Microsoft.EntityFrameworkCore.Migrations;

namespace testeOneToOne.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersOne",
                columns: table => new
                {
                    idUserOne = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "varchar(100)", nullable: true),
                    email = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersOne", x => x.idUserOne);
                });

            migrationBuilder.CreateTable(
                name: "UsersTwo",
                columns: table => new
                {
                    idUserTwo = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "varchar(100)", nullable: true),
                    email = table.Column<string>(type: "varchar(50)", nullable: true),
                    UserOneRef = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTwo", x => x.idUserTwo);
                    table.ForeignKey(
                        name: "FK_UsersTwo_UsersOne_UserOneRef",
                        column: x => x.UserOneRef,
                        principalTable: "UsersOne",
                        principalColumn: "idUserOne",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersTwo_UserOneRef",
                table: "UsersTwo",
                column: "UserOneRef",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersTwo");

            migrationBuilder.DropTable(
                name: "UsersOne");
        }
    }
}
