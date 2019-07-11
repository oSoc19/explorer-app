using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class artistsdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "Birthdate", "Deathdate", "FirstName", "LastName", "Nationality" },
                values: new object[,]
                {
                    { 4L, "1581", "1641", "Artus", "Wolfordt", "Spanish Netherlands" },
                    { 5L, "1607-11-19", "1678-11-11", "Erasmus II", "Quellinus", "Spanish Netherlands" },
                    { 6L, "1618-09-14", "1680-11-30", "Peter", "Lely", "Netherlands" }
                });

            migrationBuilder.InsertData(
                table: "ArtistTranslation",
                columns: new[] { "Id", "ArtistId", "Description", "LanguageId" },
                values: new object[,]
                {
                    { 1L, 1L, "Lucas Achtschellinck est un peintre brabançon baroque spécialisé dans la peinture de paysages.Il est né à Bruxelles en 1626, fut baptisé le 16 janvier de la même année1 . Il entre dans la guilde des peintres le 29 octobre 1639 comme élève de Pieter van der Borcht2.En 1655, à la mort de Lodewijk de Vadder, il pose sa candidature pour devenir cartonnier privilégié de la ville de Bruxelles3. Un voyage à l'étranger peut être envisagé, puisqu'il n'est admis maître qu'en 16574. En 1659, il reçoit 120 florins pour un tableau exécuté à Sainte Gudule5. En 1660 Corneille de Bie publie le Gulden Cabinet6 dans lequel il décrit le style de Lucas Achtschellinck. En 1662, il reçoit 120 florins pour un tableau exécuté à Sainte Gudule7. En 1671, il collabore avec le peintre malinois Lucas Franchois et est payé pour cela en 16738. Le 13 mai 1674, il épouse Anna Parys à l'église du Finistère à Bruxelles9. En 1687, il est doyen représentant les peintres à la corporation et ce jusqu'en 168910. En 1689, il est exonéré en tant que cartonnier11 En 1681, il est « reconnu » c'est-à-dire : exempté de certaines charges du métier à la condition qu'il ne se livre qu'à des travaux artistiques12. Achtschellick est influencé par le style de Rubens dans la façon de peindre les paysages. Il est également fortement influencé par Jacques d'Arthois. Il peint des paysages forestiers, des églises et des cloîtres, ainsi que des scènes avec des personnages inspirées de la Bible. Achtschellinck est connu pour avoir peint les paysages des œuvres majeures du peintre flamand Gaspard de Crayer (1582-1669).Lucas Achtschellinck est souvent associé à son professeur de peinture Lodewijk de Vadder (1605-1655)13, ainsi qu'à Jacques d'Arthois (1603-1686). En effet, on les appelle les peintres de la Forêt de Soignes.", 1L },
                    { 4L, 2L, "Jacob van Oost dit le Vieux, également connu sous le nom de Jacques Van Oost le Vieux, né le 1er juillet 1603 à Bruges où il est mort entre le 1er et le 3 mars 1671, est un peintre flamand. Il est considéré comme étant le principal peintre brugeois du xviie siècle.", 1L },
                    { 7L, 3L, "Jacob van Oost dit le Jeune, né en 1637 et décédé en 1713 à Bruges, connu aussi comme Jacques Van Oost le Jeune, est un peintre baroque flamand.Élève de son père, Jacob van Oost dit le vieux, à Bruges, il poursuit sa formation à Paris puis Rome. Il s'installe à Lille en Flandre en 1668. Il est l'un des peintres les plus renommés, avec Arnould de Vuez, à œuvrer à Lille durant ces années.Peintre de portraits mais surtout de sujets religieux, il couvre les églises et couvents de la ville de ses œuvres. Il épouse une lilloise, Marie Bourgeois, en 1670. De cette union naissent plusieurs enfants dont Dominique van Oost (1677-1738), peintre comme son père.Devenu veuf, il quitte Lille en 1709, à la suite de la prise de la ville par les armées hollandaises et aux troubles qui s'ensuivent, pour retourner dans sa ville natale à l'abri de la guerre. Il y décède le 29 septembre 1713.De nombreuses œuvres de ce maître flamand sont exposées dans des musées et des édifices religieux à Bruges, Bruxelles, Lille et au Louvre à Paris", 1L }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 2L, "NL", "Nederlands" },
                    { 3L, "EN", "English" }
                });

            migrationBuilder.InsertData(
                table: "ArtistTranslation",
                columns: new[] { "Id", "ArtistId", "Description", "LanguageId" },
                values: new object[,]
                {
                    { 9L, 4L, "Artus Wolffort, également connu sous les noms de Wolffordt ou Wolffaert, né en 1581 à Anvers et mort en 1641 dans la même ville, est un peintre baroque flamand.Peu après sa naissance ses parents déménagent à Dordrecht. Le 29 décembre 1603, il devient un membre des guildes de Saint-Luc mais doit les quitter faute de moyens financiers. En 1615, il devient l'assistant d'Otto van Veen à Anvers, puis de Rubens, qui influence son style et ses compositions.Dès 1617, il bénéficie d'importantes commandes, dont les retables de l’Ascension et l'Assomption de la Vierge de l'église Saint-Paul d'Anvers. Son œuvre est cependant principalement constituée de compositions destinées à des particuliers. Il peint essentiellement des œuvres religieuses, comprenant des scènes de la vie du Christ et des pères de l'Église.Plusieurs de ses tableaux ont fait l'objet de plusieurs versions, de qualité inégale, comme ses séries Les douze apôtres, Les quatre évangélistes et Les quatre Pères de l'Église. On peut en déduire que Wolffordt entretient un atelier. Deux de ses assistants, Pieter van Lint et Pieter van Mol, sont même connus pour avoir réalisé des répliques de ses tableaux et ont été tous deux fortement influencés par le peintre.Le fils d'Artus Wolffordt, Jan Baptist Wolfaerts, est également peintre. L'une de ses filles a épousé le peintre Willem van Herp.", 1L },
                    { 12L, 5L, "Érasme Quellin le Jeune (ou Erasmus Quellinus II, Kwelien, Quellien, Quellincs, Quellingh), né le 19 novembre 1607 à Anvers et mort le 11 novembre 1678 dans cette ville, est un peintre, graveur, dessinateur et concepteur de tapisseries flamand qui travaille dans divers genres, dont la peinture d'histoire, le portrait, les scènes de bataille et peintures animalières. Il est un élève de Pierre Paul Rubens et est l’un des plus proches collaborateurs de Rubens dans les années 1630. Après la mort de Rubens en 1640, il devient l’un des peintres les plus prolifiques et les plus prospères des Pays-Bas méridionaux du xviie siècle.", 1L },
                    { 15L, 6L, "Sir Peter Lely, de son vrai nom Pieter Van der Faes, né le 14 septembre 1618 à Soest en Westphalie, mort le 30 novembre 1680 à Londres, est un peintre d'origine néerlandaise. Il a connu une immense popularité comme portraitiste en Angleterre où il s'établit dans les années 1640. C'était aussi un grand amateur d'art, qui possédait une belle collection de dessins d'artistes.", 1L },
                    { 2L, 1L, "Lucas Achtschellinck (Brussel, gedoopt 16 januari 1626 - aldaar, begraven 12 mei 1699) was een Brussels landschapschilder uit de baroktijd.Achtschellinck werd op 26 oktober 1639 ingeschreven in de Brusselse schildersgilde als leerling van Peter van der Borcht. Men veronderstelt dat hij tussen 1639 en 1657 veel reisde daar hij pas in 1657 gildemeester werd.Achtschellinck werd sterk beïnvloed door Jacques d'Arthois, een leerling uit de Rubensschool. Hij schilderde vooral grote boslandschappen voor kerken en kloosters. Deze landschappen werden door anderen verder afgewerkt met figuren en gebeurtenissen uit de Bijbel. Achtschellinck schilderde ook verscheidene landschappen in de schilderijen van Gaspar de Crayer. Hij vormde samen met Lodewijk de Vadder en Jacques d'Arthois de zogenaamde Zoniënwoudschilders, de leidende groep van Brusselse landschapschilders van dat moment. Hij werd de leraar van onder andere Theobald Michau.", 2L },
                    { 5L, 2L, "Van Oost was de telg van een uitgebreide Brugse schildersfamilie. Na zijn eerste opleiding, waarschijnlijk bij zijn broer Frans van Oost, verbleef hij in Italië van 1621 tot 1628. Vanaf 1651 bekleedde hij de functie van stadsschilder.Zijn oeuvre is sterk beïnvloed door Caravaggio en de Italiaanse meesters, alsook door Vlaamse kunstenaars als Rubens, Antoon van Dyck en Gaspard de Crayer. Zijn voornaamste werken zijn portretten en religieuze taferelen. Ze worden gekenmerkt door licht-donker-effecten, de realistische voorstelling van de figuren, de persoonlijke kleuren en de stillevenelementen. Boven het hoogaltaar van de Sint-Agathakerk te Landskouter is zijn De verrijzenis van Jezus te zien.Jacob van Oost was getrouwd met Jacquemine van Overdille. Ze kregen een zoon, Martinus. Hij hertrouwde met Maria Tollenaere en ze kregen zes kinderen. Zijn zonen Jacob II van Oost (1639-1713) en Willem van Oost (1651-1686) werden eveneens kunstschilder.Er werd een gedenkplaat aangebracht aan zijn woning, Wapenmakersstraat 3 in Brugge. Brugge heeft ook een Jakob van Ooststraat.", 2L },
                    { 10L, 4L, "Artus Wolffort (1581-1641), ook Wolffaert genoemd, was een Brabants kunstschilder uit Antwerpen. Zijn werken behoren tot de Vlaamse barokschilderkunst.Hij studeerde eerst in Dordrecht waar zijn familie in 1581 naar was uitgeweken. Bij zijn terugkeer naar Antwerpen rond 1615 studeerde hij bij Otto van Veen en Peter Paul Rubens. Rubens beïnvloedde hem qua compositie en stijl.Wolffort schilderde vooral scènes uit het leven van Christus en de kerkvaders. Pieter van Mol en Pieter van Lint waren twee van zijn leerlingen. Het schilderij Aanbidding van de koningen (zie foto) was een opdracht van het kleermakersambacht van Antwerpen. Het toont de figuren in kostbare gewaden, exuberante hoofddeksels en allerlei dure stoffen. Over de toeschrijving van het schilderij was men het lang oneens. Het kwam op naam van Deodaat del Monte, Pieter van Mol en Pieter van Lint. Recent stilistisch onderzoek schrijft het overtuigend toe aan Wolffort.Het gemeentehuis van Aartselaar (ten zuiden van Antwerpen) wordt weliswaar 'Wolffaertshof' genoemd, doch was niet de residentie van barokschilder Wolffort.", 2L },
                    { 13L, 5L, "Erasmus Quellinus II (Antwerpen, 19 november 1607 - aldaar, 7 november 1678), ook genoemd Erasmus de Jonge, was een bekende Brabantse kunstschilder en kopergraveur uit de Antwerpse kunstenaarsfamilie Quellinus. Hij was de zoon van de beeldhouwer Erasmus Quellinus I. Hij werkte vaak samen met Daniël Seghers. Een van hun gezamenlijke werken hangt in de Pinacoteca Nazionale te Bologna.Erasmus werd geboren in een familie van kunstenaars, hoofdzakelijk beeldhouwers, maar koos als beroep voor het schilderen. Hij had het geluk om één van Peter Paul Rubens' vele leerlingen te worden en vervolgens een van zijn naaste medewerkers. Na zijn opleiding bij Rubens in de jaren 1633 - 1634 werd Erasmus Quellinus II meesterschilder in het Antwerpse Sint-Lucasgilde. Hij was zeer erudiet wat zich manifesteerde in zijn verzorgde stijl en zijn veelzijdige activiteiten. Zijn grondige kennis van de mythologie en filosofie kwam tot uiting in vele van zijn werken. Zijn gevarieerde productie droeg veel bij aan de artistieke uitstraling van Antwerpen.", 2L },
                    { 16L, 6L, "Peter Lely (Soest (Duitsland), 14 september 1618 – Londen, 30 november 1680) was een Engelse kunstschilder van Nederlandse oorsprong. Hij was de populairste portretschilder in Engeland vanaf ongeveer 1640 tot aan zijn dood. Hij was ook kunstverzamelaar en bezat vooral veel tekeningen van andere kunstenaars.Lely werd geboren als Pieter van der Faes uit Nederlandse ouders in Soest in Westfalen, waar zijn vader een ambtenaar was in dienst van het leger van de keurvorst van Brandenburg. Lely studeerde schilderkunst in Haarlem, waar hij mogelijk bij Pieter de Grebber in de leer is geweest. Hij werd een meester van het Sint-Lucasgilde in Haarlem in 1637. Hij was bekend onder de achternaam 'Lely' (nu en dan gespeld als Lilly) vanwege een lelie op de gevel van het huis waar zijn vader in Den Haag geboren was. Hij arriveerde in Londen rond 1641.", 2L },
                    { 3L, 1L, "Lucas Achtschellinck baptized 16 January 1626 – buried 12 May 1699), was a Flemish landscape painter. He is counted among the landscape painters active in Brussels referred to as the School of Painters of the Sonian Forest who all shared an interest in depicting scenes set in the Sonian Forest, which is located near Brussels.He was born in Brussels and was possibly the grandson of the landscape painter Lukas Achtschelling. He was registered in the Brussels Guild of Saint Luke on 26 October 1639 as a pupil of a Pieter van der Borcht. The 17th century Flemish biographer Cornelis de Bie mentioned that Lucas Achtschellinck also studied with the Brussels landscapist Lodewijk de Vadder but this is not confirmed by Guild records. However, stylistically the two artists are quite close.Achtschellinck likely travelled abroad after completing his apprenticeship since he only became a master in the Brussels guild in 1657. On 13 March 1674 he married Anna Parys. He remained active in Brussels and in 1687 he was the deacon of the Brussels guild. He was successfully and employed 8 pupils including Théobald Michau between 1659 and 1686.He died in Brussels.", 3L },
                    { 6L, 2L, "Jacob van Oost or Jacob van Oost the Elder (1603–1671) was a Flemish painter of history paintings and portraits. He was the most important painter of Bruges in the 17th century through his portraits of members of the local bourgeois and his many altarpieces made in the spirit of the Counter Reformation. He also created genre paintings of musicians and card players for the open market.", 3L },
                    { 8L, 3L, "Jacob van Oost the Younger (1639, in Bruges – 1713, in Bruges), was a Flemish Baroque painter.According to the Rijksbureau voor Kunsthistorische Documentatie, he was a pupil of his father Jacob sr. and brother to the painter Willem. He is known for portraits and genre works.", 3L },
                    { 11L, 4L, "Artus Wolffort, Artus Wolffaert or Artus Wolffaerts[1] (1581–1641) was a Flemish painter known mainly for his history paintings depicting religious and mythological scenes.Artus Wolffort was born in Antwerp and moved with his parents to Dordrecht in the year of his birth. He trained as a painter in Dordrecht where he joined the local Guild of Saint Luke in 1603. He returned to Antwerp around 1615 where he worked as an assistant in the studio of Otto van Veen, one of the teachers of Peter Paul Rubens.[3] During this period he lived in the house of van Veen.[4] He became a member of the Antwerp Guild of Saint Luke in 1617.He married Maria Wandelaer on 8 September 1619. Their son Johannes Artusz (better known as Jan Baptist Wolfaerts) was born in November 1625 and later became a painter.[2] Artus Wolffort likely operated a workshop in Antwerp, which produced various copies of his works.[3] His pupils Pieter van Lint and Pieter van Mol worked for a while as copyists in his workshop.[4]Artus Wolffort was one of the artists who worked on the decorations for the Joyous Entry into Antwerp of the new governor of the Habsburg Netherlands Cardinal-Infante Ferdinand in 1635. Rubens was in overall charge of this project for which Wolffort made decorative paintings after designs by Rubens.[6]His pupils included his son Jan Baptist Wolfaerts, Pieter van Lint, Pieter van Mol and Lucas Smout the Elder. He died in Antwerp.[2]", 3L },
                    { 14L, 5L, "Erasmus Quellinus the Younger and Erasmus Quellinus II (1607–1678) was a Flemish painter, engraver, draughtsman and tapestry designer who worked in various genres including history, portrait, battle and animal paintings. He was a pupil of Peter Paul Rubens and was one of the closest collaborators of Rubens in the 1630s. Following Rubens’ death in 1640 he became one of the most prolific and successful painters in Flanders.", 3L },
                    { 17L, 6L, "Sir Peter Lely (14 September 1618 – 7 December 1680)[1][2] was a painter of Dutch origin whose career was nearly all spent in England, where he became the dominant portrait painter to the court.Lely was born Pieter van der Faes to Dutch parents in Soest in Westphalia,[3] where his father was an officer serving in the armed forces of the Elector of Brandenburg. Lely studied painting in Haarlem, where he may have been apprenticed to Pieter de Grebber. He became a master of the Guild of Saint Luke in Haarlem in 1637. He is reputed to have adopted the surname 'Lely' (also occasionally spelled Lilly) from a heraldic lily on the gable of the house where his father was born in The Hague.He arrived in London in around 1643,[4] His early English paintings, mainly mythological or religious scenes, or portraits set in a pastoral landscape, show influences from Anthony van Dyck and the Dutch baroque. Lely's portraits were well received, and he succeeded Anthony van Dyck (who had died in 1641) as the most fashionable portrait artist in England. He became a freeman of the Painter-Stainers' Company in 1647 and was portrait artist to Charles I. His talent ensured that his career was not interrupted by Charles's execution, and he served Oliver Cromwell, whom he painted 'warts and all', and Richard Cromwell. In the years around 1650 the poet Sir Richard Lovelace wrote two poems about Lely – Peinture and 'See what a clouded majesty ...'", 3L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
