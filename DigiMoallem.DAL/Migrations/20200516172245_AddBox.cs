using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddBox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoxId",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BoxId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Box",
                columns: table => new
                {
                    BoxId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Box", x => x.BoxId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BoxId",
                table: "Payments",
                column: "BoxId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BoxId",
                table: "Orders",
                column: "BoxId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Box_BoxId",
                table: "Orders",
                column: "BoxId",
                principalTable: "Box",
                principalColumn: "BoxId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Box_BoxId",
                table: "Payments",
                column: "BoxId",
                principalTable: "Box",
                principalColumn: "BoxId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Box_BoxId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Box_BoxId",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "Box");

            migrationBuilder.DropIndex(
                name: "IX_Payments_BoxId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_BoxId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BoxId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "BoxId",
                table: "Orders");
        }
    }
}
