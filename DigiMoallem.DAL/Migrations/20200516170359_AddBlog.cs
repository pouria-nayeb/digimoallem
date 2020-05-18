using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    ImageName = table.Column<string>(maxLength: 200, nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    SubCategoryId = table.Column<int>(nullable: true),
                    AuthorId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 500, nullable: false),
                    Body = table.Column<string>(nullable: false),
                    ImageName = table.Column<string>(maxLength: 200, nullable: true),
                    Tags = table.Column<string>(maxLength: 350, nullable: true),
                    IsHidden = table.Column<bool>(nullable: false),
                    DisplayComment = table.Column<bool>(nullable: false),
                    IsCheckedByAdmin = table.Column<bool>(nullable: false),
                    IsFavorite = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Articles_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleComments",
                columns: table => new
                {
                    ArticleCommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArticleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Body = table.Column<string>(maxLength: 750, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    ReadByAdmin = table.Column<bool>(nullable: false),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleComments", x => x.ArticleCommentId);
                    table.ForeignKey(
                        name: "FK_ArticleComments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticleComments_ArticleComments_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ArticleComments",
                        principalColumn: "ArticleCommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticleComments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleComments_ArticleId",
                table: "ArticleComments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleComments_ParentId",
                table: "ArticleComments",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleComments_UserId",
                table: "ArticleComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_SubCategoryId",
                table: "Articles",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleComments");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
