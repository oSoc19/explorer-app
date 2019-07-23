using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class new_stories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PaintingStory",
                columns: new[] { "Id", "ImageUrl", "LanguageId", "PaintingId", "Subtitle", "Text", "Title" },
                values: new object[] { 82L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg", 1L, 7L, "à propos de l'oeuvre", "Achille eut une liaison secrète avec Deidamia, une des 7 filles du Roi Lycomède. Celle-ci a l’air triste car elle sait que Achille est sur le point de partir", "Achille parmi les filles de Lycomède" });

            migrationBuilder.InsertData(
                table: "PaintingStory",
                columns: new[] { "Id", "ImageUrl", "LanguageId", "PaintingId", "Subtitle", "Text", "Title" },
                values: new object[] { 83L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg", 2L, 7L, "over het kunstwerk", "Achilles had een geheime relatie met een van de 7 dochters van koning Lycomede’s: namelijk Deidamia. Ze kijkt triest omdat ze weet dat Achilles haar zal verlaten", "Achilles en de dochters van Lycomedes" });

            migrationBuilder.InsertData(
                table: "PaintingStory",
                columns: new[] { "Id", "ImageUrl", "LanguageId", "PaintingId", "Subtitle", "Text", "Title" },
                values: new object[] { 84L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg", 3L, 7L, "about the artwork", "Achilles had a secret relationship with one of King Lycomedes’s 7 daughters: Deidamia. That is why she looks sad because she knows that  Achilles is going to leave", "Achilles among the Daughters of Lycomedes" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 84L);
        }
    }
}
