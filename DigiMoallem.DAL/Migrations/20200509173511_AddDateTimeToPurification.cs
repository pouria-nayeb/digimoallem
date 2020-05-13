using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddDateTimeToPurification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SubmitDate",
                table: "Purifications",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Purifications_CourseId",
                table: "Purifications",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Purifications_TeacherId",
                table: "Purifications",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purifications_Courses_CourseId",
                table: "Purifications",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purifications_Users_TeacherId",
                table: "Purifications",
                column: "TeacherId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purifications_Courses_CourseId",
                table: "Purifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Purifications_Users_TeacherId",
                table: "Purifications");

            migrationBuilder.DropIndex(
                name: "IX_Purifications_CourseId",
                table: "Purifications");

            migrationBuilder.DropIndex(
                name: "IX_Purifications_TeacherId",
                table: "Purifications");

            migrationBuilder.DropColumn(
                name: "SubmitDate",
                table: "Purifications");
        }
    }
}
