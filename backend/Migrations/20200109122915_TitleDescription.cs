using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class TitleDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Name",
                value: "La Place du Bourg");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Name",
                value: "De Burg");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Name",
                value: "The Burg Square");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Name",
                value: "Der Burgplatz");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Name",
                value: "La Plaza Burg");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Name",
                value: "Maison du Franc de Bruges ");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Name",
                value: "Landhuis van het Brugse Vrije ");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Name",
                value: "Manor of the Franc of Bruges ");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Name",
                value: "Landeshaus des Brügger Freiamts ");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Name",
                value: "Mansión del Franconato de Brujas");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Name",
                value: "Ancien Greffe Civil");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Name",
                value: "Oude Civiele Griffie");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Name",
                value: "Old Civil Registry");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Name",
                value: "Antigua Escribanía civil");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Name",
                value: "Basilique du Saint-Sang");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Name",
                value: "Basiliek van het Heilig Bloed");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Name",
                value: "Basilica of the Holy Blood");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Name",
                value: "Heilig-Blut-Basilika");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Name",
                value: "Basílica de la Santa Sangre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Name",
                value: "Place du Bourg");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Name",
                value: "Burg");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Name",
                value: "Burg Square");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Name",
                value: "Burg");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Name",
                value: "Burg");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Name",
                value: "Maison du Franc de Bruges");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Name",
                value: "Landhuis");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Name",
                value: "Manor House");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Name",
                value: "Landeshaus");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Name",
                value: "Landhuis");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Name",
                value: "Greffe");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Name",
                value: "Griffie");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Name",
                value: "Registry");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Name",
                value: "Escribanía civil");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Name",
                value: "Basilique");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Name",
                value: "Basiliek");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Name",
                value: "Basilic");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Name",
                value: "Basilika");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Name",
                value: "Basílica");
        }
    }
}
