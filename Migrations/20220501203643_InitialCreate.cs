using Microsoft.EntityFrameworkCore.Migrations;

namespace CIDM3312_Final.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hunters",
                columns: table => new
                {
                    HunterID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    HRank = table.Column<int>(nullable: false),
                    MRank = table.Column<int>(nullable: false),
                    TDmg = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hunters", x => x.HunterID);
                });

            migrationBuilder.CreateTable(
                name: "Hunts",
                columns: table => new
                {
                    HuntID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Monster = table.Column<string>(maxLength: 60, nullable: false),
                    H1Name = table.Column<string>(maxLength: 60, nullable: false),
                    H1Dmg = table.Column<int>(nullable: false),
                    H2Name = table.Column<string>(maxLength: 60, nullable: true),
                    H2Dmg = table.Column<int>(nullable: false),
                    H3Name = table.Column<string>(maxLength: 60, nullable: true),
                    H3Dmg = table.Column<int>(nullable: false),
                    H4Name = table.Column<string>(maxLength: 60, nullable: true),
                    H4Dmg = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hunts", x => x.HuntID);
                });

            migrationBuilder.CreateTable(
                name: "HuntersHunts",
                columns: table => new
                {
                    HunterID = table.Column<int>(nullable: false),
                    HuntID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuntersHunts", x => new { x.HunterID, x.HuntID });
                    table.ForeignKey(
                        name: "FK_HuntersHunts_Hunts_HuntID",
                        column: x => x.HuntID,
                        principalTable: "Hunts",
                        principalColumn: "HuntID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HuntersHunts_Hunters_HunterID",
                        column: x => x.HunterID,
                        principalTable: "Hunters",
                        principalColumn: "HunterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuntersHunts_HuntID",
                table: "HuntersHunts",
                column: "HuntID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HuntersHunts");

            migrationBuilder.DropTable(
                name: "Hunts");

            migrationBuilder.DropTable(
                name: "Hunters");
        }
    }
}
