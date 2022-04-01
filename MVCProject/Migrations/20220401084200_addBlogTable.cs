using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class addBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogCards");

            migrationBuilder.DropColumn(
                name: "Button",
                table: "HomeBlogs");

            migrationBuilder.DropColumn(
                name: "CommentIcon",
                table: "HomeBlogs");

            migrationBuilder.DropColumn(
                name: "LinkIcon",
                table: "HomeBlogs");

            migrationBuilder.AddColumn<int>(
                name: "CountComment",
                table: "BlogDetailCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "BlogDetailCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "BlogDetailCards",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountComment",
                table: "BlogDetailCards");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "BlogDetailCards");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "BlogDetailCards");

            migrationBuilder.AddColumn<string>(
                name: "Button",
                table: "HomeBlogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommentIcon",
                table: "HomeBlogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkIcon",
                table: "HomeBlogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BlogCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Button = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountComment = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkIcon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCards", x => x.Id);
                });
        }
    }
}
