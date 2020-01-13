using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class StoriesKathedraal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingStory",
                columns: new[] { "Id", "BuildingId", "ImageUrl", "LanguageId", "Subtitle", "Text", "Title", "Type" },
                values: new object[,]
                {
                    { 232L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/176de22472d54fb8acd043861293cd259b3a5772fb4142afae1454575f03b66d/browse.jpg", 1L, " ", "L’emplacement de l’ancienne cathédrale Saint-Donatien.", "Kathedraal", "artwork" },
                    { 254L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/64b1e13a417140b9ac1896e74f75b1bc2c07d91365ec4f5fbd0d8eb34ea7466c/browse.jpg", 3L, " ", "The foundations of the cathedral can still be seen in the cellars of the Crowne Plaza Hotel.", "Kathedraal", "artwork" },
                    { 253L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/64b1e13a417140b9ac1896e74f75b1bc2c07d91365ec4f5fbd0d8eb34ea7466c/browse.jpg", 2L, " ", "In de kelders van het Crowne Plaza Hotel zijn de funderingen van de kathedraal te bezichtigen.", "Kathedraal", "artwork" },
                    { 252L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/64b1e13a417140b9ac1896e74f75b1bc2c07d91365ec4f5fbd0d8eb34ea7466c/browse.jpg", 1L, " ", "Les fondations de la cathédrale peuvent être admirées dans les caves de l’hôtel Crowne Plaza.", "Kathedraal", "artwork" },
                    { 251L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/cf0cfcd74972433dbb34464a37a6f3b0a901b088721c4e20b92a0e12a8cdf49c/browse.jpg", 5L, " ", "La catedral fue derruida bajo el régimen francés a finales del siglo XVIII.", "Kathedraal", "artwork" },
                    { 250L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/cf0cfcd74972433dbb34464a37a6f3b0a901b088721c4e20b92a0e12a8cdf49c/browse.jpg", 4L, " ", "Die Kathedrale wurde Ende des 18. Jahrhundert unter der französischen Verwaltung abgerissen.", "Kathedraal", "artwork" },
                    { 249L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/cf0cfcd74972433dbb34464a37a6f3b0a901b088721c4e20b92a0e12a8cdf49c/browse.jpg", 3L, " ", "The cathedral was demolished under the French regime at the end of the 18th century.", "Kathedraal", "artwork" },
                    { 248L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/cf0cfcd74972433dbb34464a37a6f3b0a901b088721c4e20b92a0e12a8cdf49c/browse.jpg", 2L, " ", "De kathedraal werd afgebroken onder het Franse regime eind 18de eeuw.", "Kathedraal", "artwork" },
                    { 247L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/cf0cfcd74972433dbb34464a37a6f3b0a901b088721c4e20b92a0e12a8cdf49c/browse.jpg", 1L, " ", "La cathédrale a été démolie sous le régime français à la fin du 18e siècle.", "Kathedraal", "artwork" },
                    { 246L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dfabe3a6e47c4617955509bf3008cdc6d5b7dd1e57124d44933d919440675b1a/browse.jpg", 5L, " ", "En el año 1127 el conde Carlos el Bueno de Flandes fue asesinado en la iglesia.", "Kathedraal", "artwork" },
                    { 245L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dfabe3a6e47c4617955509bf3008cdc6d5b7dd1e57124d44933d919440675b1a/browse.jpg", 4L, " ", "Im Jahre 1127 wurde Graf Karl der Gute von Flandern in der Kirche ermordet.", "Kathedraal", "artwork" },
                    { 255L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/64b1e13a417140b9ac1896e74f75b1bc2c07d91365ec4f5fbd0d8eb34ea7466c/browse.jpg", 4L, " ", "In den Kellerräumen des Crowne Plaza Hotels können die Fundamente der Kathedrale auch heute noch besichtigt werden.", "Kathedraal", "artwork" },
                    { 244L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dfabe3a6e47c4617955509bf3008cdc6d5b7dd1e57124d44933d919440675b1a/browse.jpg", 3L, " ", "Count Charles the Good of Flanders was murdered in the church in 1127.", "Kathedraal", "artwork" },
                    { 242L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dfabe3a6e47c4617955509bf3008cdc6d5b7dd1e57124d44933d919440675b1a/browse.jpg", 1L, " ", "En 1127, le comte Charles le Bon de Flandre fut assassiné dans l’église.", "Kathedraal", "artwork" },
                    { 241L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c316e46152184d4b9c96e5ac62eea6ae9ee2640e6a5e4f579c9e7617e469a7ae/browse.jpg", 5L, " ", "La catedral en el mapa de Marcus Gerards (1561-1562)", "Kathedraal", "artwork" },
                    { 240L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c316e46152184d4b9c96e5ac62eea6ae9ee2640e6a5e4f579c9e7617e469a7ae/browse.jpg", 4L, " ", "Die Kathedrale auf der Karte von Marcus Gerards (1561-1562).", "Kathedraal", "artwork" },
                    { 239L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c316e46152184d4b9c96e5ac62eea6ae9ee2640e6a5e4f579c9e7617e469a7ae/browse.jpg", 3L, " ", "The cathedral on the map of Marcus Gerards (1561-1562).", "Kathedraal", "artwork" },
                    { 238L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c316e46152184d4b9c96e5ac62eea6ae9ee2640e6a5e4f579c9e7617e469a7ae/browse.jpg", 2L, " ", "De kathedraal op de kaart van Marcus Gerards (1561-1562).", "Kathedraal", "artwork" },
                    { 237L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c316e46152184d4b9c96e5ac62eea6ae9ee2640e6a5e4f579c9e7617e469a7ae/browse.jpg", 1L, " ", "La cathédrale sur la Carte de Marcus Gerards (1591-1562).", "Kathedraal", "artwork" },
                    { 236L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/176de22472d54fb8acd043861293cd259b3a5772fb4142afae1454575f03b66d/browse.jpg", 5L, " ", "La ubicación del antigua catedral de San Donaciano.", "Kathedraal", "artwork" },
                    { 235L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/176de22472d54fb8acd043861293cd259b3a5772fb4142afae1454575f03b66d/browse.jpg", 4L, " ", "Die Lage der ehemaligen Kathedrale Sankt Donatian.", "Kathedraal", "artwork" },
                    { 234L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/176de22472d54fb8acd043861293cd259b3a5772fb4142afae1454575f03b66d/browse.jpg", 3L, " ", "The location of the former Saint Donatian’s cathedral.", "Kathedraal", "artwork" },
                    { 233L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/176de22472d54fb8acd043861293cd259b3a5772fb4142afae1454575f03b66d/browse.jpg", 2L, " ", "De locatie van de voormalige Sint-Donaaskathedraal.", "Kathedraal", "artwork" },
                    { 243L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dfabe3a6e47c4617955509bf3008cdc6d5b7dd1e57124d44933d919440675b1a/browse.jpg", 2L, " ", "In 1127 werd in de kerk graaf Karel de Goede van Vlaanderen vermoord.", "Kathedraal", "artwork" },
                    { 256L, 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/64b1e13a417140b9ac1896e74f75b1bc2c07d91365ec4f5fbd0d8eb34ea7466c/browse.jpg", 5L, " ", "En los sótanos del Crowne Plaza Hotel pueden visitarse los cimientos de la catedral.", "Kathedraal", "artwork" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 256L);
        }
    }
}
