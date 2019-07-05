using Microsoft.EntityFrameworkCore.Migrations;

namespace GearShopV2.Data.Migrations
{
    public partial class AddedImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PImageUrl",
                table: "Pant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JImageUrl",
                table: "Jersey",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HImageUrl",
                table: "Helmet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PImageUrl",
                table: "Pant");

            migrationBuilder.DropColumn(
                name: "JImageUrl",
                table: "Jersey");

            migrationBuilder.DropColumn(
                name: "HImageUrl",
                table: "Helmet");
        }
    }
}
