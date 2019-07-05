using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GearShopV2.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jersey",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JBrand = table.Column<string>(nullable: false),
                    JModel = table.Column<string>(nullable: false),
                    JColor = table.Column<string>(nullable: true),
                    JSize = table.Column<string>(nullable: false),
                    JPrice = table.Column<double>(nullable: false),
                    JSalePrice = table.Column<double>(nullable: false),
                    JQtyOnHand = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jersey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PBrand = table.Column<string>(nullable: false),
                    PModel = table.Column<string>(nullable: false),
                    PColor = table.Column<string>(nullable: true),
                    PSize = table.Column<string>(nullable: false),
                    PPrice = table.Column<double>(nullable: false),
                    PSalePrice = table.Column<double>(nullable: false),
                    PQtyOnHand = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pant", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jersey");

            migrationBuilder.DropTable(
                name: "Pant");
        }
    }
}
