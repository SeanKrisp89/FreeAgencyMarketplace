using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeAgencyMarketplace.Data.Migrations
{
    public partial class UpdatedTeamsDataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Defensive Tackel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Defensive Tacke");
        }
    }
}
