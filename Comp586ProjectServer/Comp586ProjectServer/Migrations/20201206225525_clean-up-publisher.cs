using Microsoft.EntityFrameworkCore.Migrations;

namespace Comp586ProjectServer.Migrations
{
    public partial class cleanuppublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "BoardGame");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "BoardGame",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
