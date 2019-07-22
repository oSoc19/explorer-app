using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class artistsdescriptionbarok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "LanguageId", "SourceLink" },
                values: new object[] { "Jacob van Oost I is a Bruges painter and draftsman and probably a student of his brother Frans van Oost (died 1625). Van Oost is viewed as the most important 17th-century painter from Bruges. He makes portraits for the Bruges bourgeois and history paintings, but is primarily known for the altarpieces that he makes in the spirit of the Counter Reformation. The painter is strongly influenced by the Caravaggio effects that he learns in Italy. From the work of Caravaggio (1571-1610) he takes over the chiaroscuro as well as the non-idealised figures.After this, an evolution follows towards more monumental figures and a rather classicist treatment that is in line with the work of Annibale Carracci (1560-1690) and Domenichino (1581-1641).After about 1650, a greater emotionality surfaces in his work, together with the dramatic spatial effects and a palette that is related to Venetian art. In this period, van Oost is influenced by Federico Barocci (1528-35-1612), Correggio (ca. 1489-1534) and Anthony van Dyck (1599-1641). A masterpiece in his oeuvre is Portrait of a Bruges Family (Groeninge Museum, Bruges).", 3L, "https://vkc-barok-prod.inuits.eu/en/artist/jacob-van-oost-i" });

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "LanguageId", "SourceLink" },
                values: new object[] { "Jacob van Oost I is een Brugse schilder en tekenaar, en waarschijnlijk een leerling van zijn broer Frans van Oost (gestorven 1625). Van Oost wordt beschouwd als de belangrijkste zeventiende-eeuwse schilder van Brugge. Hij vervaardigt portretten voor de Brugse burgerij en historiestukken, maar staat vooral bekend om de altaarstukken die hij maakt in de geest van de contrareformatie. De schilder wordt sterk beïnvloed door het caravaggisme dat hij in Italië leert kennen. Het clair-obscur, maar ook de niet-geïdealiseerde figuren neemt hij uit het werk van Caravaggio (1571-1610) over.Daarna volgt een evolutie naar meer monumentale figuren en een eerder classicistische behandeling die aansluit bij het werk van Annibale Carracci (1560-1690) en Domenichino (1581-1641).Na circa 1650 duikt een grotere emotionaliteit in zijn werk op, samen met dramatische ruimtelijke effecten en een aan de Venetiaanse kunst verwant coloriet. Van Oost wordt in deze periode beïnvloed door Federico Barocci (1528-35-1612), Correggio (Circa 1489-1534) en Anthony van Dyck (1599-1641). Een meesterwerk in zijn oeuvre is Portret van een Brugse familie (Groeningemuseum, Brugge).", 2L, "https://vkc-barok-prod.inuits.eu/nl/kunstenaar/jacob-van-oost-i" });

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Description", "SourceLink" },
                values: new object[] { "Artus Quellinus II is een beeldhouwer en stamt uit een kunstenaarsfamilie. Hij is een neef van Artus Quellinus I (1609-1668). In diens atelier geniet hij zijn opleiding. De beeldhouwer krijgt veel opdrachten in de Zuidelijke Nederlanden, maar er is ook vraag vanuit de culturele centra in Europa, zoals Kopenhagen.Artus Quellinus II werkt dramatischer en expressiever dan Artus Quellinus I. Het benadrukken van het emotionele verraadt een link met het werk van Lucas Faydherbe (1617-1697). Quellinus heeft een voorliefde voor gracieuze lichamen, golvende draperieën, en haar dat door de wind beroerd wordt.Na 1670 is de invloed van Gianlorenzo Bernini (1598-1680) duidelijk merkbaar en heeft zijn werk (Bijvoorbeeld de beeldengroep God de vader in de Sint-Salvatorkathedraal in Brugge) een expressief en heroïsch karakter. Een uitgesproken voorbeeld van het theatrale en zeer decoratieve in zijn oeuvre is De apotheose van Sint-Jan (Sint-Jacobskerk, Antwerpen). De invloed van de hoogbarok van Gianlorenzo Bernini is hier bijzonder manifest. De Salomonszuilen met getordeerde schacht en de radiale stralen zijn ontleend aan Bernini's baldakijn in de Sint-Pietersbasiliek in Rome. Quellinus' ontwerp betekent de introductie van een nieuw soort vrijstaand altaar.Het beeld de Heilige Rosa van Lima (Sint-Pauluskerk, Antwerpen) is een voorbeeld van Quellinus' contemplatieve stijl en wordt beschouwd als een van de mooiste sculpturen uit de barok in de Zuidelijke Nederlanden.", "https://vkc-barok-prod.inuits.eu/nl/kunstenaar/artus-quellinus-ii" });

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Description", "SourceLink" },
                values: new object[] { "Artus Quellinus II is a sculptor and comes from an artistic family. He is the nephew of Artus Quellinus I (1609-1668). It is in his studio that he receives his training. The sculptor has many commissions in the Southern Netherlands, but there are also requests from the cultural centres of Europe, such as Copenhagen.Artus Quellinus II works more dramatically and more expressively than Artus I. The emphasis on the emotional reveals a link with the work of Lucas Faydherbe (1617-1697). Quellinus has a preference for graceful bodies, flowing draperies and hair that is tussled by the wind.After 1670, the influence of Gianlorenzo Bernini (1598-1680) is clearly noticeable and his work has an expressive and heroic character (for example, the sculpture group, God the Father, in the Saint Salvator Cathedral in Bruges). An explicit example of the theatrical and highly decorative in his work is The Apotheosis of Saint James (Saint James's Church, Antwerp). The influence of the High Baroque of Gianlorenzo Bernini is here especially present. The twisted Solomonic columns and the radial rays are borrowed from Bernini's Baldachin in Saint Peter's Basilica in Rome. Quellinus's design signals the introduction of a new type of freestanding altar.The image of Saint Rosa of Lima (Saint Paul's Church, Antwerp) is an example of Quellinus's contemplative style and is seen as one of the most beautiful sculptures from the Baroque in the Southern Netherlands.", "https://vkc-barok-prod.inuits.eu/en/artist/artus-quellinus-ii" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Description", "LanguageId", "SourceLink" },
                values: new object[] { "Van Oost was de telg van een uitgebreide Brugse schildersfamilie. Na zijn eerste opleiding, waarschijnlijk bij zijn broer Frans van Oost, verbleef hij in Italië van 1621 tot 1628. Vanaf 1651 bekleedde hij de functie van stadsschilder.Zijn oeuvre is sterk beïnvloed door Caravaggio en de Italiaanse meesters, alsook door Vlaamse kunstenaars als Rubens, Antoon van Dyck en Gaspard de Crayer. Zijn voornaamste werken zijn portretten en religieuze taferelen. Ze worden gekenmerkt door licht-donker-effecten, de realistische voorstelling van de figuren, de persoonlijke kleuren en de stillevenelementen. Boven het hoogaltaar van de Sint-Agathakerk te Landskouter is zijn De verrijzenis van Jezus te zien.Jacob van Oost was getrouwd met Jacquemine van Overdille. Ze kregen een zoon, Martinus. Hij hertrouwde met Maria Tollenaere en ze kregen zes kinderen. Zijn zonen Jacob II van Oost (1639-1713) en Willem van Oost (1651-1686) werden eveneens kunstschilder.Er werd een gedenkplaat aangebracht aan zijn woning, Wapenmakersstraat 3 in Brugge. Brugge heeft ook een Jakob van Ooststraat.", 2L, "https://nl.wikipedia.org/wiki/Jacob_I_van_Oost" });

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "LanguageId", "SourceLink" },
                values: new object[] { "Jacob van Oost or Jacob van Oost the Elder (1603–1671) was a Flemish painter of history paintings and portraits. He was the most important painter of Bruges in the 17th century through his portraits of members of the local bourgeois and his many altarpieces made in the spirit of the Counter Reformation. He also created genre paintings of musicians and card players for the open market.", 3L, "https://en.wikipedia.org/wiki/Jacob_van_Oost" });

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Description", "SourceLink" },
                values: new object[] { "Erasmus Quellinus II (Antwerpen, 19 november 1607 - aldaar, 7 november 1678), ook genoemd Erasmus de Jonge, was een bekende Brabantse kunstschilder en kopergraveur uit de Antwerpse kunstenaarsfamilie Quellinus. Hij was de zoon van de beeldhouwer Erasmus Quellinus I. Hij werkte vaak samen met Daniël Seghers. Een van hun gezamenlijke werken hangt in de Pinacoteca Nazionale te Bologna.Erasmus werd geboren in een familie van kunstenaars, hoofdzakelijk beeldhouwers, maar koos als beroep voor het schilderen. Hij had het geluk om één van Peter Paul Rubens' vele leerlingen te worden en vervolgens een van zijn naaste medewerkers. Na zijn opleiding bij Rubens in de jaren 1633 - 1634 werd Erasmus Quellinus II meesterschilder in het Antwerpse Sint-Lucasgilde. Hij was zeer erudiet wat zich manifesteerde in zijn verzorgde stijl en zijn veelzijdige activiteiten. Zijn grondige kennis van de mythologie en filosofie kwam tot uiting in vele van zijn werken. Zijn gevarieerde productie droeg veel bij aan de artistieke uitstraling van Antwerpen.", "https://nl.wikipedia.org/wiki/Erasmus_Quellinus_II" });

            migrationBuilder.UpdateData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Description", "SourceLink" },
                values: new object[] { "Erasmus Quellinus the Younger and Erasmus Quellinus II (1607–1678) was a Flemish painter, engraver, draughtsman and tapestry designer who worked in various genres including history, portrait, battle and animal paintings. He was a pupil of Peter Paul Rubens and was one of the closest collaborators of Rubens in the 1630s. Following Rubens’ death in 1640 he became one of the most prolific and successful painters in Flanders.", "https://en.wikipedia.org/wiki/Erasmus_Quellinus_II" });
        }
    }
}
