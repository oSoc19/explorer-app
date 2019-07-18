using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class storysubtitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "PaintingStory",
                nullable: true);

            migrationBuilder.InsertData(
                table: "PaintingStory",
                columns: new[] { "Id", "ImageUrl", "LanguageId", "PaintingId", "Subtitle", "Text", "Title" },
                values: new object[,]
                {
                    { 1L, "/api/images/painting-stories/1_ART@2x-100.jpg", 1L, 1L, null, "Les feuilles sur les arbres ne sont en fait pas peintes une à une mais à coups de pinceaux", "À propos de l'oeuvre" },
                    { 25L, "/api/images/painting-stories/3_ART@2x-100.jpg", 3L, 3L, null, "The date on the painting is 1668 and according to the inscription on it, the theologue is 47 years old. The identity of the man is still unknown to this day", "About the artwork" },
                    { 24L, "/api/images/painting-stories/3_TECH@2x-100.jpg", 2L, 3L, null, "Witte verf werd gemaakt uit lood. Het droogde snel en bedekte goed", "Olieverf" },
                    { 23L, "/api/images/painting-stories/3_MOV@2x-100.jpg", 2L, 3L, null, "Barok kunst werd gemaakt als religieuze propaganda", "Barok" },
                    { 22L, "/api/images/painting-stories/3_ART@2x-100.jpg", 2L, 3L, null, "Het schilderij dateert uit 1668. Volgens het opschrift is de theoloog 47 jaar oud. Zijn identiteit is tot op de dag van vandaag nog steeds onbekend", "Over het kunstwerk" },
                    { 21L, "/api/images/painting-stories/3_TECH@2x-100.jpg", 1L, 3L, null, "La peinture blanche était créée avec du plomb.  Elle séchait vite et couvrait bien", "Peinture à l’huile" },
                    { 20L, "/api/images/painting-stories/3_MOV@2x-100.jpg", 1L, 3L, null, "L’art baroque servait à la propagande religieuse", "Baroque" },
                    { 19L, "/api/images/painting-stories/3_ART@2x-100.jpg", 1L, 3L, null, "Le tableau est daté de 1668. Selon l’inscription, le théologien serait âgé de 47 ans.  Son identité reste à ce jour inconnue", "À propos de l'oeuvre" },
                    { 18L, "/api/images/painting-stories/2_TECH@2x-100.jpg", 3L, 2L, null, "Ultramarine blue was made with lapis lazuli, which was very expensive. After mixing it with the oil, it was often stored in a pig’s bladder", "Oil paint" },
                    { 17L, "/api/images/painting-stories/2_MOV@2x-100.jpg", 3L, 2L, null, "Catholic baroque works were usually large", "Baroque" },
                    { 16L, "/api/images/painting-stories/2_ART@2x-100.jpg", 3L, 2L, null, "Did you know that the characters’ age is displayed within their clothing?", "About the artwork" },
                    { 15L, "/api/images/painting-stories/2_TECH@2x-100.jpg", 2L, 2L, null, "Ultramarijnblauw werd gemaakt met lapis lazuli, iets wat zeer duur was. Na het mixen met olie werd het vaak bewaard in een varkensblaas", "Olieverf" },
                    { 26L, "/api/images/painting-stories/3_MOV@2x-100.jpg", 3L, 3L, null, "Baroque art was made for religious propaganda", "Baroque" },
                    { 14L, "/api/images/painting-stories/2_MOV@2x-100.jpg", 2L, 2L, null, "Katholieke barok kunstwerken waren doorgaans groot", "Barok" },
                    { 12L, "/api/images/painting-stories/2_TECH@2x-100.jpg", 1L, 2L, null, "Le bleu ultramarine était fabriqué avec du lapis lazuli qui était très onéreux. Après l’avoir mélangé avec l’huile, la peinture était conservée dans une vessie de porc", "Peinture à l’huile" },
                    { 11L, "/api/images/painting-stories/2_MOV@2x-100.jpg", 1L, 2L, null, "Les oeuvres catholiques baroques étaient souvent larges", "Baroque" },
                    { 10L, "/api/images/painting-stories/2_ART@2x-100.jpg", 1L, 2L, null, "Observez bien attentivement et vous pourrez apercevoir l’âge des personnages sur leurs vêtements", "À propos de l'oeuvre" },
                    { 9L, "/api/images/painting-stories/1_TECH@2x-100.jpg", 3L, 1L, null, "Before oil paint was invented, most artists used egg tempera", "Oil paint" },
                    { 8L, "/api/images/painting-stories/1_MOV@2x-100.jpg", 3L, 1L, null, "The word 'baroque' used to be a negative term", "Baroque" },
                    { 7L, "/api/images/painting-stories/1_ART@2x-100.jpg", 3L, 1L, null, "The painter used raw brush strokes to paint the leaves on the trees, not every leave separately.", "About the artwork" },
                    { 6L, "/api/images/painting-stories/1_TECH@2x-100.jpg", 2L, 1L, null, "Voordat olieverf werd uitgevonden gebruikten de meeste kunstenaars ei tempera", "Olieverf" },
                    { 5L, "/api/images/painting-stories/1_MOV@2x-100.jpg", 2L, 1L, null, "Het woord “barok” was vroeger een negatief woord", "Barok" },
                    { 4L, "/api/images/painting-stories/1_ART@2x-100.jpg", 2L, 1L, null, "De schilder gebruikte ruwe schilder stroken om de blaadjes aan de bomen te schilderen, niet blaadje per blaadje apart", "Over het kunstwerk" },
                    { 3L, "/api/images/painting-stories/1_TECH@2x-100.jpg", 1L, 1L, null, "Avant que la peinture à l’huile ne soit inventée, la plupart des artistes utilisaient la tempera à l’oeuf", "Peinture à l’huile" },
                    { 2L, "/api/images/painting-stories/1_MOV@2x-100.jpg", 1L, 1L, null, "Le mot “baroque” avait une connotation négative", "Baroque" },
                    { 13L, "/api/images/painting-stories/2_ART@2x-100.jpg", 2L, 2L, null, "Wist je dat de leeftijd van de personen weergegeven is in hun kledij?", "Over het kunstwerk" },
                    { 27L, "/api/images/painting-stories/3_TECH@2x-100.jpg", 3L, 3L, null, "White paint was created with lead. It dried quickly and covered well", "Oil paint" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "PaintingStory");
        }
    }
}
