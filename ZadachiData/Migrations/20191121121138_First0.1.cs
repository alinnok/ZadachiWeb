using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZadachiData.Migrations
{
    public partial class First01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Zadachi",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Zadachi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "Zadachi",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Zadachi");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Zadachi");

            migrationBuilder.DropColumn(
                name: "Tag",
                table: "Zadachi");
        }
    }
}
