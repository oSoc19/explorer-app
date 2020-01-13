using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class KathedraalDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingTranslation",
                columns: new[] { "Id", "BuildingId", "Description", "LanguageId", "Name", "SourceLink" },
                values: new object[,]
                {
                    { 36L, 8L, "<p><strong>944</strong> <br>Le comte Arnulf Ier fait construire ici une chapelle octogonale sur le modèle de la cathédrale d’Aix-la-Chapelle. </p> <p><strong>Du 10<sup>e</sup> au 13<sup>e</sup> siècle</strong> <br>Construction d’une église romane avec un couvent. </p> <p><strong>14<sup>e</sup> siècle</strong> <br>Construction d'une nef centrale et de nefs latérales dans un style gothique. </p> <p><strong>1559</strong> <br>Création du diocèse de Bruges : l’église devient une cathédrale. </p> <p><strong>1799</strong> <br>La cathédrale est vendue et est démolie sous le régime révolutionnaire français. </p> <p><strong>Fin des années 1920</strong> <br>L’hôtel Saint-Georges y ouvre ses portes. </p> <p><strong>1987-1991</strong> <br>Construction de l’hôtel Crowne Plaza. Les fondations de l’église qui datent du 12<sup>e</sup> siècle peuvent être admirées dans les caves de l’hôtel.</p>", 1L, "Cathédrale Sint-Donatien", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 37L, 8L, "<p><strong>944</strong> <br>graaf Arnulf I laat hier een achthoekige kapel bouwen, naar het model van de Dom van Aken </p> <p><strong>10de-13de eeuw</strong> <br>uitbouw van een romaanse kerk met kloosterpand </p> <p><strong>14de eeuw</strong> <br>bouw van een kerkschip en zijbeuken in gotische stijl </p> <p><strong>1559</strong> <br>oprichting van het bisdom Brugge: de kerk wordt een kathedraal </p> <p><strong>1799</strong><strong> <br> </strong>de kathedraal wordt verkocht en afgebroken onder het Franse revolutionaire bewind</p> <p><strong>eind jaren 1920</strong> <br>het Hotel Saint-Georges is hier gevestigd </p> <p><strong>1987-1991</strong> <br>bouw van het Crowne Plaza Hotel, de 12de-eeuwse funderingen van de kerk worden blootgelegd en zijn te bezichtigen in de kelder </p>", 2L, "Sint-Donaaskathedraal", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 38L, 8L, "<p><strong>944</strong> <br>Count Arnulf I orders the construction of an octagonal chapel here, modelled on Aachen Cathedral </p> <p><strong>10th – 13th century</strong> <br>expansion of a Romanesque church with monastery </p> <p><strong>14th century</strong> <br>construction of a nave and aisles in Gothic style </p> <p><strong>1559</strong> <br>founding of the diocese of Bruges – the church becomes a Cathedral </p> <p><strong>1799</strong> <br>the cathedral is sold and demolished under the French revolutionary reign </p> <p><strong>late 1920s</strong> <br>the Hotel Saint-Georges is located here </p> <p><strong>1987-1991</strong> <br>construction of the Crowne Plaza Hotel. The 12th century foundations of the church are exposed and can still be seen in the cellar. </p>", 3L, "Saint Donatian’s Cathedral", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 39L, 8L, "<p><strong>944</strong> <br>Graf Arnulf I. lässt an diesem Ort eine achteckige Kapelle nach dem Entwurf des Aachener Doms bauen. </p> <p><strong>10.–13. Jahrhundert</strong> <br>Ausbau einer romanischen Kirche mit Klostergebäude. </p> <p><strong>14. Jahrhundert</strong> <br>Bau eines Kirchenschiffs und von Seitenschiffen im gotischen Stil. </p> <p><strong>1559</strong> <br>Gründung des Bistums Brügge: Die Kirche wird eine Kathedrale. </p> <p><strong>1799</strong> <br>Die Kathedrale wird verkauft und unter der französischen Revolutionsverwaltung abgerissen. </p> <p><strong>Ende der 1920er Jahre</strong> <br>Das Hotel Saint-Georges wird hier untergebracht. </p> <p><strong>1987–1991</strong> <br>Bau des Crowne Plaza Hotels, die Kirchenfundamente aus dem 12. Jahrhundert werden freigelegt und können im Keller besichtigt werden. </p>", 4L, "Kathedrale Sankt-Donatian", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 40L, 8L, "<p><strong>944</strong> <br>El conde Arnulfo I mandó construir aquí una capilla octogonal, tomando como modelo la catedral de Aquisgrán </p> <p><strong>Siglos X-XIII</strong> <br>Construcción de una iglesia románica con un cenobio </p> <p><strong>Siglo XIV</strong> <br>Construcción de una nave central y de naves laterales de estilo gótico </p> <p><strong>1559</strong> <br>Fundación del obispado de Brujas: la iglesia pasa a ser catedral </p> <p><strong>1799</strong> <br>Se vende la catedral y se derrumba bajo el régimen revolucionario francés </p> <p><strong>Finales de la década de 1920</strong> <br>Se instala aquí el Hotel Saint-Georges </p> <p><strong>1987-1991</strong> <br>Construcción del Crowne Plaza Hotel, se descubren los cimientos del siglo XII de la iglesia y se pueden visitar en el sótano </p>", 5L, "Catedral de San Donaciano", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 40L);
        }
    }
}
