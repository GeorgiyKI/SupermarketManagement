using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class Cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBuyed",
                table: "Transactions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBuyed",
                table: "Transactions");
        }
    }
}
