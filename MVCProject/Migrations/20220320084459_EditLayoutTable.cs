using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class EditLayoutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Option1",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "Option2",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "Option3",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "Option4",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "Option5",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "Option6",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "Option7",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "Option8",
                table: "Layouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Option1",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option2",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option3",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option4",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option5",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option6",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option7",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option8",
                table: "Layouts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
