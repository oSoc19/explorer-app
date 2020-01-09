using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class Landhuis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BuildingId", "Description", "Name" },
                values: new object[] { 2L, "<p><strong>11<sup>e</sup> siècle</strong><br>Construction de « Love », la résidence des comtes de Flandre.</p><p><strong>15<sup>e</sup> siècle</strong><br>L’administration du Franc de Bruges (la campagne brugeoise) déménage du bâtiment « Het Steen » pour s’installer dans ce bâtiment situé de l’autre côté.</p><p><strong>1520-1525</strong><br>Construction d’une salle échevinale avec une cheminée monumentale.</p><p><strong>1528-1532</strong><br>Construction d’une galerie avec arches.</p><p><strong>17<sup>e</sup> siècle</strong><br>Nouvelle extension avec une chapelle et une chambre des orphelins.</p><p><strong>1722-1727</strong><br>Transformation dans un style classique.</p><p><strong>1794</strong><br>La maison du Franc de Bruges devient un tribunal.</p><p><strong>1984</strong><br>Le bâtiment est utilisé par l’administration de la ville de Bruges.</p>", "Maison du Franc de Bruges" });

            migrationBuilder.InsertData(
                table: "BuildingTranslation",
                columns: new[] { "Id", "BuildingId", "Description", "LanguageId", "Name", "SourceLink" },
                values: new object[,]
                {
                    { 7L, 2L, "<p><strong>11de eeuw</strong><br>bouw van de 'Love', residentie van de graven van Vlaanderen</p><p><strong>15de eeuw</strong>  <br>het bestuur van het Brugse Vrije (het platteland rondom Brugge) verhuist van Het Steen aan de overzijde naar deze locatie</p><p><strong>1520-1525</strong><br>bouw van een schepenkamer met monumentale schouw</p><p><strong>1528-1532</strong><br>bouw van een galerij met rondbogen</p><p><strong>17de eeuw</strong><br>verdere uitbreiding met een kapel en wezenkamer</p><p><strong>1722-1727</strong> <br>verbouwing in classicistische stijl</p><p><strong>1794</strong><br>het landhuis wordt gerechtshof</p><p><strong>1984</strong><br>in gebruik genomen door de stadsadministratie</p>", 2L, "Landhuis", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 8L, 2L, "<p><strong>11th century</strong><br>Love” building, the residence of the counts of Flanders</p><p><strong>15th century</strong><br>the government of the Franc of Bruges (the area of countryside surrounding Bruges) moved from Steen Castle (which was on the opposite side) to this location.</p><p><strong>1520-1525</strong><br>construction of an alderman’s room with monumental fireplace</p><p><strong>1528-1532</strong><br>construction of an arched gallery</p><p><strong>17th century</strong><br>further extensions including a chapel and orphanage</p><p><strong>1722-1727</strong><br>renovations in the classical style</p><p><strong>1794</strong><br>the manor became a court of justice</p><p><strong>1984</strong><br>came into use by the city administration</p>", 3L, "Manor House", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 9L, 2L, "<p><strong>11. Jahrhundert</strong><br>Bau der Residenz „Love“ der Grafen von Flandern.</p><p><strong>15. Jahrhundert</strong><br>Das Brügger Freiamt (die Verwaltung des Brügger Umlands) zieht von „Het Steen“ auf die gegenüberliegende Seite an diesen Ort um.</p><p><strong>1520–1525</strong><br>Bau einer Schöffenkammer mit einem monumentalen Kamin.</p><p><strong>1528–1532</strong><br>Bau einer Galerie mit Rundbogen.</p><p><strong>17. Jahrhundert</strong><br>Zusätzliche Erweiterung mit Kapelle und Waisenkammer.</p><p><strong>1722–1727</strong><br>Umbau im klassizistischen Stil.</p><p><strong>1794</strong><br>Das Landeshaus wird in ein Gericht umfunktioniert.</p><p><strong>1984</strong><br>Die Stadtverwaltung wird im Gebäude untergebracht.</p>", 4L, "Landeshaus", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 10L, 2L, "<p><strong>Siglo XI</strong><br>Construcción del «<em>Love</em>», residencia de los condes de Flandes</p><p><strong>Siglo XV</strong><br>La administración del <em>Brugse Vrije</em> (el campo que rodeaba Brujas) se traslada a esta ubicación desde el <em>Steen</em>, situado al otro lado</p><p><strong>1520-1525</strong><br>Construcción de una sala para el escabinado, con una monumental chimenea</p><p><strong>1528-1532</strong><br>Construcción de una galería con arcos de medio punto</p><p><strong>Siglo XVII</strong><br>Ampliación con una capilla y un juzgado de huérfanos</p><p><strong>1722-1727</strong><br>Reforma en estilo clasicista</p><p><strong>1794</strong><br>El <em>landhuis</em> se convierte en tribunal&nbsp;</p><p><strong>1984</strong><br>Se pone al servicio de la administración municipal</p>", 5L, "Landhuis", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BuildingId", "Description", "Name" },
                values: new object[] { 1L, "<strong>1280</strong><br>Après un incendie dans le Beffroi sur la Grand-Place, les échevins prennent possession de la « ghyselhuus », l’ancienne prison comtale.<br><br><strong>1376</strong><br> Le comte Lodewijk van Male fait démolir la « ghyselhuus » pour la remplacer par une véritable « scepenhuus » imaginée par Jan Roegiers.<br><br><strong>1887</strong><br> Un incendie ravage l’intérieur.<br><br><strong>1895-1905</strong><br>Louis Delacenserie et Jean-Baptiste de Béthune rénovent l’intérieur dans un style néogothique.", "Hôtel de Ville de Bruges" });
        }
    }
}
