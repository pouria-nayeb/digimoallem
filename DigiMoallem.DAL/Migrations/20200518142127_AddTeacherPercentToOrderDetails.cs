using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddTeacherPercentToOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherPercent",
                table: "OrderDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeacherPercent",
                table: "OrderDetails");
        }
    }
}
