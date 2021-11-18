using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeAgencyMarketplace.Data.Migrations
{
    public partial class AddedPlayersToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "IsFreeAgent", "Name", "Position" },
                values: new object[,]
                {
                    { 2, 25, false, "Roquan Smith", "Middle Linebacker" },
                    { 3, 29, false, "Byron Murphy", "Cornerback" },
                    { 4, 30, false, "Aaron Donald", "Defensive Tackle" },
                    { 5, 26, false, "Cooper Kupp", "Wide Receiver" },
                    { 6, 27, false, "Austin Ekeler", "Runningback" },
                    { 7, 25, false, "Fred Warner", "Middle Linebacker" },
                    { 8, 27, false, "J.J. Watt", "Outside Linebacker" },
                    { 9, 28, false, "Nick Bosa", "Defensive End" },
                    { 10, 28, false, "Jamaal Adams", "Free Safety" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
