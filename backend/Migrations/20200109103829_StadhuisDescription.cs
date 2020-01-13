using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class StadhuisDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AuthorId",
                table: "Building",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AuthorId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AuthorId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AuthorId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AuthorId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 5L,
                column: "AuthorId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 6L,
                column: "AuthorId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 7L,
                column: "AuthorId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 8L,
                column: "AuthorId",
                value: 1L);

            migrationBuilder.InsertData(
                table: "BuildingTranslation",
                columns: new[] { "Id", "BuildingId", "Description", "LanguageId", "Name", "SourceLink" },
                values: new object[,]
                {
                    { 16L, 4L, "<p><strong>1280</strong><br>Après un incendie dans le Beffroi sur la Grand-Place, les échevins prennent possession de la « ghyselhuus », l’ancienne prison comtale.</p><p><strong>1376</strong><br>Le comte Lodewijk van Male fait démolir la « ghyselhuus » pour la remplacer par une véritable « scepenhuus » imaginée par Jan Roegiers.</p><p><strong>1887</strong><br>Un incendie ravage l’intérieur.</p><p><strong>1895-1905</strong><br>Louis Delacenserie et Jean-Baptiste de Béthune rénovent l’intérieur dans un style néogothique.</p>", 1L, "Hôtel de ville", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 17L, 4L, "<p><strong>1280</strong><br>na een brand in het Belfort op de Markt nemen de schepenen hun intrek in het 'ghyselhuus', de oude grafelijke gevangenis</p><p><strong>1376</strong><br>graaf Lodewijk van Male laat het 'ghyselhuus' slopen om het te vervangen door een echt 'scepenhuus', ontworpen door Jan Roegiers</p><p><strong>1887</strong><br>een brand beschadigt het interieur</p><p><strong>1895-1905</strong><br>Louis Delacenserie en Jean-Baptiste de Béthune renoveren het interieur in neogotische stijl</p>", 2L, "Stadhuis", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 18L, 4L, "<p><strong>1280</strong><br>following a fire in the Belfry on the Markt, the aldermen are moved to the ‘Ghyselhuus’, the old Count’s prison</p><p><strong>1376</strong><br>Count Lodewijk van Male orders the demolition of the ‘Ghyselhuus’, to be replaced by a proper City hall designed by Jan Roegiers</p><p><strong>1887</strong><br>the interior is damaged by a fire</p><p><strong>1895-1905</strong><br>the interior is renovated in the neo-Gothic style by Louis Delacenserie and Jean-Baptiste de Béthune</p>", 3L, "City Hall", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 19L, 4L, "<p><strong>1280</strong><br>Nach einem Brand im Belfried am Marktplatz ziehen die Schöffen in das alte Grafengefängnis „Ghyselhuus“ um. </p> <p><strong>1376</strong> <br>Graf Ludwig von Male lässt das „Ghyselhuus“ abreißen und durch ein echtes „Scepenhuus“ (Schöffenhaus) nach den Plänen von Jan Roegiers ersetzen. </p> <p><strong>1887</strong> <br>Ein Brand verursacht Schäden im Innern des Gebäudes. </p> <p><strong>1895–1905</strong> <br>Louis Delacenserie und Jean-Baptiste de Béthune renovieren den Innenbereich im neugotischen Stil. </p>", 4L, "Rathaus", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 20L, 4L, "<p><strong>1280</strong> <br>Tras un incendio en el campanario de Belfort de la plaza de <em>Markt</em>, los escabinos se instalan en el «<em>ghyselhuus</em>», la antigua cárcel condal &nbsp;</p> <p><strong>1376</strong> <br>El conde Lodewijk van Male manda derribar el «<em>ghyselhuus</em>» para reemplazarlo por una verdadera «<em>scepenhuus</em>» (casa escabinal), diseñada por Jan Roegiers</p> <p><strong>1887</strong> <br>Un incendio devasta el interior </p> <p><strong>1895-1905</strong> <br>Louis Delacenserie y Jean-Baptiste de Béthune renuevan el interior en estilo neogótico </p>", 5L, "Ayuntamiento", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Building_AuthorId",
                table: "Building",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Building_Artist_AuthorId",
                table: "Building",
                column: "AuthorId",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Building_Artist_AuthorId",
                table: "Building");

            migrationBuilder.DropIndex(
                name: "IX_Building_AuthorId",
                table: "Building");

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Building");
        }
    }
}
