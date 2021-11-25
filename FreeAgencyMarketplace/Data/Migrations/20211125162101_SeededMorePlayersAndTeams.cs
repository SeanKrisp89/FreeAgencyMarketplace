using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeAgencyMarketplace.Data.Migrations
{
    public partial class SeededMorePlayersAndTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "TeamId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "TeamId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "TeamId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                column: "TeamId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                column: "TeamId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                column: "TeamId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                column: "TeamId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                column: "TeamId",
                value: 6);

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "IsFreeAgent", "Name", "Position", "TeamId" },
                values: new object[,]
                {
                    { 11, 22, false, "Jalen Hurts", "Quarterback", 8 },
                    { 12, 24, false, "T.J. Hockenson", "Tight End", 9 },
                    { 13, 28, false, "Alvin Kamara", "Running back", 10 }
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Division", "Name", "Stadium" },
                values: new object[] { "Miami", "East", "Dolphins", "Hard Rock Stadium" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Conference", "Division", "Name", "Stadium" },
                values: new object[] { "Los Angeles", "AFC", "West", "Chargers", "SoFi Stadium" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Conference", "Division", "Name", "Stadium" },
                values: new object[] { "San Francisco", "NFC", "West", "49ers", "Levi's Stadium" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Name", "Stadium" },
                values: new object[] { "Pittsburgh", "Steelers", "Heinz Field" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Conference", "Division", "Name", "Stadium" },
                values: new object[] { "Seattle", "NFC", "West", "Seahawks", "Century Link Stadium" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "TeamId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "TeamId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "TeamId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                column: "TeamId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                column: "TeamId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                column: "TeamId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                column: "TeamId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                column: "TeamId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Division", "Name", "Stadium" },
                values: new object[] { "Kansas City", "West", "Chiefs", "Arrowhead" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Conference", "Division", "Name", "Stadium" },
                values: new object[] { "Tampa Bay", "NFC", "South", "Buccaneers", "Raymond James" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Conference", "Division", "Name", "Stadium" },
                values: new object[] { "Boston", "AFC", "East", "Patriots", "Gillette Stadium" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Name", "Stadium" },
                values: new object[] { "Cincinnati", "Bengals", "Paul Brown Stadium" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Conference", "Division", "Name", "Stadium" },
                values: new object[] { "Nashville", "AFC", "South", "Titans", "Nissan Stadium" });
        }
    }
}
