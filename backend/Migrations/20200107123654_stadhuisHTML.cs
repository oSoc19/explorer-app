using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class stadhuisHTML : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "<strong>1280</strong><br>Après un incendie dans le Beffroi sur la Grand-Place, les échevins prennent possession de la « ghyselhuus », l’ancienne prison comtale.<br><br><strong>1376</strong><br> Le comte Lodewijk van Male fait démolir la « ghyselhuus » pour la remplacer par une véritable « scepenhuus » imaginée par Jan Roegiers.<br><br><strong>1887</strong><br> Un incendie ravage l’intérieur.<br><br><strong>1895-1905</strong><br>Louis Delacenserie et Jean-Baptiste de Béthune rénovent l’intérieur dans un style néogothique.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "FR Description <br> test test");
        }
    }
}
