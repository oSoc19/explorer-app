using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class aanpassingenStoriesFR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.InsertData(
                table: "PaintingStory",
                columns: new[] { "Id", "ImageUrl", "LanguageId", "PaintingId", "Subtitle", "Text", "Title", "Type" },
                values: new object[] { 74L, "", 1L, 9L, "à propos du mouvement", "Typique d'une peinture baroque, le moment le plus dramatique d'un événement est représenté.", "Baroque", "style" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.InsertData(
                table: "PaintingStory",
                columns: new[] { "Id", "ImageUrl", "LanguageId", "PaintingId", "Subtitle", "Text", "Title", "Type" },
                values: new object[,]
                {
                    { 23L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ad098f654134125a19bb3c8b8163bfe5361b523e12f46009f305c05eab9eb3d/browse.jpg", 2L, 3L, "over de stijlperiode", "Barokkunst werd vaak gemaakt als religieuze propaganda.", "Barok", "style" },
                    { 26L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ad098f654134125a19bb3c8b8163bfe5361b523e12f46009f305c05eab9eb3d/browse.jpg", 3L, 3L, "about the movement", "Baroque art was made for religious propaganda", "Baroque", "style" },
                    { 20L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ad098f654134125a19bb3c8b8163bfe5361b523e12f46009f305c05eab9eb3d/browse.jpg", 1L, 3L, "à propos du mouvement", "L’art baroque servait à la propagande religieuse", "Baroque", "style" },
                    { 41L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/04ca66af841a4449a7dfe6b83c74d92593135c754d6a4f37b68c9914f7829cb8/browse.jpg", 2L, 5L, "over de stijlperiode", "Het schilderen van religieuze scènes werd gebruikt om de ongeletterde bevolking het verhaal te doen begrijpen.", "Barok", "style" },
                    { 44L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/04ca66af841a4449a7dfe6b83c74d92593135c754d6a4f37b68c9914f7829cb8/browse.jpg", 3L, 5L, "about the movement", "Painting of religious scenes was used for religious instruction for the illiterate population", "Baroque", "style" },
                    { 38L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/04ca66af841a4449a7dfe6b83c74d92593135c754d6a4f37b68c9914f7829cb8/browse.jpg", 1L, 5L, "à propos du mouvement", "La peinture de scènes religieuses servait à enseigner la religion à la population analphabète", "Baroque", "style" }
                });
        }
    }
}
