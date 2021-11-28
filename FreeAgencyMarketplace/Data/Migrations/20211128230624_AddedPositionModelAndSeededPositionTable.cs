using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeAgencyMarketplace.Data.Migrations
{
    public partial class AddedPositionModelAndSeededPositionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Quarterback" },
                    { 2, "Running back" },
                    { 3, "Wide Receiver" },
                    { 4, "Tight End" },
                    { 5, "Cornerback" },
                    { 6, "Outside Linebacker" },
                    { 7, "Middle Linebacker" },
                    { 8, "Defenseive End" },
                    { 9, "Safety" },
                    { 10, "Defensive Tacke" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
