using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class editChooseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgroundImage",
                table: "WhyChooses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonImage",
                table: "WhyChooses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundImage",
                table: "WhyChooses");

            migrationBuilder.DropColumn(
                name: "PersonImage",
                table: "WhyChooses");
        }
    }
}
