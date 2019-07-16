using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class dateformat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Deathdate",
                table: "Artist",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Birthdate",
                table: "Artist",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Deathdate",
                table: "Artist",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Artist",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
