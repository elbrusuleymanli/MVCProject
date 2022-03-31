using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class CreateScheduleTable_EditNoticeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "NoticeBoards");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "NoticeBoards");

            migrationBuilder.CreateTable(
                name: "NoticeSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticeSchedule", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NoticeSchedule");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "NoticeBoards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "NoticeBoards",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
