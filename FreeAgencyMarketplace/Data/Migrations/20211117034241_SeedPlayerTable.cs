using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeAgencyMarketplace.Data.Migrations
{
    public partial class SeedPlayerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "IsFreeAgent", "Name", "Position" },
                values: new object[] { 1, 22, false, "Justin Fields", "Quarterback" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
