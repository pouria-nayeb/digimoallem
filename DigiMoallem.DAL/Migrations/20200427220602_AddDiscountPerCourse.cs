using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddDiscountPerCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscountPerCourseId",
                table: "UserDiscountCodes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RemaningIncome",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DiscountPerCourses",
                columns: table => new
                {
                    DiscountPerCourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DiscountCode = table.Column<string>(maxLength: 150, nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    DiscountPercent = table.Column<int>(nullable: false),
                    UsableCount = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountPerCourses", x => x.DiscountPerCourseId);
                    table.ForeignKey(
                        name: "FK_DiscountPerCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserDiscountCodes_DiscountPerCourseId",
                table: "UserDiscountCodes",
                column: "DiscountPerCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountPerCourses_CourseId",
                table: "DiscountPerCourses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDiscountCodes_DiscountPerCourses_DiscountPerCourseId",
                table: "UserDiscountCodes",
                column: "DiscountPerCourseId",
                principalTable: "DiscountPerCourses",
                principalColumn: "DiscountPerCourseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDiscountCodes_DiscountPerCourses_DiscountPerCourseId",
                table: "UserDiscountCodes");

            migrationBuilder.DropTable(
                name: "DiscountPerCourses");

            migrationBuilder.DropIndex(
                name: "IX_UserDiscountCodes_DiscountPerCourseId",
                table: "UserDiscountCodes");

            migrationBuilder.DropColumn(
                name: "DiscountPerCourseId",
                table: "UserDiscountCodes");

            migrationBuilder.DropColumn(
                name: "RemaningIncome",
                table: "Courses");
        }
    }
}
