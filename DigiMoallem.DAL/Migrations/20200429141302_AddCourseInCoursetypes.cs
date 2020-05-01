using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddCourseInCoursetypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CourseInCourseType",
                columns: table => new
                {
                    CourseInCourseTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    CourseTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInCourseType", x => x.CourseInCourseTypeId);
                    table.ForeignKey(
                        name: "FK_CourseInCourseType_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseInCourseType_CourseTypes_CourseTypeId",
                        column: x => x.CourseTypeId,
                        principalTable: "CourseTypes",
                        principalColumn: "CourseTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseInCourseType_CourseId",
                table: "CourseInCourseType",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInCourseType_CourseTypeId",
                table: "CourseInCourseType",
                column: "CourseTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseInCourseType");

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
    }
}
