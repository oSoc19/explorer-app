using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class EngelseAanpassingenBurg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Description", "SourceLink" },
                values: new object[] { "Hendrik Pickery (1828–1894) was a sculptor from Bruges. He was a student of the sculptor Eugène Simonis (1810–1882), who was from Liège. The statues on the steps and the facade of the Provinciaal Hof (Markt) and the statue of Hans Memling (Woensdagmarkt) are also Pickery’s work.", "https://rkd.nl/en/explore/artists/63327" });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 94L,
                column: "Text",
                value: "The Burg as a fortress (12th century).");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 119L,
                column: "Text",
                value: "The aldermen’s room in the manor (Gillis van Tillborgh, 1658).");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 159L,
                column: "Text",
                value: "The Bruges city hall is one of the oldest city halls in the Low Countries.");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Description",
                value: "<p>Burg Square is one of the oldest parts of the city centre. It is a former fortress and was originally walled and had entrance gates.</p><p>The fortress was located at the meeting-point of the Oudenburg-Aardenburg road and the Reie canal.</p><p>Count Arnulf I van Vlaanderen (889-965) extended the fortress, transforming it into a powerful religious and administrative centre. The Count’s Residence, the City Council, Saint Donatian’s Church and later the Basilica of the Holy Blood were also located within the fortress walls.</p><p>Saint Donatian’s Cathedral was demolished in 1799. It was never re-built, meaning that the square doubled to twice its previous size.</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Description",
                value: "<p><strong>11th century</strong><br>'Love' building, the residence of the counts of Flanders</p><p><strong>15th century</strong><br>the government of the Franc of Bruges (the area of countryside surrounding Bruges) moved from Steen Castle (which was on the opposite side) to this location.</p><p><strong>1520-1525</strong><br>construction of an alderman’s room with monumental fireplace</p><p><strong>1528-1532</strong><br>construction of an arched gallery</p><p><strong>17th century</strong><br>further extensions including a chapel and orphanage</p><p><strong>1722-1727</strong><br>renovations in the classical style</p><p><strong>1794</strong><br>the manor became a court of justice</p><p><strong>1984</strong><br>came into use by the city administration</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Description",
                value: "<p><strong>1280</strong><br>following a fire in the Belfry on the Markt, the aldermen are moved to the ‘Ghyselhuus’, the old Count’s prison</p><p><strong>1376</strong><br>Count Louis of Male orders the demolition of the ‘Ghyselhuus’, to be replaced by a proper City hall designed by Jan Roegiers</p><p><strong>1887</strong><br>the interior is damaged by a fire</p><p><strong>1895-1905</strong><br>the interior is renovated in the neo-Gothic style by Louis Delacenserie and Jean-Baptiste de Béthune</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 33L,
                column: "Description",
                value: "<p>The provostry (1666) is the former seat of the ecclesiastical seigniory of Saint Donatian.</p> <p>The triumphal baroque style building was designed by architect Cornelis Verhouve and canon Frederic Hillewerve, who both came from Antwerp. The Antwerp influence can clearly be seen in the building.</p> <p>Today, the provostry is part of the official residence of the Governor of the province of West Flanders.&nbsp;</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 38L,
                column: "Description",
                value: "<p><strong>944</strong> <br>Count Arnulf I orders the construction of an octagonal chapel here, modelled on Aachen Cathedral </p> <p><strong>10th – 13th century</strong> <br>expansion of a Romanesque church with monastery </p> <p><strong>14th century</strong> <br>construction of a nave and aisles in Gothic style </p> <p><strong>1559</strong> <br>founding of the diocese of Bruges – the church becomes a cathedral </p> <p><strong>1799</strong> <br>the cathedral is sold and demolished under the French revolutionary reign </p> <p><strong>late 1920s</strong> <br>the Hotel Saint-Georges is located here </p> <p><strong>1987-1991</strong> <br>construction of the Crowne Plaza Hotel. The 12th century foundations of the church are exposed and can still be seen in the cellar. </p>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "Description", "SourceLink" },
                values: new object[] { "Hendrik Pickery (1828–1894) was a sculptor from Bruges. He was a student of the sculptor Eugène Simonis (1810–1882), who was from Liège. The statues on the steps of the gable of the Provinciaal Hof (Markt) and the statue of Hans Memling (Woensdagmarkt) are also Pickery’s work.", "https://rkd.nl/en/explore/artists/63328" });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 94L,
                column: "Text",
                value: "The Burg as a fortress (12 century).");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 119L,
                column: "Text",
                value: "The alderman’s room in the manor (Gillis van Tillborgh, 1658).");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 159L,
                column: "Text",
                value: "The Bruges city hall is one of the oldest city halls in the low countries.");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Description",
                value: "<p>Burg Square is one of the oldest parts of the city centre. It is a former fortress and was originally walled in and had entrance gates.</p><p>The fortress was located at the meeting-point of the Oudenburg-Aardenburg road and the Reie canal.</p><p>Count Arnulf I van Vlaanderen (889-965) extended the fortress, transforming it into a powerful religious and administrative centre. The Count’s Residence, the City Council, Saint Donatian’s Church and later the Basilica of the Holy Blood were also located within the fortress walls.</p><p>Saint Donatian’s Cathedral was demolished in 1799. It was never re-built, meaning that the square doubled to twice its previous size.</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Description",
                value: "<p><strong>11th century</strong><br>Love” building, the residence of the counts of Flanders</p><p><strong>15th century</strong><br>the government of the Franc of Bruges (the area of countryside surrounding Bruges) moved from Steen Castle (which was on the opposite side) to this location.</p><p><strong>1520-1525</strong><br>construction of an alderman’s room with monumental fireplace</p><p><strong>1528-1532</strong><br>construction of an arched gallery</p><p><strong>17th century</strong><br>further extensions including a chapel and orphanage</p><p><strong>1722-1727</strong><br>renovations in the classical style</p><p><strong>1794</strong><br>the manor became a court of justice</p><p><strong>1984</strong><br>came into use by the city administration</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Description",
                value: "<p><strong>1280</strong><br>following a fire in the Belfry on the Markt, the aldermen are moved to the ‘Ghyselhuus’, the old Count’s prison</p><p><strong>1376</strong><br>Count Lodewijk van Male orders the demolition of the ‘Ghyselhuus’, to be replaced by a proper City hall designed by Jan Roegiers</p><p><strong>1887</strong><br>the interior is damaged by a fire</p><p><strong>1895-1905</strong><br>the interior is renovated in the neo-Gothic style by Louis Delacenserie and Jean-Baptiste de Béthune</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 33L,
                column: "Description",
                value: "<p>The provostry is the former seat of the ecclesiastical glory of Saint Donatian.</p> <p>The triumphal baroque style building was designed by architect Cornelis Verhouve and canon Frederic Hillewerve, who both came from Antwerp. The Antwerp influence can clearly be seen in the building.</p> <p>Today, the provostry is part of the official residence of the Governor of the province of West Flanders.&nbsp;</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 38L,
                column: "Description",
                value: "<p><strong>944</strong> <br>Count Arnulf I orders the construction of an octagonal chapel here, modelled on Aachen Cathedral </p> <p><strong>10th – 13th century</strong> <br>expansion of a Romanesque church with monastery </p> <p><strong>14th century</strong> <br>construction of a nave and aisles in Gothic style </p> <p><strong>1559</strong> <br>founding of the diocese of Bruges – the church becomes a Cathedral </p> <p><strong>1799</strong> <br>the cathedral is sold and demolished under the French revolutionary reign </p> <p><strong>late 1920s</strong> <br>the Hotel Saint-Georges is located here </p> <p><strong>1987-1991</strong> <br>construction of the Crowne Plaza Hotel. The 12th century foundations of the church are exposed and can still be seen in the cellar. </p>");
        }
    }
}
