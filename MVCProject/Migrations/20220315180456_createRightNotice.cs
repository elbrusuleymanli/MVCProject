using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class createRightNotice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NoticeSchedule",
                table: "NoticeSchedule");

            migrationBuilder.RenameTable(
                name: "NoticeSchedule",
                newName: "NoticeSchedules");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NoticeSchedules",
                table: "NoticeSchedules",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RightNotices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RightNotices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RightNotices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NoticeSchedules",
                table: "NoticeSchedules");

            migrationBuilder.RenameTable(
                name: "NoticeSchedules",
                newName: "NoticeSchedule");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NoticeSchedule",
                table: "NoticeSchedule",
                column: "Id");
        }
    }
}
