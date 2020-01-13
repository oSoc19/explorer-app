using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class StoriesProosdij : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingStory",
                columns: new[] { "Id", "BuildingId", "ImageUrl", "LanguageId", "Subtitle", "Text", "Title", "Type" },
                values: new object[,]
                {
                    { 212L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dd4755c106634a4595587d90ee418325eae83fad51724c90a025df548e94de58/browse.jpg", 1L, " ", "Prévôté de Saint-Donatien.", "Proosdij", "artwork" },
                    { 229L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/22b55579708844c4adc22576333be9ed76cb453f25a04726b9d36ff6d0d2cc99/browse.jpg", 3L, " ", "There are images of Lady Justice and the Greek gods of truth, charity and justice on the facade.", "Proosdij", "artwork" },
                    { 228L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/22b55579708844c4adc22576333be9ed76cb453f25a04726b9d36ff6d0d2cc99/browse.jpg", 2L, " ", "Op de gevel zijn beelden van Vrouwe Justitia en de Griekse goden waarheid, liefdadigheid en gerechtigheid aangebracht.", "Proosdij", "artwork" },
                    { 227L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/22b55579708844c4adc22576333be9ed76cb453f25a04726b9d36ff6d0d2cc99/browse.jpg", 1L, " ", "La façade est ornée de statues de Dame Justice ainsi que des dieux grecs de la vérité, de la charité et de la justice.", "Proosdij", "artwork" },
                    { 226L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/22b55579708844c4adc22576333be9ed76cb453f25a04726b9d36ff6d0d2cc99/browse.jpg", 5L, " ", "En la actualidad forma parte de la residencia oficial del gobernador de Flandes Occidental.", "Proosdij", "artwork" },
                    { 225L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/22b55579708844c4adc22576333be9ed76cb453f25a04726b9d36ff6d0d2cc99/browse.jpg", 4L, " ", "Gegenwärtig gehört die Propstei zur Amtswohnung des Gouverneurs der Provinz Westflandern.", "Proosdij", "artwork" },
                    { 224L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/22b55579708844c4adc22576333be9ed76cb453f25a04726b9d36ff6d0d2cc99/browse.jpg", 3L, " ", "Nowadays, it is part of the official residence of the Governor of West Flanders.", "Proosdij", "artwork" },
                    { 223L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/22b55579708844c4adc22576333be9ed76cb453f25a04726b9d36ff6d0d2cc99/browse.jpg", 2L, " ", "Vandaag maakt het deel uit van de ambtswoning van de gouverneur van West-Vlaanderen.", "Proosdij", "artwork" },
                    { 222L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/22b55579708844c4adc22576333be9ed76cb453f25a04726b9d36ff6d0d2cc99/browse.jpg", 1L, " ", "La prévôté fait aujourd’hui partie de la résidence officielle du gouverneur de la province de Flandre occidentale.", "Proosdij", "artwork" },
                    { 221L, 7L, "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg/1280px-Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg", 5L, " ", "Se trata de un ejemplo exclusivo del barroco triunfalista en Brujas.", "Proosdij", "artwork" },
                    { 220L, 7L, "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg/1280px-Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg", 4L, " ", "Dieses Musterbeispiel des triumphalistischen Barocks ist einzigartig in Brügge.", "Proosdij", "artwork" },
                    { 219L, 7L, "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg/1280px-Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg", 3L, " ", "This example of triumphal Baroque architecture is unique in Bruges.", "Proosdij", "artwork" },
                    { 218L, 7L, "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg/1280px-Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg", 2L, " ", "Dit voorbeeld van triomfalistische barokarchitectuur is uniek in Brugge.", "Proosdij", "artwork" },
                    { 217L, 7L, "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg/1280px-Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg", 1L, " ", "Cet exemple de baroque triomphaliste est unique à Bruges.", "Proosdij", "artwork" },
                    { 216L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dd4755c106634a4595587d90ee418325eae83fad51724c90a025df548e94de58/browse.jpg", 5L, " ", "Prebostazgo de San Donaciano.", "Proosdij", "artwork" },
                    { 215L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dd4755c106634a4595587d90ee418325eae83fad51724c90a025df548e94de58/browse.jpg", 4L, " ", "Propstei Sankt-Donatus.", "Proosdij", "artwork" },
                    { 214L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dd4755c106634a4595587d90ee418325eae83fad51724c90a025df548e94de58/browse.jpg", 3L, " ", "Provostry of Saint Donatian.", "Proosdij", "artwork" },
                    { 213L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dd4755c106634a4595587d90ee418325eae83fad51724c90a025df548e94de58/browse.jpg", 2L, " ", "De Sint-Donaasproosdij.", "Proosdij", "artwork" },
                    { 230L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/22b55579708844c4adc22576333be9ed76cb453f25a04726b9d36ff6d0d2cc99/browse.jpg", 4L, " ", "An der Fassade befinden sich Figuren von Justitia und der griechischen Götter der Wahrheit, Wohltätigkeit und Gerechtigkeit.", "Proosdij", "artwork" },
                    { 231L, 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/22b55579708844c4adc22576333be9ed76cb453f25a04726b9d36ff6d0d2cc99/browse.jpg", 5L, " ", "En la fachada se han instalado estatuas de la Dama de la Justicia y de las diosas griegas de la verdad, la caridad y la justicia.", "Proosdij", "artwork" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 231L);
        }
    }
}
