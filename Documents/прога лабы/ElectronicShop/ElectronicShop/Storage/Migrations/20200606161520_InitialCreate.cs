using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectronicShop.Storage.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblDevice",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDevice", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    DeviceId = table.Column<Guid>(nullable: false),
                    nameofcategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                    table.ForeignKey(
                        name: "FK_Categories_tblDevice_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "tblDevice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Costs",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    DeviceId = table.Column<Guid>(nullable: false),
                    costInDollars = table.Column<double>(nullable: false),
                    costInRub = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.id);
                    table.ForeignKey(
                        name: "FK_Costs_tblDevice_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "tblDevice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    DeviceId = table.Column<Guid>(nullable: false),
                    warrantyduration = table.Column<double>(nullable: false),
                    power = table.Column<double>(nullable: false),
                    weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.id);
                    table.ForeignKey(
                        name: "FK_Features_tblDevice_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "tblDevice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlacesInTop",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    middleAge = table.Column<int>(nullable: false),
                    highAge = table.Column<int>(nullable: false),
                    lowAge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacesInTop", x => x.id);
                    table.ForeignKey(
                        name: "FK_PlacesInTop_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponsibleConsultants",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    mark = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibleConsultants", x => x.id);
                    table.ForeignKey(
                        name: "FK_ResponsibleConsultants_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BattaryFeatures",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    FeaturesId = table.Column<Guid>(nullable: false),
                    battaryCapacity = table.Column<int>(nullable: false),
                    voltage = table.Column<double>(nullable: false),
                    currentOutput = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattaryFeatures", x => x.id);
                    table.ForeignKey(
                        name: "FK_BattaryFeatures_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BattaryFeatures_FeaturesId",
                table: "BattaryFeatures",
                column: "FeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DeviceId",
                table: "Categories",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Costs_DeviceId",
                table: "Costs",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_DeviceId",
                table: "Features",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacesInTop_CategoryId",
                table: "PlacesInTop",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibleConsultants_CategoryId",
                table: "ResponsibleConsultants",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BattaryFeatures");

            migrationBuilder.DropTable(
                name: "Costs");

            migrationBuilder.DropTable(
                name: "PlacesInTop");

            migrationBuilder.DropTable(
                name: "ResponsibleConsultants");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "tblDevice");
        }
    }
}
