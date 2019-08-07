using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class numbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SourceLink",
                value: "https://vkc-barok-prod.inuits.eu/en/artist/jacob-van-oost-i/?utm_source=learnmore&utm_medium=app&utm_campaign=meertaligheid");

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                column: "SourceLink",
                value: "https://vkc-barok-prod.inuits.eu/nl/kunstenaar/jacob-van-oost-i/?utm_source=learnmore&utm_medium=app&utm_campaign=meertaligheid");

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 13L,
                column: "SourceLink",
                value: "https://vkc-barok-prod.inuits.eu/nl/kunstenaar/erasmus-quellinus-ii/?utm_source=learnmore&utm_medium=app&utm_campaign=meertaligheid");

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 14L,
                column: "SourceLink",
                value: "https://vkc-barok-prod.inuits.eu/en/artist/erasmus-quellinus-ii/?utm_source=learnmore&utm_medium=app&utm_campaign=meertaligheid");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MuseumCode",
                value: "10A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MuseumCode",
                value: "11A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 3L,
                column: "MuseumCode",
                value: "12A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 4L,
                column: "MuseumCode",
                value: "13A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 5L,
                column: "MuseumCode",
                value: "14A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 6L,
                column: "MuseumCode",
                value: "15A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 7L,
                column: "MuseumCode",
                value: "16A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 8L,
                column: "MuseumCode",
                value: "17A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 9L,
                column: "MuseumCode",
                value: "18A");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 73L,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 74L,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 75L,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 76L,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 77L,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 78L,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 79L,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 80L,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 81L,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "UseTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Name",
                value: "Hôtel de Ville");

            migrationBuilder.UpdateData(
                table: "UseTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Name",
                value: "Stadhuis");

            migrationBuilder.UpdateData(
                table: "UseTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Name",
                value: "Town Hall");

            migrationBuilder.UpdateData(
                table: "UseTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Name",
                value: "Rathaus");

            migrationBuilder.UpdateData(
                table: "UseTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Name",
                value: "Ayuntamiento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SourceLink",
                value: "https://vkc-barok-prod.inuits.eu/en/artist/jacob-van-oost-i");

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                column: "SourceLink",
                value: "https://vkc-barok-prod.inuits.eu/nl/kunstenaar/jacob-van-oost-i");

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 13L,
                column: "SourceLink",
                value: "https://vkc-barok-prod.inuits.eu/nl/kunstenaar/erasmus-quellinus-ii");

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 14L,
                column: "SourceLink",
                value: "https://vkc-barok-prod.inuits.eu/en/artist/erasmus-quellinus-ii");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MuseumCode",
                value: "22A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MuseumCode",
                value: "23A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 3L,
                column: "MuseumCode",
                value: "26A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 4L,
                column: "MuseumCode",
                value: "27A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 5L,
                column: "MuseumCode",
                value: "28A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 6L,
                column: "MuseumCode",
                value: "29A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 7L,
                column: "MuseumCode",
                value: "24A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 8L,
                column: "MuseumCode",
                value: "25A");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 9L,
                column: "MuseumCode",
                value: "30A");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 73L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/f1dea1f8e2d14c7ab25edbd98683f54040adc53f6d0e4da2aa4fb82fd1b4766b/browse.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 74L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/1e8f09c02f3f4807b168165d1e37501842824b713f4346019c8cb959954251ed/browse.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 75L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/4d9e9b5c813842a6bec20460c7bd70d151690c96490c44c19a0010d174b809fb/browse.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 76L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/f1dea1f8e2d14c7ab25edbd98683f54040adc53f6d0e4da2aa4fb82fd1b4766b/browse.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 77L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/1e8f09c02f3f4807b168165d1e37501842824b713f4346019c8cb959954251ed/browse.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 78L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/4d9e9b5c813842a6bec20460c7bd70d151690c96490c44c19a0010d174b809fb/browse.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 79L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/f1dea1f8e2d14c7ab25edbd98683f54040adc53f6d0e4da2aa4fb82fd1b4766b/browse.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 80L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/1e8f09c02f3f4807b168165d1e37501842824b713f4346019c8cb959954251ed/browse.jpg");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 81L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/4d9e9b5c813842a6bec20460c7bd70d151690c96490c44c19a0010d174b809fb/browse.jpg");

            migrationBuilder.UpdateData(
                table: "UseTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Name",
                value: "Hôtel de Ville de Bruges");

            migrationBuilder.UpdateData(
                table: "UseTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Name",
                value: "Stadhuis van Brugge");

            migrationBuilder.UpdateData(
                table: "UseTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Name",
                value: "Town Hall of Bruges");

            migrationBuilder.UpdateData(
                table: "UseTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Name",
                value: "Rathaus von Brügge");

            migrationBuilder.UpdateData(
                table: "UseTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Name",
                value: "Ayuntamiento de Brujas");
        }
    }
}
