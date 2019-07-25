using Microsoft.EntityFrameworkCore.Migrations;

namespace GearShopV2.Data.Migrations
{
    public partial class ContactUsIdError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactUsId",
                table: "ContactUs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactUs_ContactUsId",
                table: "ContactUs",
                column: "ContactUsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUs_ContactUs_ContactUsId",
                table: "ContactUs",
                column: "ContactUsId",
                principalTable: "ContactUs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactUs_ContactUs_ContactUsId",
                table: "ContactUs");

            migrationBuilder.DropIndex(
                name: "IX_ContactUs_ContactUsId",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "ContactUsId",
                table: "ContactUs");
        }
    }
}
