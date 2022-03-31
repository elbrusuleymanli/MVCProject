using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class EditSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "TitleDown",
                table: "Sliders",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleUp",
                table: "Sliders",
                maxLength: 300,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleDown",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "TitleUp",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Sliders",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);
        }
    }
}
