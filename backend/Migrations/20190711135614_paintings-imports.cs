using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class paintingsimports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "Le baroque est un mouvement artistique qui trouve son origine en Italie dans des villes telles que Rome, Mantoue, Venise et Florence dès le milieu du xvie siècle et qui se termine au milieu du xviiie siècle. Il y a un âge baroque différent selon les domaines, qu'ils soient intellectuels, historiques ou artistiques. Certains critiques y voient une constante culturelle qui revient tout au long de l'histoire comme l'a écrit Eugenio d'Ors.Le baroque, qui touche tous les domaines, se caractérise par l’exagération du mouvement, la surcharge décorative, les effets dramatiques, la tension, l’exubérance des formes, la grandeur parfois pompeuse et le contraste, ce même contraste dont parlait Philippe Beaussant : l’époque baroque a tenté de dire « un monde où tous les contraires seraient harmonieusement possibles »");

            migrationBuilder.InsertData(
                table: "MovementTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "MovementId", "Name" },
                values: new object[,]
                {
                    { 2L, "De barok is een Europese stijlperiode die aan het begin van de 17e eeuw in Italië tot ontwikkeling kwam en tot in de eerste helft van de 18e eeuw voortduurde, en die zich kenmerkt door overdaad van vorm en heftigheid van gevoelsuitdrukking. De barok kwam tot uiting op alle terreinen van de cultuur, zoals architectuur, tuinarchitectuur, schilderkunst, beeldhouwkunst, literatuur en muziek. Er wordt een onderscheid gemaakt tussen vroeg-, hoog- en laatbarok. De laatbarok wordt ook wel rococo genoemd.", 2L, 1L, "Barok (stijlperiode)" },
                    { 3L, "The Baroque (UK: /bəˈrɒk/, US: /bəˈroʊk/) is a highly ornate and often extravagant style of architecture, music, dance, painting, sculpture and other arts that flourished in Europe from the early 17th until the mid-18th century. It followed Renaissance art and Mannerism and preceded the Rococo (in the past often referred to as 'late Baroque') and Neoclassical styles. It was encouraged by the Catholic Church as a means to counter the simplicity and austerity of Protestant architecture, art and music, though Lutheran Baroque art developed in parts of Europe as well.[1]The Baroque style used contrast, movement, exuberant detail, deep colour, grandeur and surprise to achieve a sense of awe. The style began at the start of the 17th century in Rome, then spread rapidly to France, northern Italy, Spain and Portugal, then to Austria and southern Germany. By the 1730s, it had evolved into an even more flamboyant style, called rocaille or Rococo, which appeared in France and Central Europe until the mid to late 18th century.", 3L, 1L, "Baroque" }
                });

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AuthorId", "Height", "ImageUrl", "Width", "Year" },
                values: new object[] { 1L, 162f, "http://groeningemuseum.be/collection/work/representation/0000_GRO0004_I", 228f, 1699 });

            migrationBuilder.InsertData(
                table: "Painting",
                columns: new[] { "Id", "AuthorId", "Height", "ImageUrl", "MovementId", "TechniqueId", "Width", "Year" },
                values: new object[,]
                {
                    { 9L, 2L, 193.5f, null, 1L, 1L, 275f, 1640 },
                    { 8L, 6L, 76.2f, "http://groeningemuseum.be/collection/work/representation/2012_GRO0001_I", 1L, 1L, 63.5f, 1652 },
                    { 7L, 5L, 220f, "http://groeningemuseum.be/collection/work/representation/1991_GRO0007_I", 1L, 1L, 240f, 1643 },
                    { 6L, 2L, 106f, "http://groeningemuseum.be/collection/work/representation/0000_GRO1346_I", 1L, 1L, 83f, 1670 },
                    { 4L, 3L, 73f, "http://groeningemuseum.be/collection/work/representation/0000_GRO0187_I", 1L, 1L, 59f, 1697 },
                    { 3L, 2L, 116f, "http://groeningemuseum.be/collection/work/representation/0000_GRO0184_I", 1L, 1L, 222f, 1668 },
                    { 2L, 2L, 150.5f, "http://groeningemuseum.be/collection/work/representation/0000_GRO0181_I", 1L, 1L, 255.5f, 1645 },
                    { 5L, 4L, 123.3f, "http://groeningemuseum.be/collection/work/representation/0000_GRO0374_I", 1L, 1L, 94.2f, 1641 }
                });

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name" },
                values: new object[] { null, "Paysage boisé avec gué" });

            migrationBuilder.InsertData(
                table: "PaintingTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "Name", "PaintingId" },
                values: new object[,]
                {
                    { 2L, "Gezicht op een open plek in het bos, met marktkramers en boeren, nabij een doorwaadbare plaats in een beek. Aan de overkant van het water staat een man met twee paarden. Doorheen de bomen heeft men een doorkijk op een verre, gedeeltelijk beboste achtergrond, waar eveneens mensen te zien zijn. De personages op de voorgrond lijken door Achtschellinck zelf geschilderd te zijn; ze zijn duidelijk verwant aan de figuren van zijn tijd- en stadsgenoot David Teniers de Jongere. Het schilderij vertoont een zeer enge stijlovereenkomst met de andere beboste landschappen van Lucas Achtschellinck in de collectie van het Groeningemuseum", 2L, "Boslandschap met wad", 1L },
                    { 3L, null, 3L, "Wooded Landscape with Ford", 1L }
                });

            migrationBuilder.UpdateData(
                table: "TechniqueTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "La peinture à l'huile est une peinture dont le liant ou véhicule est une huile siccative qui enveloppe complètement les particules de pigment.On appelle aussi « peinture » les travaux d'enduction d'une surface par ce genre de produit. Les autorités normatives françaises demandent qu'on dise peinturage, mais ce terme n'a jamais pris1. La « peinture à l'huile » est donc aussi l'activité de nombreux artistes peintres passés et présents, ainsi qu'une technique picturale.");

            migrationBuilder.InsertData(
                table: "TechniqueTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "Name", "TechniqueId" },
                values: new object[,]
                {
                    { 2L, "Olieverf is een verfsoort, een mengsel van pigment in de vorm van een zeer fijn gekleurd poeder met, als bindmiddel, een plantaardige drogende olie, meestal lijnolie. Olieverf is vanaf de 15e eeuw een belangrijk medium in de schilderkunst. Ze werd voor het eerst gebruikt door de Vlaamse Primitieven.", 2L, "olieverfschilderij", 1L },
                    { 3L, "Oil paint is a type of slow-drying paint that consists of particles of pigment suspended in a drying oil, commonly linseed oil. The viscosity of the paint may be modified by the addition of a solvent such as turpentine or white spirit, and varnish may be added to increase the glossiness of the dried oil paint film. Oil paints have been used in Europe since the 12th century for simple decoration, but were not widely adopted as an artistic medium until the early 15th century. Common modern applications of oil paint are in finishing and protection of wood in buildings and exposed metal structures such as ships and bridges. Its hard-wearing properties and luminous colors make it desirable for both interior and exterior use on wood and metal. Due to its slow-drying properties, it has recently been used in paint-on-glass animation. Thickness of coat has considerable bearing on time required for drying: thin coats of oil paint dry relatively quickly.", 3L, "Oil paint", 1L }
                });

            migrationBuilder.InsertData(
                table: "PaintingTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "Name", "PaintingId" },
                values: new object[,]
                {
                    { 4L, null, 1L, "Portrait d'une famille brugeoise", 2L },
                    { 25L, null, 1L, "La Vocation de saint Matthieu", 9L },
                    { 24L, null, 3L, "Portrait of Samuel Crew", 8L },
                    { 23L, "Het betreft een vroeg portret van Lely ut 1650 van Samuel Crew, of zijn broer Nathaniel Crew, telgen van een belangrijke Engelse familie en beide protestantse priesters. Hun vader John Crew of Stene was lid van het Engelse Parliament en fungeerde tussen 1623 en 1625 als Speaker of the House. Lely wilde met dit portret duidelijk aan de verwachtingen van zijn opdrachtgever en zijn belangrijkste mecenas voldoen. Met grote virtuositeit - waarin reflecties van de portretkunst van Frans Hals zijn te herkennen - schildert Lely de kledij van de jonge heer (vermoedelijk Samuel), met veel aandacht voor de textuur en de lichtinval op het zwarte textiel. Het witte hemd schittert in het midden van de donkere, eerder sombere sfeer van het schilderij. Alleen het gelaat en de haren zijn door de lichtinval duidelijk benadrukt. Gedurfd toont Lely zijn model niet in het centrum van het doek, maar positioneert hij de jongeman net uit de middenas van het schilderij. Op die manier vermijdt hij het formalisme van portretten.", 2L, "Portret van Samuel Crew", 8L },
                    { 22L, null, 1L, "Portrait de Samuel Crew", 8L },
                    { 21L, null, 3L, "Achilles among the Daughters of Lycomedes", 7L },
                    { 20L, "Aan Thetis was voorspeld dat haar zoon Achilles in de Trojaanse Oorlog zou sneuvelen. Om dit lot te omzeilen, verborg ze hem verkleed als vrouw aan het hof van koning Lycomedes. Voor de Griekse aanvoerders Odysseus en Diomedes was Achilles echter onmisbaar. Ze kwamen zijn schuilplaats te weten, en met een list wilden ze hem ontmaskeren. De twee legeraanvoerders gaven geschenken, waaronder wapens, aan de dochters van Lycomedes, met onder hen de verklede Achilles. Spontaan greep Achilles naar een helm en een zwaard, waardoor hij zichzelf verraadde.Links op het voorplan van het schilderij zijn Odysseus en Diomedes afgebeeld. Eén van hen grijpt Achilles bij zijn mouw, op het moment dat hij een helm past en een wapen grijpt uit de geschenken die rechts in een mand zitten en waarrond de dochters van Lycomedes zich scharen. Het tafereel speelt zich af op een terras, met links een doorkijk naar een tuin. De Antwerpse schilder Erasmus Quellinus II behoorde tot een familie van beeldhouwers, schilders, etsers en houtsnijders. Hij was leerling en medewerker van Peter Paul Rubens, die hij als stadsschilder van Antwerpen opvolgde. (Naar: H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 143.)", 2L, "Achilles en de dochters van Lycomedes", 7L },
                    { 19L, null, 1L, "Achille parmi les filles de Lycomède", 7L },
                    { 18L, null, 3L, "Portrait of Fovin de Hasque", 6L },
                    { 17L, "De schermmeester van de Brugse Sint-Michielsgilde is hier voorgesteld met een degen aan zijn gordel. Met zijn rechterhand houdt hij de schacht van een hellebaard of een standaard vast. Het opschrift luidt: Dit is het beelt van Fovin d'Hasque Schermmeester van Brugghe vaillant / Die alhier ghebracht heeft de olie van [de] H. Walburgis uyt duytslant / 1670. Dit laatste deed De Hasque in 1669, op verzoek van de pastoors, kapelaans en kerkmeesters van Sint-Walburga in Brugge. Hij overleed in datzelfde jaar. Wellicht werd dit portret geschilderd naar aanleiding van zijn dood. (Naar: H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 204.)", 2L, "Portret van Fovin de Hasque", 6L },
                    { 16L, null, 1L, "Portrait de Fovin de Hasque", 6L },
                    { 15L, null, 3L, "Holy Trinity", 5L },
                    { 14L, "God de Vader, met tiara op het hoofd, toont Christus, de Zoon, die ostentatief zijn wonden laat zien. Boven beiden zweeft de Helige Geest, in de gedaante van een duif. De hier gevolgde iconografie heeft een oude traditie: uiteindelijk gaat ze terug op Dürers gelijknamige prent uit 1511, die op haar beurt weer vroegere Oud-Nederlandse prototypes reflecteert. Het schilderij werd in het verleden begeschreven als achtereenvolgens een werk van Gerard Seghers, een kopie naar Rubens, van de hand van Nicolaas de Liemaeker, in verband te brengen met Abraham Janssens, en toe te schrijven aan Joos de Momper. De recentste toeschrijving toont aan dat het uit het atelier van de Antwerpse schilder Artus Wolffort zou afkomstig zijn. Dit baseert voornamelijk op de karakteristieke gelaatstypering. Van deze compositie bestaan verschillende versies.", 2L, "Heilige Drievuldigheid", 5L },
                    { 13L, null, 1L, "Sainte Trinité", 5L },
                    { 12L, null, 3L, "Portrait of a Man", 4L },
                    { 11L, "Borstbeeld van een in het zwart geklede man in driekwartswending. Ovaal schilderij, gevat in een rechthoekige lijst. Af te leiden uit het opschrift op de achterzijde, gaat het hier om een vriend van de kunstenaar. (Naar: H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, pp. 208.)", 2L, "Portret van een man", 4L },
                    { 10L, null, 1L, "Portrait d' un homme", 4L },
                    { 9L, null, 3L, "Portrait of a Theologue and his Secretary", 3L },
                    { 8L, "Een theoloog, waarschijnlijk een jezuïet, leest de conciliebesluiten en becommentarieert ze. Zijn seculiere secretaris noteert. Links staat de lezenaar, versierd met een sculptuur van een Calvariegroep, en met deel 36 van de verzamelde conciliebesluiten er op. Rechts een werktafel  met een rijk gekleurd tafelkleed, waaraan de priester en de secretaris zitten. Op de tafel bevinden zich studie-attributen, zoals een wereldbol en een boek. Erachter ziet men een boekenkast met bijbeluitgaven en literatuur op het gebied van theologie, exegese en kerkelijk recht. Zoals vaak, inspireert Van Oost zich ook hier weer op de portretten van Anthony van Dyck.  (Naar: H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 198; E. Tahon, in: musea@brugge, augustus 2003, pp. 13-14.)", 2L, "Portret van een theoloog met zijn secretaris", 3L },
                    { 7L, null, 1L, "Portrait d’un théologien et son secrétaire", 3L },
                    { 6L, null, 3L, "Portrait of a Bruges family", 2L },
                    { 5L, "De burgerman wijst ostentatief naar het ommeland om onze aandacht te vestigen op zijn bezittingen. Het lage gezichtspunt maakt dat de personages een imposante indruk maken. De familie is onbekend, maar door het herkenbare silhouet van de stad Brugge dient de familie in Brugse context gesitueerd te worden. De leeftijden van de familieleden zijn onopvallend geïntegreerd: bij de man op de hiel van zijn schoen (46), bij de vrouw op haar waaier (26), bij de kleine jongen naast haar op zijn hoedje (3), bij het zittende meisje op het kussen in haar korf (15), bij de jongeman op zijn laars (17), en bij het kindje in de armen van het kindermeisje op het stuk brood in haar handen (1). Uit het grote leeftijdsverschil tussen de echtgenoten enerzijds, en de jonge leeftijd van de vrouw anderzijds, kan afgeleid worden dat de kinderen uit twee huwelijken moeten stammen. Waarschijnlijk zijn alleen de twee kleinste kinderen geboren uit het huwelijk met de hier afgebeelde vrouw. Uiterst links op het schilderij staat een tuinman met een spade over de schouder, afdalend naar de tuin. Zoals bij de meeste familieportretten bevat dit werk een onderliggende symboliek, verwijzend naar liefde, zuiverheid en vruchtbaarheid, als voorwaarden voor een harmonisch gezinsleven. Daarnaast wordt de sociale status van het gezin belicht.  (Naar: H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, pp. 194-195.)", 2L, "Portret van een Brugse familie", 2L },
                    { 26L, null, 2L, "Roeping van Mattheüs", 9L },
                    { 27L, null, 3L, "The Calling of St Matthew", 9L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "TechniqueTranslation",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "TechniqueTranslation",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "Baroque description too lazy to look for it");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AuthorId", "Height", "ImageUrl", "Width", "Year" },
                values: new object[] { 2L, 116f, "http://groeningemuseum.be/collection/work/representation/0000_GRO0184_I", 222f, 1668 });

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Once again again lazy", "Portrait d’un théologien et son secrétaire" });

            migrationBuilder.UpdateData(
                table: "TechniqueTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "Too lazy again");
        }
    }
}
