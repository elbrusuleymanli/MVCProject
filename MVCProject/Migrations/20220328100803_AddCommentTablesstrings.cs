using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCProject.Migrations
{
    public partial class AddCommentTablesstrings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_BlogCards_BlogCardId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_EventCards_EventCardId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "EventCardId",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BlogCardId",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_BlogCards_BlogCardId",
                table: "Comments",
                column: "BlogCardId",
                principalTable: "BlogCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_EventCards_EventCardId",
                table: "Comments",
                column: "EventCardId",
                principalTable: "EventCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_BlogCards_BlogCardId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_EventCards_EventCardId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "EventCardId",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlogCardId",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_BlogCards_BlogCardId",
                table: "Comments",
                column: "BlogCardId",
                principalTable: "BlogCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_EventCards_EventCardId",
                table: "Comments",
                column: "EventCardId",
                principalTable: "EventCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
