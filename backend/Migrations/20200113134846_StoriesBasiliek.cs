using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class StoriesBasiliek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingStory",
                columns: new[] { "Id", "BuildingId", "ImageUrl", "LanguageId", "Subtitle", "Text", "Title", "Type" },
                values: new object[,]
                {
                    { 172L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5cd374fbf4044e78a86e2b5239dd691d923ec92b18dc432883018f0d5e004a73/browse.jpg", 1L, " ", "Basilique du Saint-Sang.", "Basiliek", "artwork" },
                    { 189L, 5L, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Sint-Basiliuskapel_%282%29.jpg/1280px-Sint-Basiliuskapel_%282%29.jpg", 3L, " ", "The Saint Basil Chapel is the only fully preserved Romanesque church in West Flanders.", "Basiliek", "style" },
                    { 188L, 5L, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Sint-Basiliuskapel_%282%29.jpg/1280px-Sint-Basiliuskapel_%282%29.jpg", 2L, " ", "De Sint-Basiliuskapel is de enige volledig bewaarde romaanse kerk in de provincie West-Vlaanderen.", "Basiliek", "style" },
                    { 187L, 5L, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Sint-Basiliuskapel_%282%29.jpg/1280px-Sint-Basiliuskapel_%282%29.jpg", 1L, " ", "La chapelle Saint-Basile est la seule église romane entièrement conservée dans la province de Flandre occidentale.", "Basiliek", "style" },
                    { 186L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/79f6ec0210534015b51ac478d0b1358e1762118fbe294a0d906baffbe46d1b14/browse.jpg", 5L, " ", "Cuenta la leyenda que el conde Diederik van de Elzas trajo la reliquia de la Santa Sangre desde la Tierra Santa en el siglo XIII.", "Basiliek", "artwork" },
                    { 185L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/79f6ec0210534015b51ac478d0b1358e1762118fbe294a0d906baffbe46d1b14/browse.jpg", 4L, " ", "Graf Dietrich von Elsass soll diese Reliquie im 13. Jahrhundert aus dem Heiligen Land mitgebracht haben.", "Basiliek", "artwork" },
                    { 184L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/79f6ec0210534015b51ac478d0b1358e1762118fbe294a0d906baffbe46d1b14/browse.jpg", 3L, " ", "Count Thierry of Alsace is said to have brought the relic of the Holy Blood back from the Holy Land in the 13th century.", "Basiliek", "artwork" },
                    { 183L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/79f6ec0210534015b51ac478d0b1358e1762118fbe294a0d906baffbe46d1b14/browse.jpg", 2L, " ", "Graaf Diederik van de Elzas zou de relikwie van het Heilig Bloed in de 13de eeuw uit het Heilig Land hebben meegebracht.", "Basiliek", "artwork" },
                    { 182L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/79f6ec0210534015b51ac478d0b1358e1762118fbe294a0d906baffbe46d1b14/browse.jpg", 1L, " ", "Le comte Thierry d'Alsace aurait rapporté la relique du Saint-Sang de Terre Sainte au 13e siècle.", "Basiliek", "artwork" },
                    { 181L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c2f23b47d46d4f58be719efdb995d3a64e86296d24764d4e8da44811a17a0ab4/browse.jpg", 5L, " ", "En la basílica se conserva la reliquia de la Santa Sangre, que cada año se exhibe en procesión por la ciudad el día de la Ascensión.", "Basiliek", "artwork" },
                    { 180L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c2f23b47d46d4f58be719efdb995d3a64e86296d24764d4e8da44811a17a0ab4/browse.jpg", 4L, " ", "In der Basilika wird die Reliquie des Heiligen Blutes aufbewahrt, die jedes Jahr am Himmelfahrtstag in der Stadt herumgetragen wird.", "Basiliek", "artwork" },
                    { 179L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c2f23b47d46d4f58be719efdb995d3a64e86296d24764d4e8da44811a17a0ab4/browse.jpg", 3L, " ", "The relic of the Holy Blood – which is carried around the city every year on Ascension Day – is kept in the Basilica.", "Basiliek", "artwork" },
                    { 178L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c2f23b47d46d4f58be719efdb995d3a64e86296d24764d4e8da44811a17a0ab4/browse.jpg", 2L, " ", "In de basiliek wordt het relikwie van het Heilig Bloed bewaard, die elk jaar op Hemelvaart wordt rondgedragen in de stad.", "Basiliek", "artwork" },
                    { 177L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c2f23b47d46d4f58be719efdb995d3a64e86296d24764d4e8da44811a17a0ab4/browse.jpg", 1L, " ", "La basilique abrite la relique du Saint-Sang qui est transportée chaque année partout dans la ville le jour de l’Ascension.", "Basiliek", "artwork" },
                    { 176L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5cd374fbf4044e78a86e2b5239dd691d923ec92b18dc432883018f0d5e004a73/browse.jpg", 5L, " ", "Basílica de la Santa Sangre.", "Basiliek", "artwork" },
                    { 175L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5cd374fbf4044e78a86e2b5239dd691d923ec92b18dc432883018f0d5e004a73/browse.jpg", 4L, " ", "Heilig-Blut-Basilika.", "Basiliek", "artwork" },
                    { 174L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5cd374fbf4044e78a86e2b5239dd691d923ec92b18dc432883018f0d5e004a73/browse.jpg", 3L, " ", "Basilica of the Holy Blood.", "Basiliek", "artwork" },
                    { 173L, 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5cd374fbf4044e78a86e2b5239dd691d923ec92b18dc432883018f0d5e004a73/browse.jpg", 2L, " ", "De Heilig-Bloedbasiliek.", "Basiliek", "artwork" },
                    { 190L, 5L, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Sint-Basiliuskapel_%282%29.jpg/1280px-Sint-Basiliuskapel_%282%29.jpg", 4L, " ", "Die Sankt Basiliuskapelle ist die einzige vollständig erhalten gebliebene romanische Kirche in der Provinz Westflandern.", "Basiliek", "style" },
                    { 191L, 5L, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Sint-Basiliuskapel_%282%29.jpg/1280px-Sint-Basiliuskapel_%282%29.jpg", 5L, " ", "La capilla de San Basilio es la única iglesia romana de la provincia de Flandes Occidental que se conserva intacta. ", "Basiliek", "style" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 191L);
        }
    }
}
