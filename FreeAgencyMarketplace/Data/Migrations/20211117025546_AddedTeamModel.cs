using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeAgencyMarketplace.Data.Migrations
{
    public partial class AddedTeamModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Division = table.Column<string>(nullable: false),
                    Conference = table.Column<string>(nullable: false),
                    Stadium = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    ActiveRosterCount = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
