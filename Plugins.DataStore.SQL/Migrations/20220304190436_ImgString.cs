using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class ImgString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Products");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Products",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
