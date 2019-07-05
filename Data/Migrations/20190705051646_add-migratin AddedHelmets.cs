using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GearShopV2.Data.Migrations
{
    public partial class addmigratinAddedHelmets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Helmet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HBrand = table.Column<string>(nullable: false),
                    HModel = table.Column<string>(nullable: false),
                    HColor = table.Column<string>(nullable: true),
                    HSize = table.Column<string>(nullable: false),
                    HPrice = table.Column<double>(nullable: false),
                    HSalePrice = table.Column<double>(nullable: false),
                    HQtyOnHand = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helmet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Helmet");
        }
    }
}
