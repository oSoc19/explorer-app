using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class StoriesSteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingStory",
                columns: new[] { "Id", "BuildingId", "ImageUrl", "LanguageId", "Subtitle", "Text", "Title", "Type" },
                values: new object[,]
                {
                    { 192L, 6L, "https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Bruges%2C_burg_01.JPG/1280px-Bruges%2C_burg_01.JPG", 1L, " ", "L’emplacement de l’ancien château Steen.", "Steen", "artwork" },
                    { 209L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03a335f7a15c489691b3f3b6f60cbb436d83eb86cd2840ef8910c0544d675340/browse.jpg", 3L, " ", "Steen Castle was demolished at the end of the 18th century.", "Steen", "artwork" },
                    { 208L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03a335f7a15c489691b3f3b6f60cbb436d83eb86cd2840ef8910c0544d675340/browse.jpg", 2L, " ", "Aan het einde van de 18de eeuw werd het Steen gesloopt.", "Steen", "artwork" },
                    { 207L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03a335f7a15c489691b3f3b6f60cbb436d83eb86cd2840ef8910c0544d675340/browse.jpg", 1L, " ", "« Het Steen » a été démoli à la fin du 18e siècle.", "Steen", "artwork" },
                    { 206L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/8237aef04775478dbdc89e459a2da5539ca132c304be43a0b9bc5bbffeeed1ce/browse.jpg", 5L, " ", "A partir del siglo XII el Steen pasó a ser una cárcel.", "Steen", "artwork" },
                    { 205L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/8237aef04775478dbdc89e459a2da5539ca132c304be43a0b9bc5bbffeeed1ce/browse.jpg", 4L, " ", "Ab dem 12. Jahrhundert fungierte das Gebäude als Gefängnis.", "Steen", "artwork" },
                    { 204L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/8237aef04775478dbdc89e459a2da5539ca132c304be43a0b9bc5bbffeeed1ce/browse.jpg", 3L, " ", "From the 12th century, Steen Castle was a prison.", "Steen", "artwork" },
                    { 203L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/8237aef04775478dbdc89e459a2da5539ca132c304be43a0b9bc5bbffeeed1ce/browse.jpg", 2L, " ", "Vanaf de 12de eeuw was het gebouw een gevangenis.", "Steen", "artwork" },
                    { 202L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/8237aef04775478dbdc89e459a2da5539ca132c304be43a0b9bc5bbffeeed1ce/browse.jpg", 1L, " ", "Dès le 12e siècle, le bâtiment est devenu une prison.", "Steen", "artwork" },
                    { 201L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/a8786c07be4e460082f3e2d7de731f318bc3a58aa03042078cec21a5d1f55fc3/browse.jpg", 5L, " ", "El Steen fue probablemente la primera residencia de los condes de Flandes.", "Steen", "artwork" },
                    { 200L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/a8786c07be4e460082f3e2d7de731f318bc3a58aa03042078cec21a5d1f55fc3/browse.jpg", 4L, " ", "„Het Steen“ war wahrscheinlich die erste Residenz der Grafen von Flandern.", "Steen", "artwork" },
                    { 199L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/a8786c07be4e460082f3e2d7de731f318bc3a58aa03042078cec21a5d1f55fc3/browse.jpg", 3L, " ", "Steen Castle was probably the first residence of the Counts of Flanders.", "Steen", "artwork" },
                    { 198L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/a8786c07be4e460082f3e2d7de731f318bc3a58aa03042078cec21a5d1f55fc3/browse.jpg", 2L, " ", "Het Steen was wellicht de eerste residentie van de graven van Vlaanderen.", "Steen", "artwork" },
                    { 197L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/a8786c07be4e460082f3e2d7de731f318bc3a58aa03042078cec21a5d1f55fc3/browse.jpg", 1L, " ", "« Het Steen » était probablement la première résidence des comtes de Flandre.", "Steen", "artwork" },
                    { 196L, 6L, "https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Bruges%2C_burg_01.JPG/1280px-Bruges%2C_burg_01.JPG", 5L, " ", "La ubicación del antigua castillo Steen.", "Steen", "artwork" },
                    { 195L, 6L, "https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Bruges%2C_burg_01.JPG/1280px-Bruges%2C_burg_01.JPG", 4L, " ", "Die Lage des ehemaligen Schlosses Steen.", "Steen", "artwork" },
                    { 194L, 6L, "https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Bruges%2C_burg_01.JPG/1280px-Bruges%2C_burg_01.JPG", 3L, " ", "The location of the former Steen Castle.", "Steen", "artwork" },
                    { 193L, 6L, "https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Bruges%2C_burg_01.JPG/1280px-Bruges%2C_burg_01.JPG", 2L, " ", "De locatie van het voormalige Steen.", "Steen", "artwork" },
                    { 210L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03a335f7a15c489691b3f3b6f60cbb436d83eb86cd2840ef8910c0544d675340/browse.jpg", 4L, " ", "„Het Steen“ wurde Ende des 18. Jahrhunderts abgerissen.", "Steen", "artwork" },
                    { 211L, 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03a335f7a15c489691b3f3b6f60cbb436d83eb86cd2840ef8910c0544d675340/browse.jpg", 5L, " ", "El Steen fue derribado a finales del siglo XVIII.", "Steen", "artwork" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 211L);
        }
    }
}
