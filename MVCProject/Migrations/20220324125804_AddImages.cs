using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class AddImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseDetailImages");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CourseDetailCategories");

            migrationBuilder.CreateTable(
                name: "CourseDetailImageByCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Describtion = table.Column<string>(nullable: true),
                    CourseDetailCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetailImageByCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseDetailImageByCategories_CourseDetailCategories_CourseDetailCategoryId",
                        column: x => x.CourseDetailCategoryId,
                        principalTable: "CourseDetailCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetailImageByCategories_CourseDetailCategoryId",
                table: "CourseDetailImageByCategories",
                column: "CourseDetailCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseDetailImageByCategories");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CourseDetailCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseDetailImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetailImages", x => x.Id);
                });
        }
    }
}
