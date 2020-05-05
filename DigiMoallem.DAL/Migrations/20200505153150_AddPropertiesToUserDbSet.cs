using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddPropertiesToUserDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Works",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EducationalLevel",
                table: "Works",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sheba",
                table: "Works",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Users",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EducationalLevel",
                table: "Users",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sheba",
                table: "Users",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "EducationalLevel",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "Sheba",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EducationalLevel",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Sheba",
                table: "Users");
        }
    }
}
