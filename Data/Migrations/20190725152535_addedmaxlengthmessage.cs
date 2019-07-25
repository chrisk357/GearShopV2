using Microsoft.EntityFrameworkCore.Migrations;

namespace GearShopV2.Data.Migrations
{
    public partial class addedmaxlengthmessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "contactMessage",
                table: "ContactUs",
                maxLength: 1024,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "contactMessage",
                table: "ContactUs",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1024);
        }
    }
}
