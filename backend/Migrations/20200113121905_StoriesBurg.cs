using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class StoriesBurg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ImageUrl", "Subtitle", "Text", "Title", "Type" },
                values: new object[] { "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c293bb3893004c94b54d41ff03c43e2d6df2b2586c3b44359daac05da0e0eea6/browse.jpg", " ", "La Place du Bourg", "De Burg", "artwork" });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ImageUrl", "Subtitle", "Text", "Title", "Type" },
                values: new object[] { "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c293bb3893004c94b54d41ff03c43e2d6df2b2586c3b44359daac05da0e0eea6/browse.jpg", " ", "De Burg", "De Burg", "artwork" });

            migrationBuilder.InsertData(
                table: "BuildingStory",
                columns: new[] { "Id", "BuildingId", "ImageUrl", "LanguageId", "Subtitle", "Text", "Title", "Type" },
                values: new object[,]
                {
                    { 104L, 1L, "https://nl.m.wikipedia.org/wiki/Bestand:Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg", 3L, " ", "The Burg Square painted by J.-B. van Meunincxhove (1691-1700)", "De Burg", "artwork" },
                    { 103L, 1L, "https://nl.m.wikipedia.org/wiki/Bestand:Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg", 2L, " ", "De Burg geschilderd door J.-B. van Meunincxhove (1691-1700)", "De Burg", "artwork" },
                    { 102L, 1L, "https://nl.m.wikipedia.org/wiki/Bestand:Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg", 1L, " ", "La Place du Bourg peinte par J.-B. van Meunincxhove (1691-1700).", "De Burg", "artwork" },
                    { 101L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3bd01bb012ed4513bf197603e9fd16dc383e91235acc45869cc19a48d5b64633/browse.jpg", 5L, " ", "La Plaza Burg en la Flandria illustrata de Antonius Sanderus (1641).", "De Burg", "artwork" },
                    { 100L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3bd01bb012ed4513bf197603e9fd16dc383e91235acc45869cc19a48d5b64633/browse.jpg", 4L, " ", "Der Burgplatz in der Flandria illustrata des Antonius Sanderus (1641)", "De Burg", "artwork" },
                    { 99L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3bd01bb012ed4513bf197603e9fd16dc383e91235acc45869cc19a48d5b64633/browse.jpg", 3L, " ", "The Burg Square in Antonius Sanderus’s Flandria illustrata (1641).", "De Burg", "artwork" },
                    { 98L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3bd01bb012ed4513bf197603e9fd16dc383e91235acc45869cc19a48d5b64633/browse.jpg", 2L, " ", "De Burg in Antonius Sanderus’ Flandria illustrata (1641).", "De Burg", "artwork" },
                    { 97L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3bd01bb012ed4513bf197603e9fd16dc383e91235acc45869cc19a48d5b64633/browse.jpg", 1L, " ", "La Place du Bourg dans la Flandria illustrata (1641) d’Antoine Sanderus.", "De Burg", "artwork" },
                    { 96L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/9d6c51e780e044759631a07bd9dcbd322af40c753c0549c7a69a6158a0874eb5/browse.jpg", 5L, " ", "El Burg compo fortaleza (Siglo XII).", "De Burg", "artwork" },
                    { 95L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/9d6c51e780e044759631a07bd9dcbd322af40c753c0549c7a69a6158a0874eb5/browse.jpg", 4L, " ", "Die Burg als Festung (12. Jahrhundert)", "De Burg", "artwork" },
                    { 94L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/9d6c51e780e044759631a07bd9dcbd322af40c753c0549c7a69a6158a0874eb5/browse.jpg", 3L, " ", "The Burg as a fortress (12 century).", "De Burg", "artwork" },
                    { 93L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/9d6c51e780e044759631a07bd9dcbd322af40c753c0549c7a69a6158a0874eb5/browse.jpg", 2L, " ", "De Burg als vesting (12de eeuw).", "De Burg", "artwork" },
                    { 92L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/9d6c51e780e044759631a07bd9dcbd322af40c753c0549c7a69a6158a0874eb5/browse.jpg", 1L, " ", "Le Bourg comme forteresse (12e siècle)", "De Burg", "artwork" },
                    { 91L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c316e46152184d4b9c96e5ac62eea6ae9ee2640e6a5e4f579c9e7617e469a7ae/browse.jpg", 5L, " ", "La Plaza Burg en el mapa de Marcus Gerards (1561-1562)", "De Burg", "artwork" },
                    { 90L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c316e46152184d4b9c96e5ac62eea6ae9ee2640e6a5e4f579c9e7617e469a7ae/browse.jpg", 4L, " ", "Der Burgplatz auf der Karte von Marcus Gerards (1561-1562).", "De Burg", "artwork" },
                    { 89L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c316e46152184d4b9c96e5ac62eea6ae9ee2640e6a5e4f579c9e7617e469a7ae/browse.jpg", 3L, " ", "The Burg Square on the map of Marcus Gerards (1561-1562).", "De Burg", "artwork" },
                    { 88L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c316e46152184d4b9c96e5ac62eea6ae9ee2640e6a5e4f579c9e7617e469a7ae/browse.jpg", 2L, " ", "De Burg op de kaart van Marcus Gerards (1561-1562).", "De Burg", "artwork" },
                    { 87L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c316e46152184d4b9c96e5ac62eea6ae9ee2640e6a5e4f579c9e7617e469a7ae/browse.jpg", 1L, " ", "La Place du Bourg sur la Carte de Marcus Gerards (1591-1562).", "De Burg", "artwork" },
                    { 86L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c293bb3893004c94b54d41ff03c43e2d6df2b2586c3b44359daac05da0e0eea6/browse.jpg", 5L, " ", "La Plaza Burg", "De Burg", "artwork" },
                    { 85L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c293bb3893004c94b54d41ff03c43e2d6df2b2586c3b44359daac05da0e0eea6/browse.jpg", 4L, " ", "Der Burgplatz", "De Burg", "artwork" },
                    { 84L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c293bb3893004c94b54d41ff03c43e2d6df2b2586c3b44359daac05da0e0eea6/browse.jpg", 3L, " ", "The Burg Square", "De Burg", "artwork" },
                    { 105L, 1L, "https://nl.m.wikipedia.org/wiki/Bestand:Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg", 4L, " ", "Der Burgplatz gemalt von J.-B. van Meunincxhove (1691-1700).", "De Burg", "artwork" },
                    { 106L, 1L, "https://nl.m.wikipedia.org/wiki/Bestand:Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg", 5L, " ", "La Plaza Burg pintada por J.-B. van Meunincxhove (1691-1700).", "De Burg", "artwork" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "ImageUrl", "Subtitle", "Text", "Title", "Type" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/7/7d/Burg_in_Brugge_-_Belgi%C3%AB.jpg", "about the technique", "Artists started painting on canvas instead of wood because it holds the pigments better", "Stadhuis FR", "style" });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "ImageUrl", "Subtitle", "Text", "Title", "Type" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/7/7d/Burg_in_Brugge_-_Belgi%C3%AB.jpg", "about the technique", "Artists started painting on canvas instead of wood because it holds the pigments better", "Stadhuis NL", "style" });
        }
    }
}
