using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class OffPriceToCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Off",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "OffPercent",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Off",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "OffPercent",
                table: "Courses");
        }
    }
}
