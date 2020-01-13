using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class StoriesStadhuis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingStory",
                columns: new[] { "Id", "BuildingId", "ImageUrl", "LanguageId", "Subtitle", "Text", "Title", "Type" },
                values: new object[,]
                {
                    { 152L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/02bcd6e29ca84abd8a417433c1de751a886873e2193b496293aee4d8a19f930a/browse.jpg", 1L, " ", "Hôtel de ville.", "Stadhuis", "artwork" },
                    { 169L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/7257ddbac44d49c4a2fecc2edecbeedb075df9bf1b08408fb4ef8eb35b316ef6/browse.jpg", 3L, " ", "The Gothic Room on the top floor war was re-decorated in the neo-Gothic style around 1900.", "Stadhuis", "artwork" },
                    { 168L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/7257ddbac44d49c4a2fecc2edecbeedb075df9bf1b08408fb4ef8eb35b316ef6/browse.jpg", 2L, " ", "De ‘gotische zaal’ op de bovenverdieping werd omstreeks 1900 ingericht in neogotische stijl.", "Stadhuis", "artwork" },
                    { 167L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/7257ddbac44d49c4a2fecc2edecbeedb075df9bf1b08408fb4ef8eb35b316ef6/browse.jpg", 1L, " ", "La ‘salle gothique’ à l’étage supérieur a été aménagée aux alentours de 1900 dans un style néogothique.", "Stadhuis", "artwork" },
                    { 166L, 4L, "http://1.bp.blogspot.com/-4wmQC1henLQ/VDV6icTx1tI/AAAAAAAAAEo/xyvuwxHuWHk/s1600/IMG_7031.jpg ", 5L, " ", "Las coronas doradas de las repisas hacen referencia a una declaración del rey Carlos VII de Francia (1403–1461)", "Stadhuis", "artwork" },
                    { 165L, 4L, "http://1.bp.blogspot.com/-4wmQC1henLQ/VDV6icTx1tI/AAAAAAAAAEo/xyvuwxHuWHk/s1600/IMG_7031.jpg ", 4L, " ", "Die goldenen Kronen auf der Schornsteine verweisen auf ein Urteil von König Karl VII. von Frankreich (1403–1461).", "Stadhuis", "artwork" },
                    { 164L, 4L, "http://1.bp.blogspot.com/-4wmQC1henLQ/VDV6icTx1tI/AAAAAAAAAEo/xyvuwxHuWHk/s1600/IMG_7031.jpg ", 3L, " ", "The golden crowns on the chimneys refer to a statement made by King Charles VII of France (1403-1461).", "Stadhuis", "artwork" },
                    { 163L, 4L, "http://1.bp.blogspot.com/-4wmQC1henLQ/VDV6icTx1tI/AAAAAAAAAEo/xyvuwxHuWHk/s1600/IMG_7031.jpg ", 2L, " ", "De gouden kroontjes op de schouwen verwijzen naar een uitspraak van koning Karel VII van Frankrijk (1403–1461).", "Stadhuis", "artwork" },
                    { 162L, 4L, "http://1.bp.blogspot.com/-4wmQC1henLQ/VDV6icTx1tI/AAAAAAAAAEo/xyvuwxHuWHk/s1600/IMG_7031.jpg ", 1L, " ", "Les couronnes dorées sur les cheminées font référence à des propos tenus par le roi Charles VII de France (1403–1461).", "Stadhuis", "artwork" },
                    { 161L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03a335f7a15c489691b3f3b6f60cbb436d83eb86cd2840ef8910c0544d675340/browse.jpg", 5L, " ", "El ayuntamiento de Brujas es uno de los más antiguos de los viejes Países Bajos.", "Stadhuis", "artwork" },
                    { 160L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03a335f7a15c489691b3f3b6f60cbb436d83eb86cd2840ef8910c0544d675340/browse.jpg", 4L, " ", "Das Brügger Rathaus ist eines der ältesten in den Niederlanden.", "Stadhuis", "artwork" },
                    { 159L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03a335f7a15c489691b3f3b6f60cbb436d83eb86cd2840ef8910c0544d675340/browse.jpg", 3L, " ", "The Bruges city hall is one of the oldest city halls in the low countries.", "Stadhuis", "artwork" },
                    { 158L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03a335f7a15c489691b3f3b6f60cbb436d83eb86cd2840ef8910c0544d675340/browse.jpg", 2L, " ", "Het Brugse stadhuis is een van de oudste in de Nederlanden.", "Stadhuis", "artwork" },
                    { 157L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03a335f7a15c489691b3f3b6f60cbb436d83eb86cd2840ef8910c0544d675340/browse.jpg", 1L, " ", "L’hôtel de ville de Bruges est l’un des plus anciens des Pays-Bas.", "Stadhuis", "artwork" },
                    { 156L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/02bcd6e29ca84abd8a417433c1de751a886873e2193b496293aee4d8a19f930a/browse.jpg", 5L, " ", "Ayuntamiento.", "Stadhuis", "artwork" },
                    { 155L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/02bcd6e29ca84abd8a417433c1de751a886873e2193b496293aee4d8a19f930a/browse.jpg", 4L, " ", "Rathaus.", "Stadhuis", "artwork" },
                    { 154L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/02bcd6e29ca84abd8a417433c1de751a886873e2193b496293aee4d8a19f930a/browse.jpg", 3L, " ", "City Hall.", "Stadhuis", "artwork" },
                    { 153L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/02bcd6e29ca84abd8a417433c1de751a886873e2193b496293aee4d8a19f930a/browse.jpg", 2L, " ", "Stadhuis.", "Stadhuis", "artwork" },
                    { 170L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/7257ddbac44d49c4a2fecc2edecbeedb075df9bf1b08408fb4ef8eb35b316ef6/browse.jpg", 4L, " ", "Der „gotische Saal“ im Obergeschoss wurde ca. 1900 im neugotischen Stil eingerichtet.", "Stadhuis", "artwork" },
                    { 171L, 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/7257ddbac44d49c4a2fecc2edecbeedb075df9bf1b08408fb4ef8eb35b316ef6/browse.jpg", 5L, " ", "La «sala gótica» de la planta superior se habilitó hacia el año 1900 en estilo neogótico.", "Stadhuis", "artwork" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 171L);
        }
    }
}
