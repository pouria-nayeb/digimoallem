using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddUserDiscountPerCourseDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDiscountCodePerCourses",
                columns: table => new
                {
                    UserDiscountCodePerCourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    DiscountPerCourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDiscountCodePerCourses", x => x.UserDiscountCodePerCourseId);
                    table.ForeignKey(
                        name: "FK_UserDiscountCodePerCourses_DiscountPerCourses_DiscountPerCourseId",
                        column: x => x.DiscountPerCourseId,
                        principalTable: "DiscountPerCourses",
                        principalColumn: "DiscountPerCourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserDiscountCodePerCourses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserDiscountCodePerCourses_DiscountPerCourseId",
                table: "UserDiscountCodePerCourses",
                column: "DiscountPerCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDiscountCodePerCourses_UserId",
                table: "UserDiscountCodePerCourses",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDiscountCodePerCourses");
        }
    }
}
