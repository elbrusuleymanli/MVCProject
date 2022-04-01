using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class addTcourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseBanners");

            migrationBuilder.DropTable(
                name: "CourseCards");

            migrationBuilder.DropTable(
                name: "CourseDetailBanners");

            migrationBuilder.DropTable(
                name: "HomeCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseDetailCard",
                table: "CourseDetailCard");

            migrationBuilder.RenameTable(
                name: "CourseDetailCard",
                newName: "CourseDetailCards");

            migrationBuilder.AddColumn<string>(
                name: "BannerImage",
                table: "CourseDetailCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BannerTopic",
                table: "CourseDetailCards",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseDetailCards",
                table: "CourseDetailCards",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseDetailCards",
                table: "CourseDetailCards");

            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "CourseDetailCards");

            migrationBuilder.DropColumn(
                name: "BannerTopic",
                table: "CourseDetailCards");

            migrationBuilder.RenameTable(
                name: "CourseDetailCards",
                newName: "CourseDetailCard");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseDetailCard",
                table: "CourseDetailCard",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CourseBanners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseBanners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Button = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseDetailBanners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetailBanners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Button = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeCards", x => x.Id);
                });
        }
    }
}
