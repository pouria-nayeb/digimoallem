using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddAdvertising : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CourseEpisodes",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Advertises",
                columns: table => new
                {
                    AdvertiseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageName = table.Column<string>(maxLength: 200, nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Url = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertises", x => x.AdvertiseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertises");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CourseEpisodes");
        }
    }
}
