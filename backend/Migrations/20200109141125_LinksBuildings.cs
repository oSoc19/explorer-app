using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class LinksBuildings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "Birthdate", "Deathdate", "FirstName", "LastName", "Nationality" },
                values: new object[,]
                {
                    { 7L, "1618-09-14", "1680-11-30", "Hendrik", "Pickery", "Netherlands" },
                    { 8L, "1618-09-14", "1680-11-30", "Louis", "Delacenserie", "Netherlands" }
                });

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Place_du_Bourg");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Burg_(Brugge)");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Burg_Square");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Burgplatz_(Br%C3%BCgge)");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Burg_Square");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Franc_de_Bruges#Maison_du_Franc_%C3%A0_Bruges");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 7L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Brugse_Vrije");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Brugse_Vrije#The_Manor");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 9L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Br%C3%BCgger_Freiamt#Landeshaus_des_Br%C3%BCgger_Freiamts");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 10L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Brugse_Vrije#The_Manor");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 11L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Ancien_greffe_civil_de_la_ville_de_Bruges");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 12L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Oude_Civiele_Griffie");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 13L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Old_Civil_Registry");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 14L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Alte_Zivilkanzlei_(Br%C3%BCgge)");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 15L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Old_Civil_Registry");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 16L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/H%C3%B4tel_de_ville_de_Bruges");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 17L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Bruges_City_Hall");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 18L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Bruges_City_Hall");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 19L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Bruges_City_Hall");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 20L,
                column: "SourceLink",
                value: "https://es.wikipedia.org/wiki/Ayuntamiento_de_Brujas");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Basilique_du_Saint-Sang_de_Bruges");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 22L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Basiliek_van_het_Heilig_Bloed");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 23L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Basilica_of_the_Holy_Blood");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 24L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Heilig-Blut-Basilika");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 25L,
                column: "SourceLink",
                value: "https://es.wikipedia.org/wiki/Bas%C3%ADlica_de_la_Santa_Sangre_de_Brujas");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 26L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Het_Steen_(Bruges)");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 27L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Het_Steen_(Brugge)");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 28L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Draft:Het_Steen_(Brugge)");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 29L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Draft:Het_Steen_(Brugge)");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 30L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Draft:Het_Steen_(Brugge)");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 31L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Pr%C3%A9vot%C3%A9_de_Saint-Donatien_(Bruges)");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 32L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Sint-Donaasproosdij");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 33L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Provostry_of_St._Donatian");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 34L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Provostry_of_St._Donatian");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 35L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Provostry_of_St._Donatian");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 36L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Cath%C3%A9drale_Saint-Donatien_de_Bruges");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 37L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Sint-Donaaskathedraal");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 38L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/St._Donatian%27s_Cathedral");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 39L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Sint-Donaaskathedraal");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 40L,
                column: "SourceLink",
                value: "https://es.wikipedia.org/wiki/Catedral_de_San_Donaciano");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Architecture_baroque");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Barokarchitectuur");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Baroque_architecture");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Barock#Baukunst");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SourceLink",
                value: "https://es.wikipedia.org/wiki/Arquitectura_del_Barroco");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Gothic_architecture#Civic_architecture");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 11L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Architecture_romane");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Name", "SourceLink" },
                values: new object[] { "Romaans", "https://nl.wikipedia.org/wiki/Romaanse_architectuur" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 13L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Romanesque_architecture");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 14L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Romanik#Romanische_Baukunst");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 15L,
                column: "SourceLink",
                value: "https://es.wikipedia.org/wiki/Arte_rom%C3%A1nico");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 16L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Architecture_de_la_Renaissance");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 17L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Renaissancearchitectuur");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 18L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Renaissance_architecture");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 19L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Architektur_der_Renaissance");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 20L,
                column: "SourceLink",
                value: "https://es.wikipedia.org/wiki/Arquitectura_del_Renacimiento");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Classicisme#Architecture");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 22L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Classicisme#Architectuur");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 23L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Classicism#In_architecture");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 24L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Klassizismus#Architektur_des_Klassizismus");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 25L,
                column: "SourceLink",
                value: "https://es.wikipedia.org/wiki/Arquitectura_neocl%C3%A1sica");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 28L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Gothic_architecture#Civic_architecture");

            migrationBuilder.InsertData(
                table: "ArtistTranslation",
                columns: new[] { "Id", "ArtistId", "Description", "LanguageId", "SourceLink" },
                values: new object[,]
                {
                    { 31L, 7L, "Hendrik Pickery (1828-1894) était un sculpteur brugeois. Il fut l’élève du sculpteur liégeois Eugène Simonis (1810-1882). Les statues sur les escaliers et sur la façade du Palais provincial de Bruges (Grand-Place) ainsi que la statue de Hans Memling (Woensdagmarkt) ont également été réalisées par Pickery.", 1L, "https://rkd.nl/en/explore/artists/63328" },
                    { 32L, 7L, "Hendrik Pickery (1828–1894) was een Brugse beeldhouwer. Hij was een leerling van de Luikse beeldhouwer Eugène Simonis (1810–1882). Ook de beelden op de trappen en aan de gevel van het Provinciaal Hof (Markt) en het standbeeld van Hans Memling (Woensdagmarkt) zijn van de hand van Pickery.", 2L, "https://nl.wikipedia.org/wiki/Hendrik_Pickery" },
                    { 33L, 7L, "Hendrik Pickery (1828–1894) was a sculptor from Bruges. He was a student of the sculptor Eugène Simonis (1810–1882), who was from Liège. The statues on the steps of the gable of the Provinciaal Hof (Markt) and the statue of Hans Memling (Woensdagmarkt) are also Pickery’s work.", 3L, "https://rkd.nl/en/explore/artists/63328" },
                    { 34L, 7L, "Hendrik Pickery (1828–1894) war ein Brügger Bildhauer. Er war ein Schüler des Lütticher Bildhauers Eugène Simonis (1810–1882). Auch die Skulpturen auf den Treppen und an der Fassade des Provinzialpalastes („Provinciaal Hof“ am Marktplatz) und die Statue von Hans Memling (Woensdagmarkt) stammen von Pickery.", 4L, "https://rkd.nl/en/explore/artists/63328" },
                    { 35L, 7L, "Hendrik Pickery (1828–1894) fue un escultor brujense. Fue alumno del escultor liejense Eugène Simonis (1810–1882). Las estatuas sobre las escaleras y en la fachada de la Corte Provincial (en la plaza del Markt), y la estatua de Hans Memling (plaza de Woensdagmarkt) son obra de Pickery.", 5L, "https://rkd.nl/en/explore/artists/63328" },
                    { 36L, 8L, "L’architecte Louis Delacenserie (1838-1909) a restauré plusieurs bâtiments médiévaux de Bruges dans un style néogothique. Le Palais provincial sur la Grand-Place (1892) a également été conçu par lui. En dehors de la ville de Bruges, Louis Delacenserie a conçu notamment la Gare centrale d’Anvers.", 1L, "https://fr.wikipedia.org/wiki/Louis_de_la_Censerie" },
                    { 37L, 8L, "De architect Louis Delacenserie (1838-1909) restaureerde in Brugge verschillende middeleeuwse gebouwen in neogotische stijl. Ook het Provinciaal Hof op de Markt (1892) is van zijn hand. Buiten Brugge ontwierp hij onder meer het Centraal Station van Antwerpen.", 2L, "https://nl.wikipedia.org/wiki/Louis_Delacenserie" },
                    { 38L, 8L, "Architect Louis Delacenserie (1838-1909) restored a number of medieval buildings in Bruges in the neo-Gothic style. The Provinciaal Hof on the Markt is also his work. Outside Bruges, he designed Antwerp Central Station and other buildings.", 3L, "https://rkd.nl/en/explore/artists/344043" },
                    { 39L, 8L, "Der Architekt Louis Delacenserie (1838–1909) restaurierte in Brügge verschiedene mittelalterliche Gebäude im neugotischen Stil. Auch der Provinzialpalast am Marktplatz (1892) stammt von ihm. Außerhalb von Brügge entwarf er unter anderem den Antwerpener Zentralbahnhof.", 4L, "https://rkd.nl/en/explore/artists/344043" },
                    { 40L, 8L, "El arquitecto Louis Delacenserie (1838-1909) restauró en Brujas varios edificios medievales de estilo neogótico. La Corte Provincial en la plaza del Markt (1892) también fue obra suya. Fuera de Brujas diseñó, entre otras cosas, la Estación Central de Amberes.", 5L, "https://rkd.nl/en/explore/artists/344043" }
                });

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AuthorId",
                value: 7L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AuthorId",
                value: 8L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 3L,
                column: "AuthorId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 4L,
                column: "AuthorId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 7L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 9L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 10L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 11L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 12L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 13L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 14L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 15L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 16L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 17L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 18L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 19L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 20L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 22L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 23L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 24L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 25L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 26L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 27L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 28L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 29L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 30L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 31L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 32L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 33L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 34L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 35L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 36L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 37L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 38L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 39L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 40L,
                column: "SourceLink",
                value: "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Baroque");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Barok_(stijlperiode)");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Baroque");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Barock");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "SourceLink",
                value: "https://es.wikipedia.org/wiki/Barroco");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Gothic_architecture");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 11L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Architecture_gothique");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Name", "SourceLink" },
                values: new object[] { "Gotisch", "https://nl.wikipedia.org/wiki/Gotiek_(bouwkunst)" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 13L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Gothic_architecture");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 14L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Gotik#Baukunst");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 15L,
                column: "SourceLink",
                value: "https://es.wikipedia.org/wiki/Arquitectura_g%C3%B3tica");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 16L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Architecture_gothique");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 17L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Gotiek_(bouwkunst)");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 18L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Gothic_architecture");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 19L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Gotik#Baukunst");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 20L,
                column: "SourceLink",
                value: "https://es.wikipedia.org/wiki/Arquitectura_g%C3%B3tica");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Architecture_gothique");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 22L,
                column: "SourceLink",
                value: "https://nl.wikipedia.org/wiki/Gotiek_(bouwkunst)");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 23L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Gothic_architecture");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 24L,
                column: "SourceLink",
                value: "https://de.wikipedia.org/wiki/Gotik#Baukunst");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 25L,
                column: "SourceLink",
                value: "https://es.wikipedia.org/wiki/Arquitectura_g%C3%B3tica");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 28L,
                column: "SourceLink",
                value: "https://en.wikipedia.org/wiki/Gothic_architecture");
        }
    }
}
