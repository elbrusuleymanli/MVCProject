using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class AddCaregoryId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetailImageByCategories_CourseDetailCategories_CourseDetailCategoryId",
                table: "CourseDetailImageByCategories");

            migrationBuilder.AlterColumn<int>(
                name: "CourseDetailCategoryId",
                table: "CourseDetailImageByCategories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetailImageByCategories_CourseDetailCategories_CourseDetailCategoryId",
                table: "CourseDetailImageByCategories",
                column: "CourseDetailCategoryId",
                principalTable: "CourseDetailCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetailImageByCategories_CourseDetailCategories_CourseDetailCategoryId",
                table: "CourseDetailImageByCategories");

            migrationBuilder.AlterColumn<int>(
                name: "CourseDetailCategoryId",
                table: "CourseDetailImageByCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetailImageByCategories_CourseDetailCategories_CourseDetailCategoryId",
                table: "CourseDetailImageByCategories",
                column: "CourseDetailCategoryId",
                principalTable: "CourseDetailCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
