using Microsoft.EntityFrameworkCore.Migrations;

namespace GearShopV2.Data.Migrations
{
    public partial class ChangedSizeCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PSizeCat",
                table: "Pant",
                newName: "SizeCat");

            migrationBuilder.RenameColumn(
                name: "JSizeCat",
                table: "Jersey",
                newName: "SizeCat");

            migrationBuilder.RenameColumn(
                name: "HSizeCat",
                table: "Helmet",
                newName: "SizeCat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SizeCat",
                table: "Pant",
                newName: "PSizeCat");

            migrationBuilder.RenameColumn(
                name: "SizeCat",
                table: "Jersey",
                newName: "JSizeCat");

            migrationBuilder.RenameColumn(
                name: "SizeCat",
                table: "Helmet",
                newName: "HSizeCat");
        }
    }
}
