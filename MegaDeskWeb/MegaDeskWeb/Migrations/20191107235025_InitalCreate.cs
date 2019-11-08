using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskWeb.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(maxLength: 40, nullable: false),
                    RushDays = table.Column<int>(nullable: false),
                    QuoteDate = table.Column<DateTime>(nullable: false),
                    QuotePrice = table.Column<double>(nullable: false),
                    RushPricing = table.Column<double>(nullable: false),
                    MaterialCost = table.Column<double>(nullable: false),
                    SurfaceArea = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Depth = table.Column<double>(nullable: false),
                    NumDrawers = table.Column<int>(nullable: false),
                    MaterialString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskQuote");
        }
    }
}
