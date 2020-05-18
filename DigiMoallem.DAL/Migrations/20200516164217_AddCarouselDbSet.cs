using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddCarouselDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carousels",
                columns: table => new
                {
                    CarouselId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageName = table.Column<string>(maxLength: 75, nullable: false),
                    Alt = table.Column<string>(maxLength: 200, nullable: false),
                    Url = table.Column<string>(maxLength: 120, nullable: true),
                    ImageNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carousels", x => x.CarouselId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carousels");
        }
    }
}
