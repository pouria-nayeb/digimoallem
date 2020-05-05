using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class UpdateSettingsDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Help",
                table: "Settings",
                newName: "Standards");

            migrationBuilder.AddColumn<string>(
                name: "ContributeDigiMoallem",
                table: "Settings",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Files",
                table: "Settings",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductionRules",
                table: "Settings",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rules",
                table: "Settings",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContributeDigiMoallem",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Files",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "ProductionRules",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Rules",
                table: "Settings");

            migrationBuilder.RenameColumn(
                name: "Standards",
                table: "Settings",
                newName: "Help");
        }
    }
}
