using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddCommentQADbSetToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommentQAs",
                columns: table => new
                {
                    CommentQAId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Body = table.Column<string>(maxLength: 750, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    ReadByAdmin = table.Column<bool>(nullable: false),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentQAs", x => x.CommentQAId);
                    table.ForeignKey(
                        name: "FK_CommentQAs_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentQAs_CommentQAs_ParentId",
                        column: x => x.ParentId,
                        principalTable: "CommentQAs",
                        principalColumn: "CommentQAId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentQAs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentQAs_CourseId",
                table: "CommentQAs",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentQAs_ParentId",
                table: "CommentQAs",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentQAs_UserId",
                table: "CommentQAs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentQAs");
        }
    }
}
