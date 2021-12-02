using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeAgencyMarketplace.Data.Migrations
{
    public partial class MadePositionNavigationPropInPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "PositionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "PositionId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "PositionId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "PositionId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "PositionId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                column: "PositionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                column: "PositionId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                column: "PositionId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                column: "PositionId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                column: "PositionId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                column: "PositionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                column: "PositionId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                column: "PositionId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Players_PositionId",
                table: "Players",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Positions_PositionId",
                table: "Players",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Positions_PositionId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_PositionId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Players");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "Position",
                value: "Quarterback");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "Position",
                value: "Middle Linebacker");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "Position",
                value: "Cornerback");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "Position",
                value: "Defensive Tackle");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "Position",
                value: "Wide Receiver");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                column: "Position",
                value: "Runningback");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                column: "Position",
                value: "Middle Linebacker");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                column: "Position",
                value: "Outside Linebacker");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                column: "Position",
                value: "Defensive End");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                column: "Position",
                value: "Free Safety");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                column: "Position",
                value: "Quarterback");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                column: "Position",
                value: "Tight End");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                column: "Position",
                value: "Running back");
        }
    }
}
