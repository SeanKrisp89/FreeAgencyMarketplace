using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeAgencyMarketplace.Data.Migrations
{
    public partial class SeedPlayersAndTeamsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "ActiveRosterCount", "City", "Conference", "Division", "Name", "Stadium" },
                values: new object[,]
                {
                    { 1, null, "Chicago", "NFC", "North", "Bears", "Soldier Field" },
                    { 2, null, "Kansas City", "AFC", "West", "Chiefs", "Arrowhead" },
                    { 3, null, "Tampa Bay", "NFC", "South", "Buccaneers", "Raymond James" },
                    { 4, null, "Boston", "AFC", "East", "Patriots", "Gillette Stadium" },
                    { 5, null, "Cincinnati", "AFC", "North", "Bengals", "Paul Brown Stadium" },
                    { 6, null, "Nashville", "AFC", "South", "Titans", "Nissan Stadium" },
                    { 7, null, "Los Angeles", "NFC", "West", "Rams", "SoFi Stadium" },
                    { 8, null, "Philadelphia", "NFC", "East", "Eagles", "Lincoln Financial" },
                    { 9, null, "Detroit", "NFC", "North", "Lions", "Ford Field" },
                    { 10, null, "New Orleans", "NFC", "South", "Saints", "Cesars Superdome" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "IsFreeAgent", "Name", "Position", "TeamId" },
                values: new object[,]
                {
                    { 1, 22, false, "Justin Fields", "Quarterback", 1 },
                    { 2, 25, false, "Roquan Smith", "Middle Linebacker", 1 },
                    { 3, 29, false, "Byron Murphy", "Cornerback", 1 },
                    { 4, 30, false, "Aaron Donald", "Defensive Tackle", 1 },
                    { 5, 26, false, "Cooper Kupp", "Wide Receiver", 1 },
                    { 6, 27, false, "Austin Ekeler", "Runningback", 1 },
                    { 7, 25, false, "Fred Warner", "Middle Linebacker", 1 },
                    { 8, 27, false, "J.J. Watt", "Outside Linebacker", 1 },
                    { 9, 28, false, "Nick Bosa", "Defensive End", 1 },
                    { 10, 28, false, "Jamaal Adams", "Free Safety", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
