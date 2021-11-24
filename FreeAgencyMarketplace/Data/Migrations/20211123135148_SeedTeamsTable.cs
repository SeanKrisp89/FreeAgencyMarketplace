using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeAgencyMarketplace.Data.Migrations
{
    public partial class SeedTeamsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "ActiveRosterCount",
                table: "Teams",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.AlterColumn<byte>(
                name: "ActiveRosterCount",
                table: "Teams",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true);
        }
    }
}
