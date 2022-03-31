using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class TableBanners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "AboutEduHomes");

            migrationBuilder.AddColumn<string>(
                name: "TitleOne",
                table: "AboutEduHomes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleSecond",
                table: "AboutEduHomes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleOne",
                table: "AboutEduHomes");

            migrationBuilder.DropColumn(
                name: "TitleSecond",
                table: "AboutEduHomes");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "AboutEduHomes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
