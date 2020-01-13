using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class SteenDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BuildingTranslation",
                columns: new[] { "Id", "BuildingId", "Description", "LanguageId", "Name", "SourceLink" },
                values: new object[,]
                {
                    { 26L, 6L, "<p><strong>1088</strong> <br>Le bâtiment est mentionné pour la première fois comme résidence des comtes de Flandre. </p> <p><strong>12<sup>e</sup> siècle</strong> <br>Les comtes quittent le bâtiment et s’installent dans le « Love » situé de l’autre côté de la place du Bourg (l’actuelle Maison du Franc de Bruges). Le « Het Steen » devient alors une prison. </p> <p><strong>1689</strong> <br>Le bâtiment brûle en grande partie. </p> <p><strong>1751</strong> <br>La ville de Bruges devient propriétaire du bâtiment « Het Steen » et le fait démolir en 1784. </p> <p><strong>1851</strong> <br>Une ferronnerie s’installe à cet endroit. </p> <p><strong>1931</strong> <br>Construction d’un bâtiment avec trois pignons à gradins dans un style néogothique (aujourd’hui Brasserie Tompouce). </p> <p><strong>1977</strong> <br>Construction de la galerie commerciale Ter Steeghere. </p>", 1L, "Le château Steen ", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 27L, 6L, "<p><strong>1088</strong> <br>voor het eerst vermeld als residentie van de graven van Vlaanderen </p> <p><strong>12de eeuw</strong> <br>de graven verlaten het gebouw en vestigen zich in de 'Love' aan de overzijde van de Burg (het huidige Landhuis van het Brugse Vrije), het Steen wordt een gevangenis </p> <p><strong>1689</strong> <br>het gebouw brandt grotendeels af </p> <p><strong>1751</strong> <br>de Stad Brugge wordt eigenaar van Het Steen en laat het in 1784 afbreken </p> <p><strong>1851</strong> <br>een ijzerhandel vestigt zich op deze locatie </p> <p><strong>1931</strong> <br>bouw van een gebouw met drie trapgevels in neogotische stijl (nu Brasserie Tompouce) </p> <p><strong>1923</strong> <br>bouw van winkelgalerij Ter Steeghere </p>", 2L, "Het Steen", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 28L, 6L, "<p><strong>1088</strong> <br>first mention of Steen Castle as a residence of the Counts of Flanders </p> <p><strong>12th century</strong> <br>the Counts leave the building, moving to the “Love” on the opposite side of Burg Square (which is now the Manor of the Franc of Bruges). Steen Castle becomes a prison. </p> <p><strong>1689</strong> <br>the building is largely destroyed in a fire </p> <p><strong>1751</strong> <br>the City of Bruges takes ownership of Steen Castle and orders its demolition in 1784 </p> <p><strong>1851</strong> <br>an ironmongers is established at this location </p> <p><strong>1931</strong> <br>construction of a building with three stepped gables in neo-Gothic style (now Brasserie Tompouce) </p> <p><strong>1977</strong> <br>construction of the Ter Steeghere shopping gallery </p>", 3L, "The Steen Castle", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 29L, 6L, "<p><strong>1088</strong> <br>Erstmalige Erwähnung als Residenz der Grafen von Flandern. </p> <p><strong>12. Jahrhundert</strong> <br>Die Grafen verlassen das Gebäude und ziehen in die Residenz „Love“ auf der gegenüberliegenden Seite des Burgplatzes (das gegenwärtige Landeshaus des Brügger Freiamts) um. „Het Steen“ wird ein Gefängnis. </p> <p><strong>1689</strong> <br>Das Gebäude wird größtenteils durch einen Brand zerstört. </p> <p><strong>1751</strong> <br>Die Stadt Brügge erwirbt „Het Steen“ und lässt das Gebäude 1784 abreißen. </p> <p><strong>1851</strong> <br>Stattdessen lässt sich ein Eisenwarenhandel hier nieder. </p> <p><strong>1931</strong> <br>Errichtung eines Gebäudes mit drei Treppengiebeln im neugotischen Stil (jetzt Brasserie Tompouce). </p> <p><strong>1977</strong> <br>Entstehung der Einkaufsgalerie „Ter Steeghere“. </p>", 4L, "Basilika", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" },
                    { 30L, 6L, "1088 Nombrado por primera vez como residencia de los condes de Flandes Siglo XII Los condes abandonan el edificio y se instalan en el «Love» al otro lado del Burg (la actual Landhuis del Brugse Vrije), el Steen pasa a ser una cárcel 1689 El edificio se incendia casi en su totalidad 1751 La ciudad de Brujas pasa a ser propietaria del Steen y lo manda demoler en 1784 1851 Se instala una herrería en este sitio 1931 Construcción de un edificio con tres fachadas escalonadas de estilo neogótico (en la actualidad Brasserie Tompouce) 1977 Construcción del pasaje comercial de Ter Steeghere", 5L, "Basílica", "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 30L);
        }
    }
}
