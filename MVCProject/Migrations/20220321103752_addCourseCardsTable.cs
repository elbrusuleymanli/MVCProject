using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class addCourseCardsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeCards",
                table: "HomeCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseCards",
                table: "CourseCards");

            migrationBuilder.RenameTable(
                name: "HomeCards",
                newName: "HomeCourseCards");

            migrationBuilder.RenameTable(
                name: "CourseCards",
                newName: "CoursesCards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeCourseCards",
                table: "HomeCourseCards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoursesCards",
                table: "CoursesCards",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeCourseCards",
                table: "HomeCourseCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoursesCards",
                table: "CoursesCards");

            migrationBuilder.RenameTable(
                name: "HomeCourseCards",
                newName: "HomeCards");

            migrationBuilder.RenameTable(
                name: "CoursesCards",
                newName: "CourseCards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeCards",
                table: "HomeCards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseCards",
                table: "CourseCards",
                column: "Id");
        }
    }
}
