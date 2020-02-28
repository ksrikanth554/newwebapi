using Microsoft.EntityFrameworkCore.Migrations;

namespace Companies.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyNames",
                columns: table => new
                {
                    CompanyName = table.Column<string>(nullable: false),
                    number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyNames", x => x.CompanyName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyNames");
        }
    }
}
