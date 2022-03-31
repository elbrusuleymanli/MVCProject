using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class CourseDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Button",
                table: "CourseDetailCard");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "CourseDetailCard");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "CourseDetailCard");

            migrationBuilder.AddColumn<string>(
                name: "Descr",
                table: "CourseDetailCard",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descr",
                table: "CourseDetailCard");

            migrationBuilder.AddColumn<string>(
                name: "Button",
                table: "CourseDetailCard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "CourseDetailCard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "CourseDetailCard",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
