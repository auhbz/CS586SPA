using Microsoft.EntityFrameworkCore.Migrations;

namespace Comp586ProjectServer.Migrations
{
    public partial class fixedrelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.CreateIndex(
                name: "IX_BoardGame_DesignerId",
                table: "BoardGame",
                column: "DesignerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoardGames_Designers",
                table: "BoardGame",
                column: "DesignerId",
                principalTable: "Designer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoardGames_Designers",
                table: "BoardGame");

            migrationBuilder.DropIndex(
                name: "IX_BoardGame_DesignerId",
                table: "BoardGame");

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });
        }
    }
}
