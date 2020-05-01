using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class ModifyCourseTypesDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseTypes_CourseTypeId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseTypeId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseTypeId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "CourseTypes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseTypes_CourseId",
                table: "CourseTypes",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTypes_Courses_CourseId",
                table: "CourseTypes",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTypes_Courses_CourseId",
                table: "CourseTypes");

            migrationBuilder.DropIndex(
                name: "IX_CourseTypes_CourseId",
                table: "CourseTypes");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "CourseTypes");

            migrationBuilder.AddColumn<int>(
                name: "CourseTypeId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseTypeId",
                table: "Courses",
                column: "CourseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseTypes_CourseTypeId",
                table: "Courses",
                column: "CourseTypeId",
                principalTable: "CourseTypes",
                principalColumn: "CourseTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
