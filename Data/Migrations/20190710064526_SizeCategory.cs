using Microsoft.EntityFrameworkCore.Migrations;

namespace GearShopV2.Data.Migrations
{
    public partial class SizeCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PSizeCat",
                table: "Pant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JSizeCat",
                table: "Jersey",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HSizeCat",
                table: "Helmet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PSizeCat",
                table: "Pant");

            migrationBuilder.DropColumn(
                name: "JSizeCat",
                table: "Jersey");

            migrationBuilder.DropColumn(
                name: "HSizeCat",
                table: "Helmet");
        }
    }
}
