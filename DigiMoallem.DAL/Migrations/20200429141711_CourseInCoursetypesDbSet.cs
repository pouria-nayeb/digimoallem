using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class CourseInCoursetypesDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInCourseType_Courses_CourseId",
                table: "CourseInCourseType");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInCourseType_CourseTypes_CourseTypeId",
                table: "CourseInCourseType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseInCourseType",
                table: "CourseInCourseType");

            migrationBuilder.RenameTable(
                name: "CourseInCourseType",
                newName: "CourseInCoursetypes");

            migrationBuilder.RenameIndex(
                name: "IX_CourseInCourseType_CourseTypeId",
                table: "CourseInCoursetypes",
                newName: "IX_CourseInCoursetypes_CourseTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseInCourseType_CourseId",
                table: "CourseInCoursetypes",
                newName: "IX_CourseInCoursetypes_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseInCoursetypes",
                table: "CourseInCoursetypes",
                column: "CourseInCourseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInCoursetypes_Courses_CourseId",
                table: "CourseInCoursetypes",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInCoursetypes_CourseTypes_CourseTypeId",
                table: "CourseInCoursetypes",
                column: "CourseTypeId",
                principalTable: "CourseTypes",
                principalColumn: "CourseTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInCoursetypes_Courses_CourseId",
                table: "CourseInCoursetypes");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInCoursetypes_CourseTypes_CourseTypeId",
                table: "CourseInCoursetypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseInCoursetypes",
                table: "CourseInCoursetypes");

            migrationBuilder.RenameTable(
                name: "CourseInCoursetypes",
                newName: "CourseInCourseType");

            migrationBuilder.RenameIndex(
                name: "IX_CourseInCoursetypes_CourseTypeId",
                table: "CourseInCourseType",
                newName: "IX_CourseInCourseType_CourseTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseInCoursetypes_CourseId",
                table: "CourseInCourseType",
                newName: "IX_CourseInCourseType_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseInCourseType",
                table: "CourseInCourseType",
                column: "CourseInCourseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInCourseType_Courses_CourseId",
                table: "CourseInCourseType",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInCourseType_CourseTypes_CourseTypeId",
                table: "CourseInCourseType",
                column: "CourseTypeId",
                principalTable: "CourseTypes",
                principalColumn: "CourseTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
