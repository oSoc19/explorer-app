using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class StoriesLandhuis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 102L,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg/1012px-Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 103L,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg/1012px-Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 104L,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg/1012px-Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 105L,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg/1012px-Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 106L,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg/1012px-Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg");

            migrationBuilder.InsertData(
                table: "BuildingStory",
                columns: new[] { "Id", "BuildingId", "ImageUrl", "LanguageId", "Subtitle", "Text", "Title", "Type" },
                values: new object[,]
                {
                    { 129L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/6d2bc8dac1c44fd28e04a030d6ce464a410d5ac70faa468faf3754196a022ca2/browse.jpg", 3L, " ", "The Manor as a court of justice.", "Landhuis", "artwork" },
                    { 128L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/6d2bc8dac1c44fd28e04a030d6ce464a410d5ac70faa468faf3754196a022ca2/browse.jpg", 2L, " ", "Het Landhuis als gerechtshof.", "Landhuis", "artwork" },
                    { 127L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/6d2bc8dac1c44fd28e04a030d6ce464a410d5ac70faa468faf3754196a022ca2/browse.jpg", 1L, " ", "La Maison du France comme Palais de Justice.", "Landhuis", "artwork" },
                    { 126L, 1L, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Famien_Strada_Histoire-Palace_of_het_Brugse_Vrije-ppn087811480_MG_8951T3p403.tif/lossy-page1-1280px-Famien_Strada_Histoire-Palace_of_het_Brugse_Vrije-ppn087811480_MG_8951T3p403.tif.jpg", 5L, " ", "Hasta la Revolución Francesa, este lugar fue la sede de la dirección del Brugse Vrije, el campo que rodeaba Brujas.", "Landhuis", "artwork" },
                    { 125L, 1L, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Famien_Strada_Histoire-Palace_of_het_Brugse_Vrije-ppn087811480_MG_8951T3p403.tif/lossy-page1-1280px-Famien_Strada_Histoire-Palace_of_het_Brugse_Vrije-ppn087811480_MG_8951T3p403.tif.jpg", 4L, " ", "Bis zur Französischen Revolution war hier das Brügger Freiamt, die Verwaltung des Brügger Umlands, untergebracht.", "Landhuis", "artwork" },
                    { 124L, 1L, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Famien_Strada_Histoire-Palace_of_het_Brugse_Vrije-ppn087811480_MG_8951T3p403.tif/lossy-page1-1280px-Famien_Strada_Histoire-Palace_of_het_Brugse_Vrije-ppn087811480_MG_8951T3p403.tif.jpg", 3L, " ", "Until the French Revolution, this was the administrative seat of the Franc of Bruges, the area surrounding Bruges.", "Landhuis", "artwork" },
                    { 123L, 1L, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Famien_Strada_Histoire-Palace_of_het_Brugse_Vrije-ppn087811480_MG_8951T3p403.tif/lossy-page1-1280px-Famien_Strada_Histoire-Palace_of_het_Brugse_Vrije-ppn087811480_MG_8951T3p403.tif.jpg", 2L, " ", "Tot de Franse Revolutie zetelde hier het bestuur van het Brugse Vrije, het platteland rond Brugge.", "Landhuis", "artwork" },
                    { 122L, 1L, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Famien_Strada_Histoire-Palace_of_het_Brugse_Vrije-ppn087811480_MG_8951T3p403.tif/lossy-page1-1280px-Famien_Strada_Histoire-Palace_of_het_Brugse_Vrije-ppn087811480_MG_8951T3p403.tif.jpg", 1L, " ", "Jusqu’à la Révolution française, l’administration du Franc de Bruges, la campagne brugeoise, y siégeait.", "Landhuis", "artwork" },
                    { 121L, 1L, "https://museabrugge.imgix.net/https%3A%2F%2Fwww.museabrugge.be%2Fvolumes%2Fgeneral%2FSchilderij_VanTilborg-opgelicht.jpg?auto=compress%2Cformat&fit=clip&h=400&s=8b95ab0b4ffd6fafd41b5f9bd370d36e", 5L, " ", "La sala para el escabinado en el landhuis (Gillis van Tillborgh, 1658).", "Landhuis", "artwork" },
                    { 120L, 1L, "https://museabrugge.imgix.net/https%3A%2F%2Fwww.museabrugge.be%2Fvolumes%2Fgeneral%2FSchilderij_VanTilborg-opgelicht.jpg?auto=compress%2Cformat&fit=clip&h=400&s=8b95ab0b4ffd6fafd41b5f9bd370d36e", 4L, " ", "Der Schöffenkammer im Landeshaus (Gillis van Tillborgh, 1658).", "Landhuis", "artwork" },
                    { 119L, 1L, "https://museabrugge.imgix.net/https%3A%2F%2Fwww.museabrugge.be%2Fvolumes%2Fgeneral%2FSchilderij_VanTilborg-opgelicht.jpg?auto=compress%2Cformat&fit=clip&h=400&s=8b95ab0b4ffd6fafd41b5f9bd370d36e", 3L, " ", "The alderman’s room in the manor (Gillis van Tillborgh, 1658).", "Landhuis", "artwork" },
                    { 116L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e1651f7244954c1a9499a07a694130d043c3b60fbea24a6d91ea3e9ef8dc3df2/browse.jpg", 5L, " ", "En la sala del escabinado se encuentra la monumental chimenea del emperador Carlos V del siglo XVI, de madera de roble, mármol y alabastro.", "Landhuis", "artwork" },
                    { 117L, 1L, "https://museabrugge.imgix.net/https%3A%2F%2Fwww.museabrugge.be%2Fvolumes%2Fgeneral%2FSchilderij_VanTilborg-opgelicht.jpg?auto=compress%2Cformat&fit=clip&h=400&s=8b95ab0b4ffd6fafd41b5f9bd370d36e", 1L, " ", "La salle échevinale dans la Maison du Franc (Gillis van Tillborgh, 1658).", "Landhuis", "artwork" },
                    { 130L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/6d2bc8dac1c44fd28e04a030d6ce464a410d5ac70faa468faf3754196a022ca2/browse.jpg", 4L, " ", "Das Landeshaus als Gerichtshof.", "Landhuis", "artwork" },
                    { 115L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e1651f7244954c1a9499a07a694130d043c3b60fbea24a6d91ea3e9ef8dc3df2/browse.jpg", 4L, " ", "Im Schöffensaal befindet sich der monumentale Kaiser-Karl-Kamin aus dem 16. Jahrhundert, der aus Eichenholz, Marmor und Alabaster angefertigt wurde.", "Landhuis", "artwork" },
                    { 114L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e1651f7244954c1a9499a07a694130d043c3b60fbea24a6d91ea3e9ef8dc3df2/browse.jpg", 3L, " ", "In the aldermen’s room, there is a huge 16th century Charles V fireplace made of oak, marble and alabaster.", "Landhuis", "artwork" },
                    { 113L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e1651f7244954c1a9499a07a694130d043c3b60fbea24a6d91ea3e9ef8dc3df2/browse.jpg", 2L, " ", "In de schepenzaal bevindt zich de monumentale 16de-eeuwse Keizer-Karel-schouw, in eikenhout, marmer en albast.", "Landhuis", "artwork" },
                    { 112L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e1651f7244954c1a9499a07a694130d043c3b60fbea24a6d91ea3e9ef8dc3df2/browse.jpg", 1L, " ", "La monumentale cheminée Charles-Quint du 16e siècle, en chêne, marbre et albâtre, est située dans la salle échevinale.", "Landhuis", "artwork" },
                    { 111L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/b382e23288c947a397a1d2862c70cc358a96af88bbcd423b9305218b6b816bc7/browse.jpg", 5L, " ", "En la época medieval, aquí se encontraba ubicada una de las residencias de los condes de Flandes.", "Landhuis", "artwork" },
                    { 110L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/b382e23288c947a397a1d2862c70cc358a96af88bbcd423b9305218b6b816bc7/browse.jpg", 4L, " ", "Im Mittelalter befand sich hier eine der Residenzen der Grafen von Flandern.", "Landhuis", "artwork" },
                    { 109L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/b382e23288c947a397a1d2862c70cc358a96af88bbcd423b9305218b6b816bc7/browse.jpg", 3L, " ", "During the middle ages, this was one of the residences of the Counts of Flanders.", "Landhuis", "artwork" },
                    { 108L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/b382e23288c947a397a1d2862c70cc358a96af88bbcd423b9305218b6b816bc7/browse.jpg", 2L, " ", "In de middeleeuwen bevond zich hier een van de residenties van de graven van Vlaanderen.", "Landhuis", "artwork" },
                    { 107L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/b382e23288c947a397a1d2862c70cc358a96af88bbcd423b9305218b6b816bc7/browse.jpg", 1L, " ", "Au Moyen-Âge, ce bâtiment abritait l’une des résidences des comtes de Flandre.", "Landhuis", "artwork" },
                    { 118L, 1L, "https://museabrugge.imgix.net/https%3A%2F%2Fwww.museabrugge.be%2Fvolumes%2Fgeneral%2FSchilderij_VanTilborg-opgelicht.jpg?auto=compress%2Cformat&fit=clip&h=400&s=8b95ab0b4ffd6fafd41b5f9bd370d36e", 2L, " ", "De schepenkamer in het Landhuis (Gillis van Tillborgh, 1658).", "Landhuis", "artwork" },
                    { 131L, 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/6d2bc8dac1c44fd28e04a030d6ce464a410d5ac70faa468faf3754196a022ca2/browse.jpg", 5L, " ", "La casa como tribunal de justicia.", "Landhuis", "artwork" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 102L,
                column: "ImageUrl",
                value: "https://nl.m.wikipedia.org/wiki/Bestand:Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 103L,
                column: "ImageUrl",
                value: "https://nl.m.wikipedia.org/wiki/Bestand:Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 104L,
                column: "ImageUrl",
                value: "https://nl.m.wikipedia.org/wiki/Bestand:Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 105L,
                column: "ImageUrl",
                value: "https://nl.m.wikipedia.org/wiki/Bestand:Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 106L,
                column: "ImageUrl",
                value: "https://nl.m.wikipedia.org/wiki/Bestand:Jan_Baptist_van_Meunincxhove_-_The_Burg_in_Bruges.jpg");
        }
    }
}
