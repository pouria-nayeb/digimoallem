using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class RemoveAmountAndCourseIdProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Purifications");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Purifications",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Purifications",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Amount",
                table: "Purifications",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
