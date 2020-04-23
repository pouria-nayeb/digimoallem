using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiMoallem.DAL.Migrations
{
    public partial class AddWorksDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    WorkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 75, nullable: false),
                    LastName = table.Column<string>(maxLength: 75, nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 12, nullable: true),
                    Mobile = table.Column<string>(maxLength: 12, nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    CvTitle = table.Column<string>(nullable: true),
                    AvatarName = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
                    SubmitDate = table.Column<DateTime>(nullable: false),
                    ContributionFields = table.Column<string>(maxLength: 1500, nullable: true),
                    Skills = table.Column<string>(maxLength: 1500, nullable: true),
                    Experiences = table.Column<string>(maxLength: 1500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.WorkId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Works");
        }
    }
}
