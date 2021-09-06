using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Modifty1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Venu",
                table: "Activities",
                newName: "Venue");

            migrationBuilder.RenameColumn(
                name: "Titile",
                table: "Activities",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Venue",
                table: "Activities",
                newName: "Venu");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Activities",
                newName: "Titile");
        }
    }
}
