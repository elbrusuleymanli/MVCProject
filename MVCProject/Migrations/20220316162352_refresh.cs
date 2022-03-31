using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class refresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EventRight",
                table: "EventRight");

            migrationBuilder.RenameTable(
                name: "EventRight",
                newName: "EventRights");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventRights",
                table: "EventRights",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EventRights",
                table: "EventRights");

            migrationBuilder.RenameTable(
                name: "EventRights",
                newName: "EventRight");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventRight",
                table: "EventRight",
                column: "Id");
        }
    }
}
