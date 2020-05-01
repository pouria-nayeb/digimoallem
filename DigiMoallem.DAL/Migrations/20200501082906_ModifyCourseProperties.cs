using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class ModifyCourseProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerIncome",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Totalncome",
                table: "Courses",
                newName: "UserBalance");

            migrationBuilder.RenameColumn(
                name: "TeacherIncome",
                table: "Courses",
                newName: "TotalPayment");

            migrationBuilder.RenameColumn(
                name: "RemaningIncome",
                table: "Courses",
                newName: "TotalIncome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserBalance",
                table: "Courses",
                newName: "Totalncome");

            migrationBuilder.RenameColumn(
                name: "TotalPayment",
                table: "Courses",
                newName: "TeacherIncome");

            migrationBuilder.RenameColumn(
                name: "TotalIncome",
                table: "Courses",
                newName: "RemaningIncome");

            migrationBuilder.AddColumn<int>(
                name: "OwnerIncome",
                table: "Courses",
                nullable: true);
        }
    }
}
