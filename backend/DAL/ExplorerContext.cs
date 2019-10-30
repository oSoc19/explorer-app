using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.DAL
{
    public class ExplorerContext : DbContext
    {
        public DbSet<Painting> Painting { get; set; }
        public DbSet<Artist> Artist {get;set;}
        public DbSet<ArtistTranslation> ArtistTranslation {get;set;}
        public DbSet<Language> Language {get;set;}
        public DbSet<PaintingTranslation> PaintingTranslation {get;set;}
        public DbSet<PaintingAudio> PaintingAudio {get;set;}
        public DbSet<PaintingStory> PaintingStory {get;set;}
        public DbSet<Technique> Technique {get;set;}
        public DbSet<Movement> Movement {get;set;}
        public DbSet<Use> Use {get;set;}
        public DbSet<Building> Building { get; set; }
        public DbSet<BuildingStory> BuildingStory {get;set;}
        public ExplorerContext(DbContextOptions<ExplorerContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>()
            .HasData(
                new Language
                {
                    Id = 1,
                    Code = "FR",
                    Name = "Français"
                },
                new Language
                {
                    Id = 2,
                    Code = "NL",
                    Name = "Nederlands"
                },
                new Language
                {
                    Id = 3,
                    Code = "EN",
                    Name = "English"
                },
                new Language
                {
                    Id = 4,
                    Code = "DE",
                    Name = "Deutsch"
                },
                new Language
                {
                    Id = 5,
                    Code = "ES",
                    Name = "Español"
                }
            );

            modelBuilder.Entity<Artist>()
            .HasData(
                new Artist
                {
                    Id = 1,
                    FirstName = "Lucas",
                    LastName = "Achtschellinck",
                    Nationality = "Belgian",
                    Birthdate = "1626-01-16",
                    Deathdate = "1699-05-12"
                },
                new Artist
                {
                    Id = 2,
                    FirstName = "Jacob I",
                    LastName = "van Oost",
                    Nationality = "Belgian",
                    Birthdate = "1603-07-01",
                    Deathdate = "1671-03-03"
                },
                new Artist
                {
                    Id = 3,
                    FirstName = "Jacob II",
                    LastName = "van Oost",
                    Nationality = "Belgian",
                    Birthdate = "1637",
                    Deathdate = "1713-09-29"
                },
                new Artist
                {
                    Id = 4,
                    FirstName = "Artus",
                    LastName = "Wolfordt",
                    Nationality = "Spanish Netherlands",
                    Birthdate = "1581",
                    Deathdate = "1641"
                },
                new Artist
                {
                    Id = 5,
                    FirstName = "Erasmus II",
                    LastName = "Quellinus",
                    Nationality = "Spanish Netherlands",
                    Birthdate = "1607-11-19",
                    Deathdate = "1678-11-11"
                },
                new Artist
                {
                    Id = 6,
                    FirstName = "Peter",
                    LastName = "Lely",
                    Nationality = "Netherlands",
                    Birthdate = "1618-09-14",
                    Deathdate = "1680-11-30"
                }
            );

            modelBuilder.Entity<ArtistTranslation>()
            .HasData(
                new ArtistTranslation
                {
                    Id = 1,
                    ArtistId = 1,
                    LanguageId = 1,
                    Description = "Lucas Achtschellinck est un peintre brabançon baroque spécialisé dans la peinture de paysages."
                        + "Il est né à Bruxelles en 1626, fut baptisé le 16 janvier de la même année1 . "
                        + "Il entre dans la guilde des peintres le 29 octobre 1639 comme élève de Pieter van der Borcht2." 
                        + "En 1655, à la mort de Lodewijk de Vadder, il pose sa candidature pour devenir cartonnier privilégié de la ville de Bruxelles3. "
                        + "Un voyage à l'étranger peut être envisagé, puisqu'il n'est admis maître qu'en 16574. En 1659, il reçoit 120 florins pour un tableau exécuté à Sainte Gudule5. "
                        + "En 1660 Corneille de Bie publie le Gulden Cabinet6 dans lequel il décrit le style de Lucas Achtschellinck. En 1662, il reçoit 120 florins pour un tableau exécuté à Sainte Gudule7. "
                        + "En 1671, il collabore avec le peintre malinois Lucas Franchois et est payé pour cela en 16738. Le 13 mai 1674, il épouse Anna Parys à l'église du Finistère à Bruxelles9. " 
                        + "En 1687, il est doyen représentant les peintres à la corporation et ce jusqu'en 168910. "
                        + "En 1689, il est exonéré en tant que cartonnier11 En 1681, il est « reconnu » c'est-à-dire : exempté de certaines charges du métier à la condition qu'il ne se livre qu'à des travaux artistiques12. "
                        + "Achtschellick est influencé par le style de Rubens dans la façon de peindre les paysages. Il est également fortement influencé par Jacques d'Arthois. Il peint des paysages forestiers, des églises et des cloîtres, ainsi que des scènes avec des personnages inspirées de la Bible. Achtschellinck est connu pour avoir peint les paysages des œuvres majeures du peintre flamand Gaspard de Crayer (1582-1669)."
                        + "Lucas Achtschellinck est souvent associé à son professeur de peinture Lodewijk de Vadder (1605-1655)13, ainsi qu'à Jacques d'Arthois (1603-1686). En effet, on les appelle les peintres de la Forêt de Soignes.",
                    SourceLink = "https://fr.wikipedia.org/wiki/Lucas_Achtschellinck"
                
                },
                new ArtistTranslation
                {
                    Id = 2,
                    ArtistId = 1,
                    LanguageId = 2,
                    Description = "Lucas Achtschellinck (Brussel, gedoopt 16 januari 1626 - aldaar, begraven 12 mei 1699) was een Brussels landschapschilder uit de baroktijd.Achtschellinck werd op 26 oktober 1639 ingeschreven in de Brusselse schildersgilde als leerling van Peter van der Borcht. Men veronderstelt dat hij tussen 1639 en 1657 veel reisde daar hij pas in 1657 gildemeester werd."
                        +"Achtschellinck werd sterk beïnvloed door Jacques d'Arthois, een leerling uit de Rubensschool. Hij schilderde vooral grote boslandschappen voor kerken en kloosters. Deze landschappen werden door anderen verder afgewerkt met figuren en gebeurtenissen uit de Bijbel. Achtschellinck schilderde ook verscheidene landschappen in de schilderijen van Gaspar de Crayer. Hij vormde samen met Lodewijk de Vadder en Jacques d'Arthois de zogenaamde Zoniënwoudschilders, de leidende groep van Brusselse landschapschilders van dat moment. Hij werd de leraar van onder andere Theobald Michau.",
                    SourceLink = "https://nl.wikipedia.org/wiki/Lucas_Achtschellinck"
                },
                new ArtistTranslation
                {
                    Id = 3,
                    ArtistId = 1,
                    LanguageId = 3,
                    Description = "Lucas Achtschellinck baptized 16 January 1626 – buried 12 May 1699), was a Flemish landscape painter. He is counted among the landscape painters active in Brussels referred to as the School of Painters of the Sonian Forest who all shared an interest in depicting scenes set in the Sonian Forest, which is located near Brussels."
                        + "He was born in Brussels and was possibly the grandson of the landscape painter Lukas Achtschelling. He was registered in the Brussels Guild of Saint Luke on 26 October 1639 as a pupil of a Pieter van der Borcht. The 17th century Flemish biographer Cornelis de Bie mentioned that Lucas Achtschellinck also studied with the Brussels landscapist Lodewijk de Vadder but this is not confirmed by Guild records. However, stylistically the two artists are quite close."
                        + "Achtschellinck likely travelled abroad after completing his apprenticeship since he only became a master in the Brussels guild in 1657. On 13 March 1674 he married Anna Parys. He remained active in Brussels and in 1687 he was the deacon of the Brussels guild. He was successfully and employed 8 pupils including Théobald Michau between 1659 and 1686."
                        + "He died in Brussels.",
                    SourceLink = "https://en.wikipedia.org/wiki/Lucas_Achtschellinck"
                },
                new ArtistTranslation
                {
                    Id = 4,
                    ArtistId = 2,
                    LanguageId = 1,
                    Description = "Jacob van Oost dit le Vieux, également connu sous le nom de Jacques Van Oost le Vieux, né le 1er juillet 1603 à Bruges où il est mort entre le 1er et le 3 mars 1671, est un peintre flamand. Il est considéré comme étant le principal peintre brugeois du xviie siècle.",
                    SourceLink = "https://fr.wikipedia.org/wiki/Jacob_van_Oost_le_Vieux"
                },
                new ArtistTranslation
                {
                    Id = 5,
                    ArtistId = 2,
                    LanguageId = 3,
                    Description = "Jacob van Oost I is a Bruges painter and draftsman and probably a student of his brother Frans van Oost (died 1625). Van Oost is viewed as the most important 17th-century painter from Bruges. He makes portraits for the Bruges bourgeois and history paintings, but is primarily known for the altarpieces that he makes in the spirit of the Counter Reformation. The painter is strongly influenced by the Caravaggio effects that he learns in Italy. From the work of Caravaggio (1571-1610) he takes over the chiaroscuro as well as the non-idealised figures."
                        +"After this, an evolution follows towards more monumental figures and a rather classicist treatment that is in line with the work of Annibale Carracci (1560-1690) and Domenichino (1581-1641)."
                        +"After about 1650, a greater emotionality surfaces in his work, together with the dramatic spatial effects and a palette that is related to Venetian art. In this period, van Oost is influenced by Federico Barocci (1528-35-1612), Correggio (ca. 1489-1534) and Anthony van Dyck (1599-1641). A masterpiece in his oeuvre is Portrait of a Bruges Family (Groeninge Museum, Bruges).",
                    SourceLink = "https://vkc-barok-prod.inuits.eu/en/artist/jacob-van-oost-i/?utm_source=learnmore&utm_medium=app&utm_campaign=meertaligheid"
                },
                new ArtistTranslation
                {
                    Id = 6,
                    ArtistId = 2,
                    LanguageId = 2,
                    Description = "Jacob van Oost I is een Brugse schilder en tekenaar, en waarschijnlijk een leerling van zijn broer Frans van Oost (gestorven 1625). Van Oost wordt beschouwd als de belangrijkste zeventiende-eeuwse schilder van Brugge. Hij vervaardigt portretten voor de Brugse burgerij en historiestukken, maar staat vooral bekend om de altaarstukken die hij maakt in de geest van de contrareformatie. De schilder wordt sterk beïnvloed door het caravaggisme dat hij in Italië leert kennen. Het clair-obscur, maar ook de niet-geïdealiseerde figuren neemt hij uit het werk van Caravaggio (1571-1610) over."
                        +"Daarna volgt een evolutie naar meer monumentale figuren en een eerder classicistische behandeling die aansluit bij het werk van Annibale Carracci (1560-1690) en Domenichino (1581-1641)."
                        +"Na circa 1650 duikt een grotere emotionaliteit in zijn werk op, samen met dramatische ruimtelijke effecten en een aan de Venetiaanse kunst verwant coloriet. Van Oost wordt in deze periode beïnvloed door Federico Barocci (1528-35-1612), Correggio (Circa 1489-1534) en Anthony van Dyck (1599-1641). Een meesterwerk in zijn oeuvre is Portret van een Brugse familie (Groeningemuseum, Brugge).",
                    SourceLink = "https://vkc-barok-prod.inuits.eu/nl/kunstenaar/jacob-van-oost-i/?utm_source=learnmore&utm_medium=app&utm_campaign=meertaligheid"
                },
                new ArtistTranslation
                {
                    Id = 7,
                    ArtistId = 3,
                    LanguageId = 1,
                    Description = "Jacob van Oost dit le Jeune, né en 1637 et décédé en 1713 à Bruges, connu aussi comme Jacques Van Oost le Jeune, est un peintre baroque flamand."
                        +"Élève de son père, Jacob van Oost dit le vieux, à Bruges, il poursuit sa formation à Paris puis Rome. Il s'installe à Lille en Flandre en 1668. Il est l'un des peintres les plus renommés, avec Arnould de Vuez, à œuvrer à Lille durant ces années."
                        +"Peintre de portraits mais surtout de sujets religieux, il couvre les églises et couvents de la ville de ses œuvres. Il épouse une lilloise, Marie Bourgeois, en 1670. De cette union naissent plusieurs enfants dont Dominique van Oost (1677-1738), peintre comme son père."
                        +"Devenu veuf, il quitte Lille en 1709, à la suite de la prise de la ville par les armées hollandaises et aux troubles qui s'ensuivent, pour retourner dans sa ville natale à l'abri de la guerre. Il y décède le 29 septembre 1713."
                        +"De nombreuses œuvres de ce maître flamand sont exposées dans des musées et des édifices religieux à Bruges, Bruxelles, Lille et au Louvre à Paris",
                    SourceLink = "https://fr.wikipedia.org/wiki/Jacob_van_Oost_le_Jeune"
                },
                new ArtistTranslation
                {
                    Id = 8,
                    ArtistId = 3,
                    LanguageId = 3,
                    Description = "Jacob van Oost the Younger (1639, in Bruges – 1713, in Bruges), was a Flemish Baroque painter."
                        +"According to the Rijksbureau voor Kunsthistorische Documentatie, he was a pupil of his father Jacob sr. and brother to the painter Willem. He is known for portraits and genre works.",
                    SourceLink = "https://en.wikipedia.org/wiki/Jacob_van_Oost_the_Younger"
                },
                new ArtistTranslation
                {
                    Id = 9,
                    ArtistId = 4,
                    LanguageId = 1,
                    Description = "Artus Wolffort, également connu sous les noms de Wolffordt ou Wolffaert, né en 1581 à Anvers et mort en 1641 dans la même ville, est un peintre baroque flamand."
                        +"Peu après sa naissance ses parents déménagent à Dordrecht. Le 29 décembre 1603, il devient un membre des guildes de Saint-Luc mais doit les quitter faute de moyens financiers. En 1615, il devient l'assistant d'Otto van Veen à Anvers, puis de Rubens, qui influence son style et ses compositions."
                        +"Dès 1617, il bénéficie d'importantes commandes, dont les retables de l’Ascension et l'Assomption de la Vierge de l'église Saint-Paul d'Anvers. Son œuvre est cependant principalement constituée de compositions destinées à des particuliers. Il peint essentiellement des œuvres religieuses, comprenant des scènes de la vie du Christ et des pères de l'Église."
                        +"Plusieurs de ses tableaux ont fait l'objet de plusieurs versions, de qualité inégale, comme ses séries Les douze apôtres, Les quatre évangélistes et Les quatre Pères de l'Église. On peut en déduire que Wolffordt entretient un atelier. Deux de ses assistants, Pieter van Lint et Pieter van Mol, sont même connus pour avoir réalisé des répliques de ses tableaux et ont été tous deux fortement influencés par le peintre."
                        +"Le fils d'Artus Wolffordt, Jan Baptist Wolfaerts, est également peintre. L'une de ses filles a épousé le peintre Willem van Herp.",
                    SourceLink = "https://fr.wikipedia.org/wiki/Artus_Wolffort"
                },
                new ArtistTranslation
                {
                    Id = 10,
                    ArtistId = 4,
                    LanguageId = 2,
                    Description = "Artus Wolffort (1581-1641), ook Wolffaert genoemd, was een Brabants kunstschilder uit Antwerpen. Zijn werken behoren tot de Vlaamse barokschilderkunst."
                        +"Hij studeerde eerst in Dordrecht waar zijn familie in 1581 naar was uitgeweken. Bij zijn terugkeer naar Antwerpen rond 1615 studeerde hij bij Otto van Veen en Peter Paul Rubens. Rubens beïnvloedde hem qua compositie en stijl."
                        +"Wolffort schilderde vooral scènes uit het leven van Christus en de kerkvaders. Pieter van Mol en Pieter van Lint waren twee van zijn leerlingen. Het schilderij Aanbidding van de koningen (zie foto) was een opdracht van het kleermakersambacht van Antwerpen. Het toont de figuren in kostbare gewaden, exuberante hoofddeksels en allerlei dure stoffen. Over de toeschrijving van het schilderij was men het lang oneens. Het kwam op naam van Deodaat del Monte, Pieter van Mol en Pieter van Lint. Recent stilistisch onderzoek schrijft het overtuigend toe aan Wolffort."
                        +"Het gemeentehuis van Aartselaar (ten zuiden van Antwerpen) wordt weliswaar 'Wolffaertshof' genoemd, doch was niet de residentie van barokschilder Wolffort.",
                    SourceLink = "https://nl.wikipedia.org/wiki/Artus_Wolffort"
                },
                new ArtistTranslation
                {
                    Id = 11,
                    ArtistId = 4,
                    LanguageId = 3,
                    Description = "Artus Wolffort, Artus Wolffaert or Artus Wolffaerts[1] (1581–1641) was a Flemish painter known mainly for his history paintings depicting religious and mythological scenes."
                        +"Artus Wolffort was born in Antwerp and moved with his parents to Dordrecht in the year of his birth. He trained as a painter in Dordrecht where he joined the local Guild of Saint Luke in 1603. He returned to Antwerp around 1615 where he worked as an assistant in the studio of Otto van Veen, one of the teachers of Peter Paul Rubens.[3] During this period he lived in the house of van Veen.[4] He became a member of the Antwerp Guild of Saint Luke in 1617."
                        +"He married Maria Wandelaer on 8 September 1619. Their son Johannes Artusz (better known as Jan Baptist Wolfaerts) was born in November 1625 and later became a painter. Artus Wolffort likely operated a workshop in Antwerp, which produced various copies of his works.[3] His pupils Pieter van Lint and Pieter van Mol worked for a while as copyists in his workshop.[4]"
                        +"Artus Wolffort was one of the artists who worked on the decorations for the Joyous Entry into Antwerp of the new governor of the Habsburg Netherlands Cardinal-Infante Ferdinand in 1635. Rubens was in overall charge of this project for which Wolffort made decorative paintings after designs by Rubens.[6]"
                        +"His pupils included his son Jan Baptist Wolfaerts, Pieter van Lint, Pieter van Mol and Lucas Smout the Elder. He died in Antwerp.",
                    SourceLink = "https://en.wikipedia.org/wiki/Artus_Wolffort"
                },
                new ArtistTranslation
                {
                    Id = 12,
                    ArtistId = 5,
                    LanguageId = 1,
                    Description = "Érasme Quellin le Jeune (ou Erasmus Quellinus II, Kwelien, Quellien, Quellincs, Quellingh), né le 19 novembre 1607 à Anvers et mort le 11 novembre 1678 dans cette ville, est un peintre, graveur, dessinateur et concepteur de tapisseries flamand qui travaille dans divers genres, dont la peinture d'histoire, le portrait, les scènes de bataille et peintures animalières. Il est un élève de Pierre Paul Rubens et est l’un des plus proches collaborateurs de Rubens dans les années 1630. Après la mort de Rubens en 1640, il devient l’un des peintres les plus prolifiques et les plus prospères des Pays-Bas méridionaux du xviie siècle.",
                    SourceLink = "https://fr.wikipedia.org/wiki/%C3%89rasme_Quellin_le_Jeune"
                },
                new ArtistTranslation
                {
                    Id = 13,
                    ArtistId = 5,
                    LanguageId = 2,
                    Description = "Erasmus Quellinus II is een Antwerpse schilder, tekenaar, graveur en ontwerper van tapijten. Hij stamt uit een kunstenaarsfamilie. Zijn vader is de beeldhouwer Erasmus Quellinus I (1584-1640). Hij is de broer van beeldhouwer Artus Quellinus I (1609-1668) en de graveur Hubertus Quellinus (1619-1687). Quellinus is de vader en de leermeester van de schilder Jan Erasmus Quellinus (1634-1715)."
                        +"Quellinus is een pictor doctus en in die zin vergelijkbaar met Peter Paul Rubens met wie hij vaak samenwerkt in de jaren 1630 en door wie hij beïnvloed wordt. Beiden bezitten een uitgebreide bibliotheek en kunstverzameling. In de geest van het humanisme schrijft Quellinus het filosofisch traktaat Philosophiae, dat niet overgeleverd is. De kunstenaar zou ook een academische graad in de filosofie behaald hebben."
                        +"Quellinus is verantwoordelijk voor het ontwerp en deels voor de uitvoering van belangrijke decoratieve programma's in het kader van officiële huldigingen in Antwerpen. De kunstenaar werkt ook samen met stillevenspecialisten, onder wie de bloemenschilder Daniël Seghers (1590-1661)."
                        +"Erasmus Quellinus II vervaardigt vele altaarstukken die in de invloedssfeer van de contrareformatie moeten geplaatst worden, maar ook historiestukken en mythologische en allegorische schilderijen. Niettegenstaande de grote invloed van Rubens ontwikkelt Quellinus vroeg in zijn carrière een eigen stijl met sterk door het licht gemodelleerde vormen. Het is mogelijk dat Quellinus die caravaggistische aspecten leert kennen via het werk van Theodoor Rombouts (1597-1637) en Gerard Seghers (1591-1651)."
                        +"Vanaf circa 1640 worden zijn figuren sculpturaal en driedimensionaal, en lijken op geschilderde beelden. Hiermee krijgt zijn werk aansluiting bij het oeuvre van Annibale Carracci (1560-1690), of de classicistische tak van de barok. Quellinus reist nooit naar Italië, maar leert het Romeinse classicisme via zijn broer en beeldhouwer Artus Quellinus I, die een tijd in Rome verblijft, kennen."
                        +"Na circa 1650 evolueert het barokke classicisme naar een eerder rigide academisme. Quellinus ontwikkelt een voorliefde voor breed uitgesponnen architecturale achtergrondsettings, zoals in werken als Salomon en de Koningin van Sheba. (Sammlungen des Fürsten von Liechtenstein, Vaduz) of Laat de kinderen tot mij komen. (Koninklijke Musea voor Schone Kunsten van België, Brussel)"
                        +"Erasmus Quellinus II sterft als een rijk en beroemd kunstenaar.",
                    SourceLink = "https://vkc-barok-prod.inuits.eu/nl/kunstenaar/erasmus-quellinus-ii/?utm_source=learnmore&utm_medium=app&utm_campaign=meertaligheid"
                },
                new ArtistTranslation
                {
                    Id = 14,
                    ArtistId = 5,
                    LanguageId = 3,
                    Description = "Erasmus Quellinus II is an Antwerp painter, draftsman, engraver and tapestry designer. He comes from an artistic family. His father is the sculptor Erasmus Quellinus I (1584-1640). He is the brother of the sculptor Artus Quellinus I (1609-1668) and the engraver Hubertus Quellinus (1619-1687). Quellinus is the father and master instructor of the painter Jan Erasmus Quellinus (1634-1715)."
                        +"Quellinus is a pictor doctus and in that sense is comparable to Peter Paul Rubens with whom he often collaborated in the 1630's and by whom he was influenced. Both possess an extensive library and art collection. In the spirit of Humanism, Quellinus writes the philosophical treatise, Philosophae, which has not survived. The artist also would have obtained an academic degree in Philosophy."
                        +"Quellinus is responsible for the design and in part for the execution of important decorative programmes in the context of official honourings in Antwerp. The artist also worked together with still-life specialists, amongst whom is the floral painter Daniël Seghers (1590-1661)."
                        +"Erasmus Quellinus II made many altarpieces, which need to be placed within the sphere of influence of the Counter Reformation, but also history pieces and mythological and allegorical paintings. The significant influence of Rubens notwithstanding, Quellinus develops early in his career his own style with forms strongly modeled by the light. It is possible that Quellinus learned the Caravaggio-esque aspects via the work of Theodoor Rombouts (1597-1637) and Gerard Seghers (1591-1651)."
                        +"Starting about 1640, his figures become sculptural and three-dimensional and resemble painted sculptures. With this, his work is connected with the oeuvre of Annibale Carracci (1560-1690), or the Classicist branch of the Baroque. Quellinus travels to Italy, but learns about Roman Classicism via his brother and sculptor Artus Quellinus I, who spent some time in Rome."
                        +"After about 1650, the Baroque Classicism evolves towards a rather rigid academicism. Quellinus develops a preference for broad, expansive architectural background settings, such as in works like Solomon and the Queen of Sheba, (Sammlungen des Fürsten von Liechtenstein, Vaduz), or Suffer the little Children to Come unto Me (Royal Museums of Fine Arts of Belgium, Brussels)."
                        +"Erasmus Quellinus II dies as a rich and famous artist.",
                    SourceLink = "https://vkc-barok-prod.inuits.eu/en/artist/erasmus-quellinus-ii/?utm_source=learnmore&utm_medium=app&utm_campaign=meertaligheid"
                },
                new ArtistTranslation
                {
                    Id = 15,
                    ArtistId = 6,
                    LanguageId = 1,
                    Description = "Sir Peter Lely, de son vrai nom Pieter Van der Faes, né le 14 septembre 1618 à Soest en Westphalie, mort le 30 novembre 1680 à Londres, est un peintre d'origine néerlandaise. Il a connu une immense popularité comme portraitiste en Angleterre où il s'établit dans les années 1640. C'était aussi un grand amateur d'art, qui possédait une belle collection de dessins d'artistes.",
                    SourceLink = "https://fr.wikipedia.org/wiki/Peter_Lely"
                },
                new ArtistTranslation
                {
                    Id = 16,
                    ArtistId = 6,
                    LanguageId = 2,
                    Description = "Peter Lely (Soest (Duitsland), 14 september 1618 – Londen, 30 november 1680) was een Engelse kunstschilder van Nederlandse oorsprong. Hij was de populairste portretschilder in Engeland vanaf ongeveer 1640 tot aan zijn dood. Hij was ook kunstverzamelaar en bezat vooral veel tekeningen van andere kunstenaars."
                        +"Lely werd geboren als Pieter van der Faes uit Nederlandse ouders in Soest in Westfalen, waar zijn vader een ambtenaar was in dienst van het leger van de keurvorst van Brandenburg. Lely studeerde schilderkunst in Haarlem, waar hij mogelijk bij Pieter de Grebber in de leer is geweest. Hij werd een meester van het Sint-Lucasgilde in Haarlem in 1637. Hij was bekend onder de achternaam 'Lely' (nu en dan gespeld als Lilly) vanwege een lelie op de gevel van het huis waar zijn vader in Den Haag geboren was. Hij arriveerde in Londen rond 1641.",
                    SourceLink = "https://nl.wikipedia.org/wiki/Peter_Lely"
                },
                new ArtistTranslation
                {
                    Id = 17,
                    ArtistId = 6,
                    LanguageId = 3,
                    Description = "Sir Peter Lely (14 September 1618 – 7 December 1680)[1][2] was a painter of Dutch origin whose career was nearly all spent in England, where he became the dominant portrait painter to the court."
                        +"Lely was born Pieter van der Faes to Dutch parents in Soest in Westphalia,[3] where his father was an officer serving in the armed forces of the Elector of Brandenburg. Lely studied painting in Haarlem, where he may have been apprenticed to Pieter de Grebber. He became a master of the Guild of Saint Luke in Haarlem in 1637. He is reputed to have adopted the surname 'Lely' (also occasionally spelled Lilly) from a heraldic lily on the gable of the house where his father was born in The Hague."
                        +"He arrived in London in around 1643,[4] His early English paintings, mainly mythological or religious scenes, or portraits set in a pastoral landscape, show influences from Anthony van Dyck and the Dutch baroque. Lely's portraits were well received, and he succeeded Anthony van Dyck (who had died in 1641) as the most fashionable portrait artist in England. He became a freeman of the Painter-Stainers' Company in 1647 and was portrait artist to Charles I. His talent ensured that his career was not interrupted by Charles's execution, and he served Oliver Cromwell, whom he painted 'warts and all', and Richard Cromwell. In the years around 1650 the poet Sir Richard Lovelace wrote two poems about Lely – Peinture and 'See what a clouded majesty ...'",
                    SourceLink = "https://en.wikipedia.org/wiki/Peter_Lely"
                },
                new ArtistTranslation
                {
                    Id = 18,
                    ArtistId = 1,
                    LanguageId = 4,
                    Description = "Lucas Achtschellinck (* 16. Januar 1626 in Brüssel; † 12. Mai 1699) war ein flämischer Landschaftsmaler."
                        +"1639 wurde Achtschellinck als Schüler von Peter van der Borcht in die Brüsseler Malergilde aufgenommen und wurde stark beeinflusst von Jacques d’Arthois. 1657 wurde er als Freimeister in Brüssel zugelassen. Seine Bilder zeichnen sich aus durch Großräumigkeit der Bilder, ein kräftiges Grün und eine etwas derbe Formanschauung."
                        +"Am 13. März 1674 heiratete er Anna Parys.",
                    SourceLink = "https://de.wikipedia.org/wiki/Lucas_Achtschellinck"
                },
                new ArtistTranslation
                {
                    Id = 19,
                    ArtistId = 2,
                    LanguageId = 4,
                    Description = "Jakob van Oost der Ältere (* um 1600 in Brügge; † um 1671 in Brügge) war ein flämischer Maler des Barocks in Brügge. Zu seinem Œuvre zählen Historien- und Porträtgemälde."
                        +"Am 19. Januar 1619 wurde Jakob van Oost als Lehrling seines Bruders Franz van Oost (1618 Freimeister in Brügge; † um 1625) in der Brügger Malergilde aufgelistet. Zu seinem Frühwerk zählen Kopien der Gemälde Jan van Eycksund Peter Paul Rubens, die 1857 teils als Originale galten. Im Jahr 1621 erfolgte seine Ernennung zum Freimeister. Zeitgemäß studierte er in den 20er Jahren in Italien die von Caravaggio beeinflussten Werke Hannibal/Annibale Carraccis. Nach seiner Rückkehr wurde er ab 1630 ein gefragter Auftragskünstler für Porträts, Historiengemälde und Altarwerke. Im Jahr 1633 fand seine Wahl zum Oberhaupt, dem Dekan der Schildergilde statt. Zu seinen Schülern zählten u. a. seine Söhne Jakob van Oost der Jüngere, der die Schule seines Vaters fortsetzte und Willem van Oost (~8. März 1651 in Brügge; † 31. August 1866 ebenda), der Maler und Dominikanerlaienbruder war."
                        +"Nach seinen Rubenskopien gelangte er zu seinem eigenen Stil in dunkler und toniger Gesamthaltung. Sein Spätwerk ab 1660 besteht aus schwärzlich getonten Werken. Seine Gemälde finden sich in religiösen Einrichtungen und Sammlungen in Brügge, als auch in belgischem Privatbesitz und in folgenden Museen von Bergues, Berlin, Brüssel, Caen, Dijon, Dünkirchen, Leningrad, Lille, London, Lyon, New York City (Histor.Soc.[1] Kat. 1903 und Metropolitan Museum), Oostende, Paris, Tournai, Valenciennes und Wien.",
                    SourceLink = "https://de.wikipedia.org/wiki/Jakob_van_Oost_der_%C3%84ltere"
                },
                new ArtistTranslation
                {
                    Id = 20,
                    ArtistId = 3,
                    LanguageId = 4,
                    Description = "Jakob van Oost der Jüngere (* 1637 in Brügge; † 29. September 1713 in Brügge) war ein flämischer Maler des Barocks."
                        +"Zunächst von seinem Vater Jakob van Oost dem Älteren in Brügge ausgebildet, vertiefte er seine Kunststudien zwei Jahre lang in Paris. Anschließend widmete er sich mehrere Jahre der Antike und den alten Meistern in Rom. Nach seiner Rückkehr in Brügge wollte er zwar zurück nach Paris, blieb aber in Lille bei seinen Freunden aus der Studienzeit und lebte seit 1668 für 41 Jahre in dieser nordfranzösischen Stadt."
                        +"Jakob van Oost der Jüngere wurde in dieser Stadt neben Arnould de Vuezein anerkannter Porträtmaler[1]. Zeitgemäß beinhalteten seine Gemälde religiöse Themen. Im Jahr 1670 heiratete er Marie Bourgeois aus Lille, die ihm unter anderem den Sohn Dominique van Oost gebar, welcher ebenfalls Maler wurde."
                        +"Im Jahr 1709 verließ er als Folge des Spanischen Erbfolgekriegs Lille und kehrte zum Schutz vor dem Krieg in seine Heimatstadt Brügge zurück, wo er vier Jahre später 76-jährig verstarb.",
                    SourceLink = "https://de.wikipedia.org/wiki/Jakob_van_Oost_der_J%C3%BCngere"
                },
                new ArtistTranslation
                {
                    Id = 21,
                    ArtistId = 4,
                    LanguageId = 4,
                    Description = "Artus Wolffordt (* 1581 in Antwerpen; † 1641 ebenda) (auch: Wolfaerts, Wolffort, Wolfert) war ein flämischer Maler."
                        +"Kurz nach seiner Geburt zogen seine Eltern nach Dordrecht. Am 29. Dezember 1603 wurde er dort Mitglied in der St. Lucasgilde, doch bald wieder aus ihr gestrichen, da er nicht mehr vermögend genug war. 1615 wurde er Assistent von Otto van Veen in Antwerpen. 1617 soll er in der Kathedrale St. Paul in Antwerpen am Altar Die Auferstehung und Mariä Himmelfahrt gemalt haben."
                        +"In seiner Werkstatt sind zahlreiche Werke mit religiösen Motiven entstanden."
                        +"Zu seinen Schülern zählten Pieter Van Mol (1599–1650) und Pieter van Lint(1609–1690).",
                    SourceLink = "https://de.wikipedia.org/wiki/Artus_Wolffordt"
                },
                new ArtistTranslation
                {
                    Id = 22,
                    ArtistId = 5,
                    LanguageId = 4,
                    Description = "Erasmus Quellinus II., auch Erasmus Quellinus der Jüngere, (* 19. November 1607 in Antwerpen; † 7. November1678 ebenda) war ein flämischer Maler, Schüler von Rubens, und Kupferstecher aus der Antwerpener KünstlerfamilieQuellinus."
                        +"Er ist Sohn des Bildhauers Erasmus Quellinus I. und Bruder von Artus Quellinus I. und Hubertus Quellinus. Er wurde nach seiner Ausbildung bei Rubens 1633/34 Meister der Antwerpener Lukasgilde. Nach dem Tod von Rubens wurde er Stadtmaler von Antwerpen und überführte die ausgesprochen barocke Kunstauffassung von Rubens in eine eher klassizistisch grundierte Malerei. Gut dokumentieren lässt sich diese Neuorientierung an einem seiner wichtigsten Ausstattungsprojekte, die des Paleis op de Dam in Amsterdam, das er um 1656 zusammen mit seinem Bruder Artus Quellinus I ausstattete."
                        +"Sein Sohn Jan Erasmus Quellinus ist ebenfalls eine bekannte Persönlichkeit unter den Barockmalern der Spanischen Niederlande. Er führte die Hinwendung des Vaters zu einer eher klassizistischen Kunstströmung in Flandern in das 18. Jahrhundert fort.",
                    SourceLink = "https://de.wikipedia.org/wiki/Erasmus_Quellinus_II."
                },
                new ArtistTranslation
                {
                    Id = 23,
                    ArtistId = 6,
                    LanguageId = 4,
                    Description = "Sir Peter Lely (eigentlich Pieter van der Faes, * 14. September 1618 im westfälischen Soest;[1] † 30. November 1680 in London) war ein englischerMaler niederländischer Herkunft."
                        +"Mit 19 Jahren wurde Lely 1637 Schüler bei Pieter de Grebber in Haarlem. Mit Bürgschaft seines Lehrers de Grebber konnte er auch der Lukasgildebeitreten."
                        +"1643 ging Lely nach England und ließ sich 1647 in London nieder. Schon bald war er überall im Gespräch, da er seine Porträts ganz im Stil Anthonis van Dycks gestaltete. Da van Dyck vor einigen Jahren gestorben war, schloss Lely mit seinen Bildern eine große Lücke. Darum wurde Lely wahrscheinlich auch die Mitgliedschaft der altehrwürdigen Company of Painter Stainers angeboten."
                        +"Mit der Zeit wurde Lely, zusammen mit William Dobson, einer der führenden Porträtisten der englischen Revolution unter Oliver Cromwell und der nachfolgenden Herrscher. 1651 bewarb sich Lely für die Gestaltung verschiedener Wandmalereien in Whitehall."
                        +"Zehn Jahre später berief König Karl II. Lely zu seinem offiziellen Hofmaler. Ein Jahr später, 1662, wurde Lely die britische Staatsbürgerschaft verliehen. In den Jahren 1666 bis 1667 schuf Lely für Anne Hyde eine Serie von Porträts verschiedener Hofdamen; heute noch bekannt unter dem Titel The Windsor Beauties. Fast zeitgleich entstand eine weitere Porträtserie von Admirälen, The Flagmen."
                        +"Am 11. Januar 1680 wurde Lely von König Karl II. persönlich zum Knight Bachelor („Sir“) geschlagen.[2] Bereits ein Jahr später starb Sir Peter Lely im Alter von 62 Jahren."
                        +"Nach seiner stark niederländisch beeinflussten Phase gelangte Lely im Alter zu einer gelösten freien Maltechnik. Neben vielen Schülern Lelys sei hier vertretend für alle Nicolas de Largillière genannt.",
                    SourceLink = "https://de.wikipedia.org/wiki/Peter_Lely"
                },
                new ArtistTranslation
                {
                    Id = 24,
                    ArtistId = 1,
                    LanguageId = 5,
                    Description = "Lucas Achtschellinck (Bruselas 1626–1699) fue un pintor barroco flamenco, especializado en la pintura de paisaje."
                        +"Nació en Bruselas donde fue bautizado el 16 de enero de 1605. Entró como aprendiz de Pieter van der Borcht II en 1639 y aprendió la técnica de la pintura de paisaje con Lodewijk de Vadder. En 1657 fue aprobado como maestro en su ciudad natal, donde entre 1687 y 1689 desempeñó el cargo de decano de la corporación. Tuvo como discípulo a Theobald Michau.1 "
                        +"Influido por Jacques d'Arthois, sus paisajes, inspirados en el bosque de Soignes, siguen los efectos atmosféricos de los paisajes de Rubens, amplificando su valor pictórico y decorativo por la utilización de sutiles gradaciones de color.2 De él se conocen algunos paisajes animados con escenas bíblicas pintados para iglesias y conventos y, como en otros casos, es posible que colaborase con otros maestros, a los que pudo proporcionar los fondos de paisaje además de ocuparse en la ejecución de cartones para tapices.",
                    SourceLink = "https://es.wikipedia.org/wiki/Lucas_Achtschellinck"
                },
                new ArtistTranslation
                {
                    Id = 25,
                    ArtistId = 2,
                    LanguageId = 5,
                    Description = "Jacob van Oost I o el Viejo (Brujas, 1603 – 1671), fue un pintor barroco flamenco, especializado en pintura religiosa e historiada y retratos."
                        +"Nacido en Brujas, donde fue bautizado el 7 de enero de 1603, en octubre de 1621 ingresó en el gremio de San Lucas de su ciudad natal. Inmediatamente debió de marchar a Italia donde fue influido por la pintura caravaggista. De nuevo en Brujas, en 1629 fue elegido vicario del gremio y un año después contrajo matrimonio con Jaquemyne van Overdille, de la que enviudó en 1631, tras dar a luz a su hijo Martín. En 1633 casó en segundas nupcias con María van Tollenaere, con quien tuvo seis hijos, entre ellos el también pintor Jacob van Oost, llamado el joven. Decano del gremio de San Lucas en 1633-1634 y en 1643-1644, en enero de 1662 se le documenta por última vez como vicario de la organización gremial."
                        +"Tuvo numerosos discípulos trabajando en su taller, entre ellos dos aprendices de origen portugués o español: Franscoeis o Francisco Gomes y Jan o Juan Ramón, documentados en Brujas en 1640 y 1666 respectivamente."
                        +"Desde su primera obra firmada y fechada, la Adoración de los pastores del Museo del Ermitage(1630), caravaggista en el tratamiento de la luz y en la elección de los tipos populares, Van Oost fue frecuentemente reclamado por las iglesias locales para pintar retablos adaptados a la nueva sensibilidad contrarreformista. La influencia de Caravaggio no fue, no obstante, la única influencia italiana de Van Oost, que derivó tempranamente hacia las formulaciones clasicistas de Domenichino a la vez que aclaraba su paleta.",
                    SourceLink = "https://es.wikipedia.org/wiki/Jacob_van_Oost_(I)"
                },
                new ArtistTranslation
                {
                    Id = 26,
                    ArtistId = 3,
                    LanguageId = 5,
                    Description = "Jacob van Oost II o el Joven (Brujas, 1639 – 1713) fue un pintor barroco flamenco, especializado en retratos y pintura historiada y de género."
                        +"Hijo y discípulo de Jacob van Oost el Viejo, nació en Brujas, donde fue bautizado el 11 de febrero de 1639. Tras completar su formación en Roma, en el entorno de Simon Vouet, en 1668 se estableció en Lille donde en 1670 casó con Marie Bourgeois. En Lille trabajó principalmente para las iglesias y conventos de la ciudad —San Carlos Borromeo orando por el fin de la peste y San Antonio de Padua con el Niño Jesús para la iglesia de San Mauricio, la Resurrección de Lázaro para la iglesia de la Magdalena o San Macario de Gante socorriendo a los apestados, pasada al Museo del Louvre— en un estilo suave, influido tanto por el tardobarroco romano como por el clasicismo francés.2 "
                        +"Tras enviudar hacia 1697, en 1708 retornó a Brujas donde falleció el 29 de septiembre de 1713.",
                    SourceLink = "https://es.wikipedia.org/wiki/Jacob_van_Oost_(II)"
                },
                new ArtistTranslation
                {
                    Id = 27,
                    ArtistId = 4,
                    LanguageId = 5,
                    Description = "Artus Wolffort, Wolfordt o Wolffaert (Amberes, 1581 -1641) fue un pintor barroco flamenco especializado en pintura historiada, principalmente de asunto religioso, aunque también cultivó el paisaje y el retrato."
                        +"Formado en Dordrecht, ciudad a la que se habían trasladado sus padres cuando apenas contaba un año, en 1616 se encontraba de nuevo en Amberes, trabajando durante un corto espacio de tiempo en el taller de Otto van Veen, uno de los maestros de Rubens. Admitido en el gremio local de San Lucas en 1617, el 8 de septiembre de 1619 contrajo matrimonio con María Vandelaer. Del matrimonio nació en 1625 Jan-Baptiste Wolfaerts, quien llegaría a ser pintor especializado en paisajes y ocasionalmente copista de las obras paternas."
                        +"Aunque recibió algún encargo importante con destino a la iglesia de San Pablo de Amberes, el grueso de su producción está formado por escenas evangélicas y series de apóstoles, evangelistas y padres de la Iglesia, destinadas a particulares. La abundancia de copias de sus obras y su desigual calidad, ha hecho suponer que se situase a la cabeza de un numeroso taller desde el que atender las demandas del mercado de arte. En él se formaron, además de su hijo, Peter van Lint y Peter van Mol."
                        +"Su pintura, aunque arraigada en el clasicismo de Otto van Veen, recibe también influencias del más vitalista y animado estilo de Rubens, incluso adaptando composiciones de este al más seco estilo de su maestro.",
                    SourceLink = "https://es.wikipedia.org/wiki/Artus_Wolffort"
                },
                new ArtistTranslation
                {
                    Id = 28,
                    ArtistId = 5,
                    LanguageId = 5,
                    Description = "Erasmus Quellinus II, también llamado Erasmus el Joven(Amberes, 1607- 1678), fue un pintor y dibujante flamenco, miembro de una familia de artistas, principalmente escultores, oficio desempeñado por su padre Erasmus Quellinus I y su hermano, Artus Quellinus."
                        +"Erasmus se formó inicialmente con su padre, pero habiendo optado por la pintura se inclinó hacia los pintores caravaggistas flamencos como Theodoor Rombouts o Gerard Seghers, para crear mediante el uso de la luz figuras rotundas de modelado escultórico."
                        +"Hacia 1633 se estableció como maestro pintor independiente, ingresando en el Gremio de San Lucas de su ciudad natal, a la vez que comenzó a colaborar con Rubens, primero en las lujosas arquitecturas efímeras levantadas para conmemorar la «joyeuse entrée» del cardenal-infante don Fernando de Austria en la ciudad de Amberes el 15 de abril de 1635,1 y a continuación en el amplio ciclo de pinturas mitológicas encargadas por Felipe IV para la decoración de la Torre de la Parada, en el que Rubens se encontraba trabajando ya en noviembre de 1636.2 A Quellinus correspondieron en este encargo seis cuadros realizados sobre los bocetos de Rubens, todos ellos conservados en el Museo del Prado. A partir de este momento su pintura se hizo más ampulosa, eligiendo para sus escenas de asunto tanto histórico como mitológico o religioso lujosos fondos arquitectónicos de raíz clasicista."
                        +"Colaboró también con cierta frecuencia con Daniel Seghers y con su cuñado Jan Philip van Thielen, pintando las figuras de sus célebres guirnaldas florales y, a partir de 1656, con su hermano Artus se encargó de la decoración del nuevo Ayuntamiento de Ámsterdam. Como dibujante proporcionó los diseños para series de tapices, como la dedicada a la historia de la familia Thurn und Taxis."
                        +"Entre sus discípulos y colaboradores se contó su hijo, Jan Erasmus Quellinus.",
                    SourceLink = "https://es.wikipedia.org/wiki/Erasmus_Quellinus_II"
                },
                new ArtistTranslation
                {
                    Id = 29,
                    ArtistId = 6,
                    LanguageId = 5,
                    Description = "Peter Lely (Soest, Westfalia; 14 de septiembre de 1618-Covent Garden, Londres, Inglaterra; 30 de noviembre de 1680) fue un retratista danés, nacido en Soest, Westfalia, cuyo verdadero nombre era Pieter van der Faes."
                        +"Se formó artísticamente en Haarlem, Países Bajos. En 1641 se estableció en Londres, y poco después recibió el encargo de retratar a los principales personajes de la corte inglesa."
                        +"Carlos II de Inglaterra le nombró pintor de cámara en 1661 y le armó caballero en 1680."
                        +"Su pintura, rica sobre todo en el colorido de los elegantes ropajes de los retratados, tiene una clara influencia de Anton van Dyck. La serie de cuadros Bellezas de Windsor (década de 1660) se encuentra en el palacio de Hampton Court, Londres. Otra serie, denominada Almirantes, se conserva en el Museo Marítimo Nacional de Greenwich, Londres.",
                    SourceLink = "https://es.wikipedia.org/wiki/Peter_Lely"
                }
            );

            modelBuilder.Entity<Movement>()
            .HasData(
                new Movement
                {
                    Id = 1
                },
                new Movement
                {
                    Id = 2
                }
            );

            modelBuilder.Entity<MovementTranslation>()
            .HasData(
                new MovementTranslation
                {
                    Id = 1,
                    MovementId = 1,
                    Name = "Baroque",
                    LanguageId = 1,
                    Description = "Le baroque est un mouvement artistique qui trouve son origine en Italie dans des villes telles que Rome, Mantoue, Venise et Florence dès le milieu du xvie siècle et qui se termine au milieu du xviiie siècle. Il y a un âge baroque différent selon les domaines, qu'ils soient intellectuels, historiques ou artistiques. Certains critiques y voient une constante culturelle qui revient tout au long de l'histoire comme l'a écrit Eugenio d'Ors."
                        +"Le baroque, qui touche tous les domaines, se caractérise par l’exagération du mouvement, la surcharge décorative, les effets dramatiques, la tension, l’exubérance des formes, la grandeur parfois pompeuse et le contraste, ce même contraste dont parlait Philippe Beaussant : l’époque baroque a tenté de dire « un monde où tous les contraires seraient harmonieusement possibles »",
                    SourceLink = "https://fr.wikipedia.org/wiki/Baroque"
                
                },
                new MovementTranslation
                {
                    Id = 2,
                    MovementId = 1,
                    Name = "Barok (stijlperiode)",
                    LanguageId = 2,
                    Description = "De barok is een Europese stijlperiode die aan het begin van de 17e eeuw in Italië tot ontwikkeling kwam en tot in de eerste helft van de 18e eeuw voortduurde, en die zich kenmerkt door overdaad van vorm en heftigheid van gevoelsuitdrukking. De barok kwam tot uiting op alle terreinen van de cultuur, zoals architectuur, tuinarchitectuur, schilderkunst, beeldhouwkunst, literatuur en muziek. Er wordt een onderscheid gemaakt tussen vroeg-, hoog- en laatbarok. De laatbarok wordt ook wel rococo genoemd.",
                    SourceLink = "https://nl.wikipedia.org/wiki/Barok_(stijlperiode)"
                },
                new MovementTranslation
                {
                    Id = 3,
                    MovementId = 1,
                    Name = "Baroque",
                    LanguageId = 3,
                    Description = "The Baroque (UK: /bəˈrɒk/, US: /bəˈroʊk/) is a highly ornate and often extravagant style of architecture, music, dance, painting, sculpture and other arts that flourished in Europe from the early 17th until the mid-18th century. It followed Renaissance art and Mannerism and preceded the Rococo (in the past often referred to as 'late Baroque') and Neoclassical styles. It was encouraged by the Catholic Church as a means to counter the simplicity and austerity of Protestant architecture, art and music, though Lutheran Baroque art developed in parts of Europe as well.[1]"
                        +"The Baroque style used contrast, movement, exuberant detail, deep colour, grandeur and surprise to achieve a sense of awe. The style began at the start of the 17th century in Rome, then spread rapidly to France, northern Italy, Spain and Portugal, then to Austria and southern Germany. By the 1730s, it had evolved into an even more flamboyant style, called rocaille or Rococo, which appeared in France and Central Europe until the mid to late 18th century.",
                    SourceLink = "https://en.wikipedia.org/wiki/Baroque"
                },
                new MovementTranslation
                {
                    Id = 4,
                    MovementId = 1,
                    Name = "Baroque",
                    LanguageId = 4,
                    Description = "Als Barock (Maskulinum „der Barock“, oder gleichwertig Neutrum „das Barock“) wird eine Epoche der europäischen Kunstgeschichte bezeichnet, die Ende des 16. Jahrhunderts begann[1] und bis ca. 1760/70 reicht. Es handelt sich nicht um einen völlig einheitlichen Stilbegriff, da es innerhalb des Barockzeitalters gleichzeitig zum Teil sehr verschiedene künstlerische Ausprägungen und Unterströmungen und auch eine Entwicklung gab,[2] nicht zuletzt auch große Unterschiede in verschiedenen Gegenden und Ländern.[3]Eine grobe Unterteilung in drei oder vier Unterepochen ist üblich, deren zeitliche Abgrenzung jedoch nicht völlig eindeutig angegeben werden kann: Frühbarock (bis ca. 1650), Hochbarock (ca. 1650–1700), Spätbarock (ca. 1700–1730)[4] und Rokoko (ca. 1730–1760/70). Gelegentlich werden Spätbarock und Rokoko gleichgesetzt, andererseits wird das Rokoko auch als eigenständige Epoche angesehen."
                        +"Dem Barock voraus gingen die Epochen der Renaissance und des Manierismus, ihm folgte der Klassizismus.",
                    SourceLink = "https://de.wikipedia.org/wiki/Barock"
                },
                new MovementTranslation
                {
                    Id = 5,
                    MovementId = 1,
                    Name = "Barroco",
                    LanguageId = 5,
                    Description = "El Barroco fue un período de la historia en la cultura occidental originado por una nueva forma de concebir el arte (el «estilo barroco») y que, partiendo desde diferentes contextos histórico-culturales, produjo obras en numerosos campos artísticos: literatura, arquitectura, escultura, pintura, música, ópera, danza, teatro, etc. Se manifestó principalmente en la Europa occidental, aunque debido al colonialismo también se dio en numerosas colonias de las potencias europeas, principalmente en Latinoamérica. Cronológicamente, abarcó todo el siglo XVIIy principios del XVIII, con mayor o menor prolongación en el tiempo dependiendo de cada país. Se suele situar entre el Manierismo y el Rococó, en una época caracterizada por fuertes disputas religiosas entre países católicos y protestantes, así como marcadas diferencias políticas entre los Estados absolutistas y los parlamentarios, donde una incipiente burguesía empezaba a poner los cimientos del capitalismo."
                        +"Como estilo artístico, el Barroco surgió a principios del siglo XVII (según otros autores a finales del XVI) en Italia —período también conocido en este país como Seicento—, desde donde se extendió hacia la mayor parte de Europa. Durante mucho tiempo (siglos XVIII y XIX) el término «barroco» tuvo un sentido peyorativo, con el significado de recargado, engañoso, caprichoso, hasta que fue posteriormente revalorizado a finales del siglo XIX por Jacob Burckhardt y, en el XX, por Benedetto Croce y Eugenio d'Ors. Algunos historiadores dividen el Barroco en tres períodos: «primitivo» (1580-1630), «maduro» o «pleno» (1630-1680) y «tardío» (1680-1750).",
                    SourceLink = "https://es.wikipedia.org/wiki/Barroco"
                },
                new MovementTranslation
                {
                    Id = 6,
                    MovementId = 2,  //Gotisch
                    Name = "Architecture gothique",
                    LanguageId = 1, //Frans
                    Description = "Le baroque est un mouvement artistique qui trouve son origine en Italie dans des villes telles que Rome, Mantoue, Venise et Florence dès le milieu du xvie siècle et qui se termine au milieu du xviiie siècle. Il y a un âge baroque différent selon les domaines, qu'ils soient intellectuels, historiques ou artistiques. Certains critiques y voient une constante culturelle qui revient tout au long de l'histoire comme l'a écrit Eugenio d'Ors."
                        +"Le baroque, qui touche tous les domaines, se caractérise par l’exagération du mouvement, la surcharge décorative, les effets dramatiques, la tension, l’exubérance des formes, la grandeur parfois pompeuse et le contraste, ce même contraste dont parlait Philippe Beaussant : l’époque baroque a tenté de dire « un monde où tous les contraires seraient harmonieusement possibles »",
                    SourceLink = "https://fr.wikipedia.org/wiki/Architecture_gothique"
                
                },
                new MovementTranslation
                {
                    Id = 7,
                    MovementId = 2,  //Gotisch
                    Name = "Gotische architectuur",
                    LanguageId = 2, //Nederlands
                    Description = "De barok is een Europese stijlperiode die aan het begin van de 17e eeuw in Italië tot ontwikkeling kwam en tot in de eerste helft van de 18e eeuw voortduurde, en die zich kenmerkt door overdaad van vorm en heftigheid van gevoelsuitdrukking. De barok kwam tot uiting op alle terreinen van de cultuur, zoals architectuur, tuinarchitectuur, schilderkunst, beeldhouwkunst, literatuur en muziek. Er wordt een onderscheid gemaakt tussen vroeg-, hoog- en laatbarok. De laatbarok wordt ook wel rococo genoemd.",
                    SourceLink = "https://nl.wikipedia.org/wiki/Gotiek_(bouwkunst)"
                },
                new MovementTranslation
                {
                    Id = 8,
                    MovementId = 2,  //Gotisch
                    Name = "Gothic architecture",
                    LanguageId = 3, //Engels
                    Description =   "Gothic art was a style of medieval art that developed in Northern France out of Romanesque art in the 12th century AD, led by the concurrent development of Gothic architecture." 
                                    + "It spread to all of Western Europe, and much of Southern and Central Europe, never quite effacing more classical styles in Italy. In the late 14th century, the sophisticated court style of International Gothic developed, which continued to evolve until the late 15th century."
                                    + "In many areas, especially Germany, Late Gothic art continued well into the 16th century, before being subsumed into Renaissance art. Primary media in the Gothic period included sculpture, panel painting, stained glass, fresco and illuminated manuscripts." 
                                    + "The easily recognizable shifts in architecture from Romanesque to Gothic, and Gothic to Renaissance styles, are typically used to define the periods in art in all media, although in many ways figurative art developed at a different pace.",
                    SourceLink = "https://en.wikipedia.org/wiki/Gothic_architecture"
                },
                new MovementTranslation
                {
                    Id = 9,
                    MovementId = 2, //Gotisch
                    Name = "Gotische Architektur",
                    LanguageId = 4, //Duits
                    Description = "Als Barock (Maskulinum „der Barock“, oder gleichwertig Neutrum „das Barock“) wird eine Epoche der europäischen Kunstgeschichte bezeichnet, die Ende des 16. Jahrhunderts begann[1] und bis ca. 1760/70 reicht. Es handelt sich nicht um einen völlig einheitlichen Stilbegriff, da es innerhalb des Barockzeitalters gleichzeitig zum Teil sehr verschiedene künstlerische Ausprägungen und Unterströmungen und auch eine Entwicklung gab,[2] nicht zuletzt auch große Unterschiede in verschiedenen Gegenden und Ländern.[3]Eine grobe Unterteilung in drei oder vier Unterepochen ist üblich, deren zeitliche Abgrenzung jedoch nicht völlig eindeutig angegeben werden kann: Frühbarock (bis ca. 1650), Hochbarock (ca. 1650–1700), Spätbarock (ca. 1700–1730)[4] und Rokoko (ca. 1730–1760/70). Gelegentlich werden Spätbarock und Rokoko gleichgesetzt, andererseits wird das Rokoko auch als eigenständige Epoche angesehen."
                        +"Dem Barock voraus gingen die Epochen der Renaissance und des Manierismus, ihm folgte der Klassizismus.",
                    SourceLink = "https://de.wikipedia.org/wiki/Gotik#Baukunst"
                },
                new MovementTranslation
                {
                    Id = 10,
                    MovementId = 2, //Gotisch
                    Name = "Arquitectura gótica",
                    LanguageId = 5, //Spaans
                    Description = "El Barroco fue un período de la historia en la cultura occidental originado por una nueva forma de concebir el arte (el «estilo barroco») y que, partiendo desde diferentes contextos histórico-culturales, produjo obras en numerosos campos artísticos: literatura, arquitectura, escultura, pintura, música, ópera, danza, teatro, etc. Se manifestó principalmente en la Europa occidental, aunque debido al colonialismo también se dio en numerosas colonias de las potencias europeas, principalmente en Latinoamérica. Cronológicamente, abarcó todo el siglo XVIIy principios del XVIII, con mayor o menor prolongación en el tiempo dependiendo de cada país. Se suele situar entre el Manierismo y el Rococó, en una época caracterizada por fuertes disputas religiosas entre países católicos y protestantes, así como marcadas diferencias políticas entre los Estados absolutistas y los parlamentarios, donde una incipiente burguesía empezaba a poner los cimientos del capitalismo."
                        +"Como estilo artístico, el Barroco surgió a principios del siglo XVII (según otros autores a finales del XVI) en Italia —período también conocido en este país como Seicento—, desde donde se extendió hacia la mayor parte de Europa. Durante mucho tiempo (siglos XVIII y XIX) el término «barroco» tuvo un sentido peyorativo, con el significado de recargado, engañoso, caprichoso, hasta que fue posteriormente revalorizado a finales del siglo XIX por Jacob Burckhardt y, en el XX, por Benedetto Croce y Eugenio d'Ors. Algunos historiadores dividen el Barroco en tres períodos: «primitivo» (1580-1630), «maduro» o «pleno» (1630-1680) y «tardío» (1680-1750).",
                    SourceLink = "https://es.wikipedia.org/wiki/Arquitectura_g%C3%B3tica"
                }
            );

            modelBuilder.Entity<Technique>()
            .HasData(
                new Technique
                {
                    Id = 1
                }
            );

            modelBuilder.Entity<TechniqueTranslation>()
            .HasData(
                new TechniqueTranslation
                {
                    Id = 1,
                    TechniqueId = 1,
                    LanguageId = 1,
                    Name = "Peinture à l'huile",
                    Description = "La peinture à l'huile est une peinture dont le liant ou véhicule est une huile siccative qui enveloppe complètement les particules de pigment."
                        +"On appelle aussi « peinture » les travaux d'enduction d'une surface par ce genre de produit. Les autorités normatives françaises demandent qu'on dise peinturage, mais ce terme n'a jamais pris1. La « peinture à l'huile » est donc aussi l'activité de nombreux artistes peintres passés et présents, ainsi qu'une technique picturale.",
                    SourceLink = "https://fr.wikipedia.org/wiki/Peinture_%C3%A0_l%27huile"
                },
                new TechniqueTranslation
                {
                    Id = 2,
                    TechniqueId = 1,
                    LanguageId = 2,
                    Name = "Olieverfschilderij",
                    Description = "Olieverf is een verfsoort, een mengsel van pigment in de vorm van een zeer fijn gekleurd poeder met, als bindmiddel, een plantaardige drogende olie, meestal lijnolie. Olieverf is vanaf de 15e eeuw een belangrijk medium in de schilderkunst. Ze werd voor het eerst gebruikt door de Vlaamse Primitieven.",
                    SourceLink = "https://nl.wikipedia.org/wiki/Olieverf"
                },
                new TechniqueTranslation
                {
                    Id = 3,
                    TechniqueId = 1,
                    LanguageId = 3,
                    Name = "Oil paint",
                    Description = "Oil paint is a type of slow-drying paint that consists of particles of pigment suspended in a drying oil, commonly linseed oil. The viscosity of the paint may be modified by the addition of a solvent such as turpentine or white spirit, and varnish may be added to increase the glossiness of the dried oil paint film. Oil paints have been used in Europe since the 12th century for simple decoration, but were not widely adopted as an artistic medium until the early 15th century. Common modern applications of oil paint are in finishing and protection of wood in buildings and exposed metal structures such as ships and bridges. Its hard-wearing properties and luminous colors make it desirable for both interior and exterior use on wood and metal. Due to its slow-drying properties, it has recently been used in paint-on-glass animation. Thickness of coat has considerable bearing on time required for drying: thin coats of oil paint dry relatively quickly.",
                    SourceLink = "https://en.wikipedia.org/wiki/Oil_paint"
                },
                new TechniqueTranslation
                {
                    Id = 4,
                    TechniqueId = 1,
                    LanguageId = 4,
                    Name = "Ölmalerei",
                    Description = "Die Ölmalerei ist die künstlerische Malerei mit Ölfarben und gilt als „klassische Königsdisziplin“ der Kunst, die insbesondere bei Porträt-, Landschafts-, Stillleben- und Genremalerei zur Anwendung kommt. Die Haltbarkeit und Farbbrillanz der Ölmalerei ist unübertroffen. Öl ist als Bindemittel ein Hauptbestandteil der Ölfarbe, woraus sich die Bezeichnung für die Ölmalerei ableitet.",
                    SourceLink = "https://de.wikipedia.org/wiki/%C3%96lmalerei"
                },
                new TechniqueTranslation
                {
                    Id = 5,
                    TechniqueId = 1,
                    LanguageId = 5,
                    Name = "Pintura al aceite",
                    Description = "Una pintura al aceite es un tipo de pintura de secado lento que consiste de partículas de pigmentos en suspensión en un aceite secante. Las pinturas al aceite han sido utilizadas en Inglaterra desde el siglo XIII para decoración,1​ pero no se popularizaron para usos artísticos sino hasta el siglo XV. Los usos modernos más comunes de pinturas al aceite son la decoración de casas, donde su resistencia y colores luminosos las hacen apropiadas tanto para usos en interiores como en exteriores. Sus propiedades de secado lento han sido aprovechadas recientemente para realizar animación mediante pintura sobre vidrio."
                        +"Cuando se la utiliza para fines artísticos es llamada pintura al óleo.",
                    SourceLink = "https://es.wikipedia.org/wiki/Pintura_al_aceite"
                }
            );

            modelBuilder.Entity<Painting>()
            .HasData(
                new Painting
                {
                    Id = 1,
                    AuthorId = 1,
                    ImageUrl = "http://groeningemuseum.be/collection/work/representation/0000_GRO0004_I",
                    Year = 1699,
                    Height = (float) 162,
                    Width = (float) 228,
                    TechniqueId = 1,
                    MovementId = 1,
                    MuseumCode = "A"
                },
                new Painting
                {
                    Id = 2,
                    AuthorId = 2,
                    ImageUrl = "http://groeningemuseum.be/collection/work/representation/0000_GRO0181_I",
                    Year = 1645,
                    Height = (float) 150.5,
                    Width = (float) 255.5,
                    TechniqueId = 1,
                    MovementId = 1,
                    MuseumCode = "B"
                },
                new Painting
                {
                    Id = 3,
                    AuthorId = 2,
                    ImageUrl = "http://groeningemuseum.be/collection/work/representation/0000_GRO0184_I",
                    Year = 1668,
                    Height = (float) 116,
                    Width = (float) 222,
                    TechniqueId = 1,
                    MovementId = 1,
                    MuseumCode = "C"
                },
                new Painting
                {
                    Id = 4,
                    AuthorId = 3,
                    ImageUrl = "http://groeningemuseum.be/collection/work/representation/0000_GRO0187_I",
                    Year = 1697,
                    Height = (float) 73,
                    Width = (float) 59,
                    TechniqueId = 1,
                    MovementId = 1,
                    MuseumCode = "D"
                },
                new Painting
                {
                    Id = 5,
                    AuthorId = 4,
                    ImageUrl = "http://groeningemuseum.be/collection/work/representation/0000_GRO0374_I",
                    Year = 1641,
                    Height = (float) 123.3,
                    Width = (float) 94.2,
                    TechniqueId = 1,
                    MovementId = 1,
                    MuseumCode = "E"
                },
                new Painting
                {
                    Id = 6,
                    AuthorId = 2,
                    ImageUrl = "http://groeningemuseum.be/collection/work/representation/0000_GRO1346_I",
                    Year = 1670,
                    Height = (float) 106,
                    Width = (float) 83,
                    TechniqueId = 1,
                    MovementId = 1,
                    MuseumCode = "F"
                },
                new Painting
                {
                    Id = 7,
                    AuthorId = 5,
                    ImageUrl = "http://groeningemuseum.be/collection/work/representation/1991_GRO0007_I",
                    Year = 1643,
                    Height = (float) 220,
                    Width = (float) 240,
                    TechniqueId = 1,
                    MovementId = 1,
                    MuseumCode = "G"
                },
                new Painting
                {
                    Id = 8,
                    AuthorId = 6,
                    ImageUrl = "http://groeningemuseum.be/collection/work/representation/2012_GRO0001_I",
                    Year = 1652,
                    Height = (float) 76.2,
                    Width = (float) 63.5,
                    TechniqueId = 1,
                    MovementId = 1,
                    MuseumCode = "H"
                },
                new Painting
                {
                    Id = 9,
                    AuthorId = 2,
                    ImageUrl = null,
                    Year = 1640,
                    Height = (float) 193.5,
                    Width = (float) 275,
                    TechniqueId = 1,
                    MovementId = 1,
                    MuseumCode = "I"
                }
            );

            modelBuilder.Entity<PaintingTranslation>()
            .HasData(
                new PaintingTranslation
                {
                    Id = 1,
                    PaintingId = 1,
                    LanguageId = 1,
                    Name = "Paysage boisé avec gué",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I"
                },
                new PaintingTranslation
                {
                    Id = 2,
                    PaintingId = 1,
                    LanguageId = 2,
                    Name = "Boslandschap met wad",
                    Description = "Gezicht op een open plek in het bos, met marktkramers en boeren, nabij een doorwaadbare plaats in een beek. Aan de overkant van het water staat een man met twee paarden. Doorheen de bomen heeft men een doorkijk op een verre, gedeeltelijk beboste achtergrond, waar eveneens mensen te zien zijn. De personages op de voorgrond lijken door Achtschellinck zelf geschilderd te zijn; ze zijn duidelijk verwant aan de figuren van zijn tijd- en stadsgenoot David Teniers de Jongere. Het schilderij vertoont een zeer enge stijlovereenkomst met de andere beboste landschappen van Lucas Achtschellinck in de collectie van het Groeningemuseum",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I"
                },
                new PaintingTranslation
                {
                    Id = 3,
                    PaintingId = 1,
                    LanguageId = 3,
                    Name = "Wooded Landscape with Ford",
                    Description = "View of a clearing in the woods, with market vendors and farmers, near a fordable place in a stream. On the other side of the water is a man with two horses. Through the trees one has a view on a distant, partially wooded background, where also people can be seen. The characters in the foreground seem to have been painted by Achtschellinck himself; they are clearly related to the figures of his contemporary David Teniers the Younger. The painting shows a similar in style to the other wooded landscapes of Lucas Achtschellinck in the collection of the Groeninge Museum (0000.GRO0001.I-0000.GRO0003.I, 0000.GRO0005.I). (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, pp. 14).",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I"
                },
                new PaintingTranslation
                {
                    Id = 4,
                    PaintingId = 2,
                    LanguageId = 1,
                    Name = "Portrait d'une famille brugeoise",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0181_I"
                },
                new PaintingTranslation
                {
                    Id = 5,
                    PaintingId = 2,
                    LanguageId = 2,
                    Name = "Portret van een Brugse familie",
                    Description = "De burgerman wijst ostentatief naar het ommeland om onze aandacht te vestigen op zijn bezittingen. Het lage gezichtspunt maakt dat de personages een imposante indruk maken. De familie is onbekend, maar door het herkenbare silhouet van de stad Brugge dient de familie in Brugse context gesitueerd te worden. De leeftijden van de familieleden zijn onopvallend geïntegreerd: bij de man op de hiel van zijn schoen (46), bij de vrouw op haar waaier (26), bij de kleine jongen naast haar op zijn hoedje (3), bij het zittende meisje op het kussen in haar korf (15), bij de jongeman op zijn laars (17), en bij het kindje in de armen van het kindermeisje op het stuk brood in haar handen (1). Uit het grote leeftijdsverschil tussen de echtgenoten enerzijds, en de jonge leeftijd van de vrouw anderzijds, kan afgeleid worden dat de kinderen uit twee huwelijken moeten stammen. Waarschijnlijk zijn alleen de twee kleinste kinderen geboren uit het huwelijk met de hier afgebeelde vrouw. Uiterst links op het schilderij staat een tuinman met een spade over de schouder, afdalend naar de tuin. Zoals bij de meeste familieportretten bevat dit werk een onderliggende symboliek, verwijzend naar liefde, zuiverheid en vruchtbaarheid, als voorwaarden voor een harmonisch gezinsleven. Daarnaast wordt de sociale status van het gezin belicht.  (Naar: H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, pp. 194-195.)",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0181_I"
                },
                new PaintingTranslation
                {
                    Id = 6,
                    PaintingId = 2,
                    LanguageId = 3,
                    Name = "Portrait of a Bruges family",
                    Description = "The bourgeois ostentatiously points to the countryside to draw our attention to his possessions. The low point of view makes that the characters make an impressive impression. The family is unknown, but because of the recognizable silhouette of the city of Bruges, the family has to be situated in a Bruges context. The ages of the family members are unobtrusively integrated: with the man on the heel of his shoe (46), with the woman on her fan (26), with the little boy next to her in his hat (3), with the sitting girl on the pillow in her basket (15), with the young man on his boot (17), and with the child in the arms of the nanny on the piece of bread in her hands (1). From the large age difference between the husbands on the one hand, and the young age of the woman on the other hand, it can be deduced that the children have to come from two marriages. Probably only the two smallest children were born from the marriage with the woman depicted here. On the far left of the painting is a gardener with a spade over his shoulder, descending to the garden. As with most family portraits, this work contains an underlying symbolism, referring to love, purity and fertility, as conditions for a harmonious family life. In addition, the social status of the family is highlighted. (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, pp. 194-195.)",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0181_I"
                },
                new PaintingTranslation
                {
                    Id = 7,
                    PaintingId = 3,
                    LanguageId = 1,
                    Name = "Portrait d’un théologien et son secrétaire",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0184_I"
                },
                new PaintingTranslation
                {
                    Id = 8,
                    PaintingId = 3,
                    LanguageId = 2,
                    Name = "Portret van een theoloog met zijn secretaris",
                    Description = "Een theoloog, waarschijnlijk een jezuïet, leest de conciliebesluiten en becommentarieert ze. Zijn seculiere secretaris noteert. Links staat de lezenaar, versierd met een sculptuur van een Calvariegroep, en met deel 36 van de verzamelde conciliebesluiten er op. Rechts een werktafel  met een rijk gekleurd tafelkleed, waaraan de priester en de secretaris zitten. Op de tafel bevinden zich studie-attributen, zoals een wereldbol en een boek. Erachter ziet men een boekenkast met bijbeluitgaven en literatuur op het gebied van theologie, exegese en kerkelijk recht. Zoals vaak, inspireert Van Oost zich ook hier weer op de portretten van Anthony van Dyck.  (Naar: H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 198; E. Tahon, in: musea@brugge, augustus 2003, pp. 13-14.)",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0184_I"
                },
                new PaintingTranslation
                {
                    Id = 9,
                    PaintingId = 3,
                    LanguageId = 3,
                    Name = "Portrait of a Theologue and his Secretary",
                    Description = "A theologian, probably a Jesuit, reads and comments on the council decisions. His secular secretary notes. On the left is the lectern, decorated with a sculpture of a Calvary group, and with part 36 of the collected council decrees on it. On the right a work table with a richly coloured tablecloth, on which the priest and the secretary are seated. On the table there are study attributes, such as a globe and a book. Behind it is a bookcase with biblical editions and literature in the field of theology, exegesis and ecclesiastical law. As is often the case, Van Oost is again inspired by the portraits of Anthony van Dyck. (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 198; E. Tahon, in: musea@brugge, augustus 2003, pp. 13-14.)",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0184_I"
                },
                new PaintingTranslation
                {
                    Id = 10,
                    PaintingId = 4,
                    LanguageId = 1,
                    Name = "Portrait d' un homme",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0187_I"
                },
                new PaintingTranslation
                {
                    Id = 11,
                    PaintingId = 4,
                    LanguageId = 2,
                    Name = "Portret van een man",
                    Description = "Borstbeeld van een in het zwart geklede man in driekwartswending. Ovaal schilderij, gevat in een rechthoekige lijst. Af te leiden uit het opschrift op de achterzijde, gaat het hier om een vriend van de kunstenaar. (Naar: H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, pp. 208.)",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0187_I"
                },
                new PaintingTranslation
                {
                    Id = 12,
                    PaintingId = 4,
                    LanguageId = 3,
                    Name = "Portrait of a Man",
                    Description = "Bust of a man dressed in black in a three-quarter turn. Oval painting, framed in a rectangular frame. From the inscription on the back, this is a friend of the artist. (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, pp. 208.)",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0187_I"
                },
                new PaintingTranslation
                {
                    Id = 13,
                    PaintingId = 5,
                    LanguageId = 1,
                    Name = "Sainte Trinité",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0374_I"
                },
                new PaintingTranslation
                {
                    Id = 14,
                    PaintingId = 5,
                    LanguageId = 2,
                    Name = "Heilige Drievuldigheid",
                    Description = "God de Vader, met tiara op het hoofd, toont Christus, de Zoon, die ostentatief zijn wonden laat zien. Boven beiden zweeft de Helige Geest, in de gedaante van een duif. De hier gevolgde iconografie heeft een oude traditie: uiteindelijk gaat ze terug op Dürers gelijknamige prent uit 1511, die op haar beurt weer vroegere Oud-Nederlandse prototypes reflecteert. Het schilderij werd in het verleden begeschreven als achtereenvolgens een werk van Gerard Seghers, een kopie naar Rubens, van de hand van Nicolaas de Liemaeker, in verband te brengen met Abraham Janssens, en toe te schrijven aan Joos de Momper. De recentste toeschrijving toont aan dat het uit het atelier van de Antwerpse schilder Artus Wolffort zou afkomstig zijn. Dit baseert voornamelijk op de karakteristieke gelaatstypering. Van deze compositie bestaan verschillende versies.",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0374_I"
                },
                new PaintingTranslation
                {
                    Id = 15,
                    PaintingId = 5,
                    LanguageId = 3,
                    Name = "Holy Trinity",
                    Description = "God the Father, with tiara on his head, shows Christ, the Son, who ostentatiously shows his wounds. Above them floats the Holy Spirit, in the form of a dove. The iconography followed here has an old tradition: in the end it goes back to Dürer's print of the same name from 1511, which in turn reflects earlier Old Dutch prototypes. In the past, the painting was written successively as a work by Gerard Seghers, a copy after Rubens, by the hand of Nicolaas de Liemaeker, in connection with Abraham Janssens, and attributable to Joos de Momper. The most recent attribution shows that it came from the studio of the Antwerp painter Artus Wolffort. This is mainly based on the characteristic facial typing. There are different versions of this composition.",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0374_I"
                },
                new PaintingTranslation
                {
                    Id = 16,
                    PaintingId = 6,
                    LanguageId = 1,
                    Name = "Portrait de Fovin de Hasque",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO1346_I"
                },
                new PaintingTranslation
                {
                    Id = 17,
                    PaintingId = 6,
                    LanguageId = 2,
                    Name = "Portret van Fovin de Hasque",
                    Description = "De schermmeester van de Brugse Sint-Michielsgilde is hier voorgesteld met een degen aan zijn gordel. Met zijn rechterhand houdt hij de schacht van een hellebaard of een standaard vast. Het opschrift luidt: Dit is het beelt van Fovin d'Hasque Schermmeester van Brugghe vaillant / Die alhier ghebracht heeft de olie van [de] H. Walburgis uyt duytslant / 1670. Dit laatste deed De Hasque in 1669, op verzoek van de pastoors, kapelaans en kerkmeesters van Sint-Walburga in Brugge. Hij overleed in datzelfde jaar. Wellicht werd dit portret geschilderd naar aanleiding van zijn dood. (Naar: H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 204.)",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO1346_I"
                },
                new PaintingTranslation
                {
                    Id = 18,
                    PaintingId = 6,
                    LanguageId = 3,
                    Name = "Portrait of Fovin de Hasque",
                    Description = "The fencing master of the Bruges Guild of St Michael is shown here with a sword on his belt. With his right hand he holds the shaft of a halberd or a stand. The inscription reads: This is the image of Fovin d'Hasque Schermmeester van Brugghe vaillant / Die alhier ghebracht heeft de olie van [de] H. Walburgis uyt duytslant / 1670 (Translation: This is the image of Fovin d'Hasque vaillant van Brugge vaillant / Who brought the oil from Schermmeester van H. Walburgis from Germany to this place / 1670). The latter was done by De Hasque in 1669, at the request of the parish priests, chaplains and church masters of Sint-Walburga in Bruges. He died that same year. Possibly this portrait was painted on the occasion of his death. (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 204.)",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO1346_I"
                },
                new PaintingTranslation
                {
                    Id = 19,
                    PaintingId = 7,
                    LanguageId = 1,
                    Name = "Achille parmi les filles de Lycomède",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/1991_GRO0007_I"
                },
                new PaintingTranslation
                {
                    Id = 20,
                    PaintingId = 7,
                    LanguageId = 2,
                    Name = "Achilles en de dochters van Lycomedes",
                    Description = "Aan Thetis was voorspeld dat haar zoon Achilles in de Trojaanse Oorlog zou sneuvelen. Om dit lot te omzeilen, verborg ze hem verkleed als vrouw aan het hof van koning Lycomedes. Voor de Griekse aanvoerders Odysseus en Diomedes was Achilles echter onmisbaar. Ze kwamen zijn schuilplaats te weten, en met een list wilden ze hem ontmaskeren. De twee legeraanvoerders gaven geschenken, waaronder wapens, aan de dochters van Lycomedes, met onder hen de verklede Achilles. Spontaan greep Achilles naar een helm en een zwaard, waardoor hij zichzelf verraadde."
	                    +"Links op het voorplan van het schilderij zijn Odysseus en Diomedes afgebeeld. Eén van hen grijpt Achilles bij zijn mouw, op het moment dat hij een helm past en een wapen grijpt uit de geschenken die rechts in een mand zitten en waarrond de dochters van Lycomedes zich scharen. Het tafereel speelt zich af op een terras, met links een doorkijk naar een tuin. "
	                    +"De Antwerpse schilder Erasmus Quellinus II behoorde tot een familie van beeldhouwers, schilders, etsers en houtsnijders. Hij was leerling en medewerker van Peter Paul Rubens, die hij als stadsschilder van Antwerpen opvolgde. (Naar: H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 143.)",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/1991_GRO0007_I"
                },
                new PaintingTranslation
                {
                    Id = 21,
                    PaintingId = 7,
                    LanguageId = 3,
                    Name = "Achilles among the Daughters of Lycomedes",
                    Description = "Thetis was predicted that her son Achilles would be killed in the Trojan War. To avoid this fate, she hid him dressed as a woman at the court of King Lycomedes. For the Greek captains Odysseus and Diomedes, however, Achilles was indispensable. They found out about his hiding place, and with a trick they wanted to expose him. The two commanders gave gifts, including weapons, to the daughters of Lycomedes, including the dressed Achilles. Spontaneously Achilles grabbed a helmet and a sword, by which he betrayed himself. On the left in the foreground of the painting Odysseus and Diomedes are depicted. One of them grabs Achilles by the sleeve, as soon as he fits a helmet and grabs a weapon from the gifts that are in a basket on the right and around which the daughters of Lycomedes gather. The scene takes place on a terrace, with on the left a view of a garden. The Antwerp painter Erasmus Quellinus II belonged to a family of sculptors, painters, etchers and woodcarvers. He was a pupil and collaborator of Peter Paul Rubens, whom he succeeded as a city painter of Antwerp (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 143.)",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/1991_GRO0007_I"
                },
                new PaintingTranslation
                {
                    Id = 22,
                    PaintingId = 8,
                    LanguageId = 1,
                    Name = "Portrait de Samuel Crew",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/2012_GRO0001_I"
                },
                new PaintingTranslation
                {
                    Id = 23,
                    PaintingId = 8,
                    LanguageId = 2,
                    Name = "Portret van Samuel Crew",
                    Description = "Het betreft een vroeg portret van Lely ut 1650 van Samuel Crew, of zijn broer Nathaniel Crew, telgen van een belangrijke Engelse familie en beide protestantse priesters. Hun vader John Crew of Stene was lid van het Engelse Parliament en fungeerde tussen 1623 en 1625 als Speaker of the House. Lely wilde met dit portret duidelijk aan de verwachtingen van zijn opdrachtgever en zijn belangrijkste mecenas voldoen. Met grote virtuositeit - waarin reflecties van de portretkunst van Frans Hals zijn te herkennen - schildert Lely de kledij van de jonge heer (vermoedelijk Samuel), met veel aandacht voor de textuur en de lichtinval op het zwarte textiel. Het witte hemd schittert in het midden van de donkere, eerder sombere sfeer van het schilderij. Alleen het gelaat en de haren zijn door de lichtinval duidelijk benadrukt. Gedurfd toont Lely zijn model niet in het centrum van het doek, maar positioneert hij de jongeman net uit de middenas van het schilderij. Op die manier vermijdt hij het formalisme van portretten.",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/2012_GRO0001_I"
                },
                new PaintingTranslation
                {
                    Id = 24,
                    PaintingId = 8,
                    LanguageId = 3,
                    Name = "Portrait of Samuel Crew",
                    Description = "This is an early portrait of Lely from 1650 of Samuel Crew, or his brother Nathaniel Crew, descendants of an important English family and both Protestant priests. Their father John Crew of Stene was a member of the English Parliament and served as Speaker of the House between 1623 and 1625. With this portrait Lely clearly wanted to meet the expectations of his client and his most important patron. With great virtuosity - in which reflections of the portrait art of Frans Hals can be recognised - Lely paints the clothing of the young gentleman (presumably Samuel), with great attention to the texture and the incidence of light on the black textile. The white shirt shines in the middle of the dark, rather sombre atmosphere of the painting. Only the face and hair are clearly emphasized by the incidence of light. Lely does not boldly show his model in the centre of the canvas, but positions the young man just out of the middle axis of the painting. In this way he avoids the formalism of portraits.",
                    SourceLink = "http://groeningemuseum.be/collection/work/data/2012_GRO0001_I"
                },
                new PaintingTranslation
                {
                    Id = 25,
                    PaintingId = 9,
                    LanguageId = 1,
                    Name = "La Vocation de saint Matthieu",
                    Description = null,
                    SourceLink = null
                },
                new PaintingTranslation
                {
                    Id = 26,
                    PaintingId = 9,
                    LanguageId = 2,
                    Name = "Roeping van Mattheüs",
                    Description = null,
                    SourceLink = null
                },
                new PaintingTranslation
                {
                    Id = 27,
                    PaintingId = 9,
                    LanguageId = 3,
                    Name = "The Calling of St Matthew",
                    Description = null,
                    SourceLink = null
                },
                new PaintingTranslation
                {
                    Id = 28,
                    PaintingId = 1,
                    LanguageId = 4,
                    Name = "Waldlandschaft mit Furt",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I"
                },
                new PaintingTranslation
                {
                    Id = 29,
                    PaintingId = 2,
                    LanguageId = 4,
                    Name = "Porträt einer Brüggener Familie",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0181_I"
                },
                new PaintingTranslation
                {
                    Id = 30,
                    PaintingId = 3,
                    LanguageId = 4,
                    Name = "Porträt eines Theologen mit seinem Sekretär",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0184_I"
                },
                new PaintingTranslation
                {
                    Id = 31,
                    PaintingId = 4,
                    LanguageId = 4,
                    Name = "Porträt eines Mannes",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0187_I"
                },
                new PaintingTranslation
                {
                    Id = 32,
                    PaintingId = 5,
                    LanguageId = 4,
                    Name = "Heilige Dreifaltigkeit",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0374_I"
                },
                new PaintingTranslation
                {
                    Id = 33,
                    PaintingId = 6,
                    LanguageId = 4,
                    Name = "Porträt des Fovin de Hasque",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO1346_I"
                },
                new PaintingTranslation
                {
                    Id = 34,
                    PaintingId = 7,
                    LanguageId = 4,
                    Name = "Achilles unter den Töchtern des Lycomedes",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/1991_GRO0007_I"
                },
                new PaintingTranslation
                {
                    Id = 35,
                    PaintingId = 8,
                    LanguageId = 4,
                    Name = "Porträt des Samuel Crew",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/2012_GRO0001_I"
                },
                new PaintingTranslation
                {
                    Id = 36,
                    PaintingId = 9,
                    LanguageId = 4,
                    Name = "Berufung des Hl. Matthäus",
                    Description = null,
                    SourceLink = null
                },
                new PaintingTranslation
                {
                    Id = 37,
                    PaintingId = 1,
                    LanguageId = 5,
                    Name = "Paisaje boscoso con fuerte",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I"
                },
                new PaintingTranslation
                {
                    Id = 38,
                    PaintingId = 2,
                    LanguageId = 5,
                    Name = "Retrato de una familia de Brujas",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0181_I"
                },
                new PaintingTranslation
                {
                    Id = 39,
                    PaintingId = 3,
                    LanguageId = 5,
                    Name = "Retrato de un Teólogo y su secretario",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0184_I"
                },
                new PaintingTranslation
                {
                    Id = 40,
                    PaintingId = 4,
                    LanguageId = 5,
                    Name = "Retrato de un hombre",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0187_I"
                },
                new PaintingTranslation
                {
                    Id = 41,
                    PaintingId = 5,
                    LanguageId = 5,
                    Name = "Santa Trinidad",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0374_I"
                },
                new PaintingTranslation
                {
                    Id = 42,
                    PaintingId = 6,
                    LanguageId = 5,
                    Name = "Retrato de Fovin de Hasque",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO1346_I"
                },
                new PaintingTranslation
                {
                    Id = 43,
                    PaintingId = 7,
                    LanguageId = 5,
                    Name = "Achilles entre las hijas de Licomedes",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/1991_GRO0007_I"
                },
                new PaintingTranslation
                {
                    Id = 44,
                    PaintingId = 8,
                    LanguageId = 5,
                    Name = "Retrato de Samuel Crew",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/2012_GRO0001_I"
                },
                new PaintingTranslation
                {
                    Id = 45,
                    PaintingId = 9,
                    LanguageId = 5,
                    Name = "El llamado de San Mateo",
                    Description = null,
                    SourceLink = null
                }
            );

            modelBuilder.Entity<PaintingAudio>()
            .HasData(
                new PaintingAudio
                {
                    Id = 1,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/2605365f663a409689f5e4fb409ef06033f428359b984682b165594a41082bdc/browse.mp3",
                    LanguageId = 2,
                    PaintingId = 8
                },
                new PaintingAudio
                {
                    Id = 2,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3e8fb0bb92834c8b8f61e4c14a0a09fd4099d22acea84b15bb821ed373eef072/browse.mp3",
                    LanguageId = 2,
                    PaintingId = 7
                },
                new PaintingAudio
                {
                    Id = 3,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5447d829839d421ebc7cd543bdc5f06a242838ec18164dfd878bedda52e33c6e/browse.mp3",
                    LanguageId = 2,
                    PaintingId = 2
                },
                new PaintingAudio
                {
                    Id = 4,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5f7e3285958144f7aa133b0fdb17e88a2c50a93ebd834eab8a2797c369b99527/browse.mp3",
                    LanguageId = 1,
                    PaintingId = 8
                },
                new PaintingAudio
                {
                    Id = 5,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/344d1355bb884f6d9014b16286cf042ecf0e1656ab2043dc8e5ac7cd7773b9ad/browse.mp3",
                    LanguageId = 1,
                    PaintingId = 7
                },
                new PaintingAudio
                {
                    Id = 6,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/59817bb85c9e466a81744e8ffe1d7ff4034405a2da0a4ca9b2fc3545306816db/browse.mp3",
                    LanguageId = 1,
                    PaintingId = 2
                },
                new PaintingAudio
                {
                    Id = 7,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/48641ebd9e794a7a8fb2f579990e4af155eea4585d12466591e87f3fd3d5dd99/browse.mp3",
                    LanguageId = 3,
                    PaintingId = 8
                },
                new PaintingAudio
                {
                    Id = 8,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/d6cc25006af94b7b8b749b30edfcb884bc05e0524da54a55ae15476bf049b0f6/browse.mp3",
                    LanguageId = 3,
                    PaintingId = 7
                },
                new PaintingAudio
                {
                    Id = 9,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/f98ec09a7afa4264957cdaffb526d5d56daae87302ad4f20a099eac5371e6803/browse.mp3",
                    LanguageId = 3,
                    PaintingId = 2
                },
                new PaintingAudio
                {
                    Id = 10,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/f5d86614bfca40e886bd131c4cc22e236c0eb61eeb7b41868fc60a4e6f0fed0e/browse.mp3",
                    LanguageId = 4,
                    PaintingId = 8
                },
                new PaintingAudio
                {
                    Id = 11,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ba8fa7ca81be44d4beb2c7151d2d3f9bad3428e0c5af4ad9a054d2df1301a609/browse.mp3",
                    LanguageId = 4,
                    PaintingId = 7
                },
                new PaintingAudio
                {
                    Id = 12,
                    Name = null,
                    AudioUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/68a8083495404f51af3ef6cc65d28192fc390fb6e39d4fe682ba7de2178209e3/browse.mp3",
                    LanguageId = 4,
                    PaintingId = 2
                }
            );

            modelBuilder.Entity<PaintingStory>()
            .HasData(
                /* Schilderij A - Achtschellinck */
                /*
                new PaintingStory
                {
                    Id = 4,
                    Subtitle = "over het kunstwerk",
                    Type = "artwork",
                    Title = "Boslandschap met wad",
                    Text = "De schilder gebruikte ruwe schilder stroken om de blaadjes aan de bomen te schilderen, niet blaadje per blaadje apart",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ce8835fad1b4288b17e627fa9fcbedf5d8a7c0ff5064c99be988e13675c8047/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 1
                },
                new PaintingStory
                {
                    Id = 7,
                    Subtitle = "about the artwork",
                    Type = "artwork",
                    Title = "Wooded Landscape with Ford",
                    Text = "The painter used raw brush strokes to paint the leaves on the trees, not every leave separately.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ce8835fad1b4288b17e627fa9fcbedf5d8a7c0ff5064c99be988e13675c8047/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 1
                },
                new PaintingStory
                {
                    Id = 1,
                    Title = "Paysage boisé avec gué",
                    Type = "artwork",
                    Subtitle = "à propos de l'oeuvre",
                    Text = "Les feuilles sur les arbres ne sont en fait pas peintes une à une mais à coups de pinceaux",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ce8835fad1b4288b17e627fa9fcbedf5d8a7c0ff5064c99be988e13675c8047/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 1
                },
                */
                new PaintingStory
                {
                    Id = 5,
                    Title = "Barok",
                    Type = "style",
                    Subtitle = "over de stijlperiode",
                    Text = "Het woord barok komt van het Portugese barroco, wat 'onregelmatig gevormde parel' betekent.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/cf4aebd4aa6b44a4b86806c3f5d1fb41ee9536c041a44dc2b4f229191f930b3d/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 1
                },
                new PaintingStory
                {
                    Id = 8,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "about the movement",
                    Text = "The word baroque comes from the Portuguese barroco, which means 'irregularly shaped pearl'.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/cf4aebd4aa6b44a4b86806c3f5d1fb41ee9536c041a44dc2b4f229191f930b3d/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 1
                },
                new PaintingStory
                {
                    Id = 2,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "à propos du mouvement",
                    Text = "Le mot baroque vient du portugais barroco, qui signifie 'perle de forme irrégulière'.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/cf4aebd4aa6b44a4b86806c3f5d1fb41ee9536c041a44dc2b4f229191f930b3d/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 1
                },
                new PaintingStory
                {
                    Id = 6,
                    Title = "Olieverf",
                    Type = "technique",
                    Subtitle = "over de techniek",
                    Text = "Voordat olieverf werd uitgevonden gebruikten de meeste kunstenaars tempera, een verfsoort waarbij pigment gemengd werd met eigeel als bindmiddel.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/8e39500528c246ce8bfed9ff55140c14757edb0488824ddebc414be4c8654f71/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 1
                },
                new PaintingStory
                {
                    Id = 9,
                    Title = "Oil paint",
                    Type = "technique",
                    Subtitle = "about the technique",
                    Text = "Before oil paint was invented, most artists used tempera, a type of paint in which pigment was mixed with egg yolk as a binding agent.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/8e39500528c246ce8bfed9ff55140c14757edb0488824ddebc414be4c8654f71/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 1
                },
                new PaintingStory
                {
                    Id = 3,
                    Title = "Peinture à l’huile",
                    Type = "technique",
                    Subtitle = "à propos de la technique",
                    Text = "Avant l'invention de la peinture à l'huile, la plupart des artistes utilisaient la détrempe, un type de peinture dans lequel le pigment était mélangé au jaune d'œuf comme liant.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/8e39500528c246ce8bfed9ff55140c14757edb0488824ddebc414be4c8654f71/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 1
                },

                /* Jacob van Oost - code B */
                new PaintingStory
                {
                    Id = 13,
                    Subtitle = "Over het kunstwerk",
                    Type = "artwork",
                    Title = "Portret van een Brugse familie",
                    Text = "De leeftijd van de personen is weergegeven op allerlei details in het kunstwerk zoals de kledij.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/21643469958c454583ed0e84aa5a527478c3e5f9e24d477ab0a42b26b2c30519/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 2
                },
                new PaintingStory
                {
                    Id = 16,
                    Subtitle = "About the artwork",
                    Type = "artwork",
                    Title = "Portrait of a Bruges family",
                    Text = "The age of the persons is reflected in all kinds of details in the artwork such as the clothing.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/21643469958c454583ed0e84aa5a527478c3e5f9e24d477ab0a42b26b2c30519/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 2
                },
                new PaintingStory
                {
                    Id = 10,
                    Subtitle = "à propos de l'oeuvre",
                    Type = "artwork",
                    Title = "Portrait d'une famille brugeoise",
                    Text = "L'âge des personnes se reflète dans toutes sortes de détails de l'œuvre d'art, comme les vêtements.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/21643469958c454583ed0e84aa5a527478c3e5f9e24d477ab0a42b26b2c30519/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 2
                },
                /*
                new PaintingStory
                {
                    Id = 11,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "à propos du mouvement",
                    Text = "Les oeuvres catholiques baroques étaient souvent larges",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5fdb481bb5f94f8697556ba58a986b659d9bfd331a374ad9810a549d601c2627/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 2
                },
                new PaintingStory
                {
                    Id = 12,
                    Title = "Peinture à l’huile",
                    Type = "technique",
                    Subtitle = "à propos de la technique",
                    Text = "Le bleu ultramarine était fabriqué avec du lapis lazuli qui était très onéreux. Après l’avoir mélangé avec l’huile, la peinture était conservée dans une vessie de porc",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e346459340324138861abea18b6c87d2d65c583136a44fb8906007a69871cc23/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 2
                },
                new PaintingStory
                {
                    Id = 14,
                    Title = "Barok",
                    Type = "style",
                    Subtitle = "over de stijlperiode",
                    Text = "Katholieke barok kunstwerken waren doorgaans groot",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5fdb481bb5f94f8697556ba58a986b659d9bfd331a374ad9810a549d601c2627/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 2
                },
                new PaintingStory
                {
                    Id = 15,
                    Title = "Olieverf",
                    Type = "technique",
                    Subtitle = "over de techniek",
                    Text = "Ultramarijnblauw werd gemaakt met lapis lazuli, iets wat zeer duur was. Na het mixen met olie werd het vaak bewaard in een varkensblaas",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e346459340324138861abea18b6c87d2d65c583136a44fb8906007a69871cc23/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 2
                },
                new PaintingStory
                {
                    Id = 17,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "about the movement",
                    Text = "Catholic baroque works were usually large",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5fdb481bb5f94f8697556ba58a986b659d9bfd331a374ad9810a549d601c2627/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 2
                },
                new PaintingStory
                {
                    Id = 18,
                    Title = "Oil paint",
                    Type = "technique",
                    Subtitle = "about the technique",
                    Text = "Ultramarine blue was made with lapis lazuli, which was very expensive. After mixing it with the oil, it was often stored in a pig’s bladder",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e346459340324138861abea18b6c87d2d65c583136a44fb8906007a69871cc23/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 2
                },
                */
                /* Schilderij C - Jacob van Oost */
                new PaintingStory
                {
                    Id = 22,
                    Subtitle = "over het kunstwerk",
                    Type = "artwork",
                    Title = "Portret van een theoloog met zijn secretaris",
                    Text = "Het schilderij dateert uit 1668. Op het opschrift lezen we 'AETETIS 47' = op de leeftijd van 47. Zijn identiteit is tot op de dag van vandaag nog steeds onbekend.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dc1418bab7c3496c8c37befdb6b1247befd3d5a280b94fe0a33069adeda7f976/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 3
                },
                new PaintingStory
                {
                    Id = 25,
                    Subtitle = "About the artwork",
                    Type = "artwork",
                    Title = "Portrait of a Theologue and his Secretary",
                    Text = "The painting dates from 1668. On the inscription we read 'AETETIS 47' = at the age of 47. His identity is still unknown to this day.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dc1418bab7c3496c8c37befdb6b1247befd3d5a280b94fe0a33069adeda7f976/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 3
                },
                new PaintingStory
                {
                    Id = 19,
                    Subtitle = "à propos de l'oeuvre",
                    Type = "artwork",
                    Title = "Portrait d’un théologien et son secrétaire",
                    Text = "Le tableau date de 1668. Sur l'inscription on peut lire 'AETETETIS 47' = à l'âge de 47 ans. Son identité reste à ce jour inconnue.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/dc1418bab7c3496c8c37befdb6b1247befd3d5a280b94fe0a33069adeda7f976/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 3
                },
                new PaintingStory
                {
                    Id = 23,
                    Title = "Barok",
                    Type = "style",
                    Subtitle = "over de stijlperiode",
                    Text = "Barokkunst werd vaak gemaakt als religieuze propaganda.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ad098f654134125a19bb3c8b8163bfe5361b523e12f46009f305c05eab9eb3d/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 3
                },
                new PaintingStory
                {
                    Id = 26,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "about the movement",
                    Text = "Baroque art was made for religious propaganda",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ad098f654134125a19bb3c8b8163bfe5361b523e12f46009f305c05eab9eb3d/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 3
                },
                new PaintingStory
                {
                    Id = 20,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "à propos du mouvement",
                    Text = "L’art baroque servait à la propagande religieuse",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ad098f654134125a19bb3c8b8163bfe5361b523e12f46009f305c05eab9eb3d/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 3
                },
                new PaintingStory
                {
                    Id = 24,
                    Title = "Olieverf",
                    Type = "technique",
                    Subtitle = "over de techniek",
                    Text = "Witte verf werd gemaakt uit lood. Het droogde snel en bedekte goed, maar was heel giftig. Hierdoor had je als kunstschilder het risico een loodvergiftiging op te lopen.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e7ca0f24fe4d4a1b823eb466855c9735b470aaf39bfc4cb197203c76adafaa98/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 3
                },
                new PaintingStory
                {
                    Id = 27,
                    Title = "Oil paint",
                    Type = "technique",
                    Subtitle = "about the technique",
                    Text = "White paint was made of lead. It dried quickly and covered well, but was very toxic. As a painter, you risked getting lead poisoning.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e7ca0f24fe4d4a1b823eb466855c9735b470aaf39bfc4cb197203c76adafaa98/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 3
                },
                new PaintingStory
                {
                    Id = 21,
                    Title = "Peinture à l’huile",
                    Type = "technique",
                    Subtitle = "à propos de la technique",
                    Text = "La peinture blanche était faite de plomb. Il séchait rapidement et couvrait bien, mais il était très toxique. Comme peintre, vous avez risqué un empoisonnement au plomb.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e7ca0f24fe4d4a1b823eb466855c9735b470aaf39bfc4cb197203c76adafaa98/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 3
                },

                /* Jacob van Oost II - code D */
                new PaintingStory
                {
                    Id = 31,
                    Title = "Portret van een man",
                    Type = "style",
                    Subtitle = "over het kunstwerk ",
                    Text = "Het schilderij is ondertekend en gedateerd op de achterkant: 'J. van Oost als vrient / 1697'.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/d5828eddf70640fe95b7e2d861e68d65f7814194062b497e9159d47ba7edd5e1/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 4
                },
                new PaintingStory
                {
                    Id = 34,
                    Title = "Portrait of a Man",
                    Type = "style",
                    Subtitle = "about the artwork",
                    Text = "The painting is signed and dated on the back: 'J. van Oost as friend / 1697'.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/d5828eddf70640fe95b7e2d861e68d65f7814194062b497e9159d47ba7edd5e1/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 4
                },
                new PaintingStory
                {
                    Id = 28,
                    Title = "Portrait d' un homme",
                    Type = "style",
                    Subtitle = "à propos de l'oeuvre",
                    Text = "Le tableau est signé et daté au dos: 'J. van Oost comme ami / 1697'.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/d5828eddf70640fe95b7e2d861e68d65f7814194062b497e9159d47ba7edd5e1/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 4
                },
                /*
                new PaintingStory
                {
                    Id = 29,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "à propos du mouvement",
                    Text = "Les artistes créaient des innovations pour rendre leurs oeuvres plus réalistes et émotives",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5a47b5970737453b816a29a596b25ff9f37f58290f9b4ab18521a5ce7b610ad3/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 4
                },
                new PaintingStory
                {
                    Id = 30,
                    Title = "Peinture à l’huile",
                    Type = "style",
                    Subtitle = "à propos de la technique ",
                    Text = "Jusqu’au 19ème siècle, les peintres préparaient leurs propres couleurs, en expérimentant",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/efd4bf7eedcc4d768d02849291c823abd947d1a712a04e70980bc3e1086273b9/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 4
                },
                new PaintingStory
                {
                    Id = 32,
                    Title = "Barok",
                    Type = "style",
                    Subtitle = "over de stijlperiode ",
                    Text = "Kunstenaars creëerden innovaties om hun werk realistischer en gevoeliger te maken",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5a47b5970737453b816a29a596b25ff9f37f58290f9b4ab18521a5ce7b610ad3/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 4
                },
                new PaintingStory
                {
                    Id = 33,
                    Title = "Olieverf",
                    Type = "style",
                    Subtitle = "over de techniek ",
                    Text = "Tot de 19e eeuw, schilders maakten hun eigen kleuren op basis van ervaring",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/efd4bf7eedcc4d768d02849291c823abd947d1a712a04e70980bc3e1086273b9/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 4
                },
                new PaintingStory
                {
                    Id = 35,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "about the movement",
                    Text = "Artists created innovations to make their works more realistic and emotive",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5a47b5970737453b816a29a596b25ff9f37f58290f9b4ab18521a5ce7b610ad3/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 4
                },
                new PaintingStory
                {
                    Id = 36,
                    Title = "Oil paint",
                    Type = "style",
                    Subtitle = "about the technique",
                    Text = "Until the 19th century, painters prepared their own colors based on experience.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/efd4bf7eedcc4d768d02849291c823abd947d1a712a04e70980bc3e1086273b9/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 4
                },
                */

                /* Schilderij E - Artus Wolfordt */
                new PaintingStory
                {
                    Id = 40,
                    Title = "Heilige Drievuldigheid",
                    Type = "artwork",
                    Subtitle = "over het kunstwerk",
                    Text = "Dit schilderij werd aan verschillende kunstenaars toegeschreven, onder andere aan Rubens. Pas in de jaren 1990 werd het toegeschreven aan Wolfordt.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/cfac3520af784cae8d957005692eafd8dd3fa80f861c480c99f71b59e0742a72/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 5
                },
                new PaintingStory
                {
                    Id = 43,
                    Title = "Holy Trinity",
                    Type = "artwork",
                    Subtitle = "about the artwork",
                    Text = "This painting was attributed to various artists, including Rubens. It was not until the 1990s that it was attributed to Wolfordt.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/cfac3520af784cae8d957005692eafd8dd3fa80f861c480c99f71b59e0742a72/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 5
                },
                new PaintingStory
                {
                    Id = 37,
                    Title = "Sainte Trinité",
                    Type = "artwork",
                    Subtitle = "à propos de l'oeuvre",
                    Text = "Ce tableau a été attribué à divers artistes, dont Rubens. Ce n'est que dans les années 1990 qu'il a été attribué à Wolfordt.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/cfac3520af784cae8d957005692eafd8dd3fa80f861c480c99f71b59e0742a72/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 5
                },
                new PaintingStory
                {
                    Id = 41,
                    Title = "Barok",
                    Type = "style",
                    Subtitle = "over de stijlperiode",
                    Text = "Het schilderen van religieuze scènes werd gebruikt om de ongeletterde bevolking het verhaal te doen begrijpen.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/04ca66af841a4449a7dfe6b83c74d92593135c754d6a4f37b68c9914f7829cb8/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 5
                },
                new PaintingStory
                {
                    Id = 44,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "about the movement",
                    Text = "Painting of religious scenes was used for religious instruction for the illiterate population",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/04ca66af841a4449a7dfe6b83c74d92593135c754d6a4f37b68c9914f7829cb8/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 5
                },
                new PaintingStory
                {
                    Id = 38,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "à propos du mouvement",
                    Text = "La peinture de scènes religieuses servait à enseigner la religion à la population analphabète",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/04ca66af841a4449a7dfe6b83c74d92593135c754d6a4f37b68c9914f7829cb8/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 5
                },
                /*
                new PaintingStory
                {
                    Id = 39,
                    Title = "Peinture à l’huile",
                    Type = "style",
                    Subtitle = "à propos de la technique",
                    Text = "Les peintres expérimentent l’épaisseur de la pâte pour accentuer les lumières",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03c88b6c0857421985c8afe512996d300f59c58603f54e5a8a9371fad4d2c919/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 5
                },
                new PaintingStory
                {
                    Id = 42,
                    Title = "Olieverf",
                    Type = "style",
                    Subtitle = "over de techniek",
                    Text = "Schilders beginnen te experimenteren met de dikte van de verf om het licht te accentueren",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03c88b6c0857421985c8afe512996d300f59c58603f54e5a8a9371fad4d2c919/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 5
                },
                new PaintingStory
                {
                    Id = 45,
                    Title = "Oil paint",
                    Type = "style",
                    Subtitle = "about the technique",
                    Text = "Painters start to experiment with the thickness of the paint to accentuate the light",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03c88b6c0857421985c8afe512996d300f59c58603f54e5a8a9371fad4d2c919/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 5
                },
                */

                /* Schilderij F - Jacob van Oost */
                new PaintingStory
                {
                    Id = 49,
                    Title = "Portret van Fovin de Hasque",
                    Type = "artwork",
                    Subtitle = "over het kunstwerk",
                    Text = "Fovin de Hasque was schermmeester van de Brugse Sint-Michielsgilde, de oudst bekende schermersgilde in Vlaanderen.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ff432946d096434684d808320dde4bf02f871a55fcd94d47a0627365096384a1/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 6
                },
                new PaintingStory
                {
                    Id = 52,
                    Title = "Portrait of Fovin de Hasque",
                    Type = "artwork",
                    Subtitle = "about the artwork",
                    Text = "Fovin de Hasque was fencer of the Bruges St Michael's Guild, the oldest known fencer's guild in Flanders.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ff432946d096434684d808320dde4bf02f871a55fcd94d47a0627365096384a1/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 6
                },
                new PaintingStory
                {
                    Id = 46,
                    Title = "Portrait de Fovin de Hasque",
                    Type = "style",
                    Subtitle = "à propos de l'oeuvre",
                    Text = "Fovin de Hasque était escrimeur de la guilde St Michel de Bruges, la plus ancienne guilde d'escrime connue en Flandre.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ff432946d096434684d808320dde4bf02f871a55fcd94d47a0627365096384a1/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 6
                },
                /*
                new PaintingStory
                {
                    Id = 50,
                    Title = "Barok",
                    Type = "style",
                    Subtitle = "over de stijlperiode",
                    Text = "De barokstijl werd een symbool van rijkdom en macht",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/fecdb0f11ba34090822eafcc87302d21ca86d20df97b4fbe92d455ccd29a4e78/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 6
                },
                new PaintingStory
                {
                    Id = 53,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "about the movement",
                    Text = "The baroque style became a symbol of wealth and power",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/fecdb0f11ba34090822eafcc87302d21ca86d20df97b4fbe92d455ccd29a4e78/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 6
                },
                new PaintingStory
                {
                    Id = 47,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "à propos du mouvement",
                    Text = "Le style baroque devint un symbole de richesse et pouvoir",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/fecdb0f11ba34090822eafcc87302d21ca86d20df97b4fbe92d455ccd29a4e78/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 6
                },
                new PaintingStory
                {
                    Id = 51,
                    Title = "Olieverf",
                    Type = "technique",
                    Subtitle = "over de techniek",
                    Text = "Sinds 1841, olieverf was verkrijgbaar in metalen tubes. Nu konden kunstenaars buiten schilderen",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3931908a115a4e229c153dcf4468422282c74814f999464681d5ba1a28b18885/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 6
                },
                new PaintingStory
                {
                    Id = 54,
                    Title = "Oil paint",
                    Type = "technique",
                    Subtitle = "about the technique",
                    Text = "Since 1841, oil paint has been available in metal tube. Now, artists could go and paint outdoors",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3931908a115a4e229c153dcf4468422282c74814f999464681d5ba1a28b18885/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 6
                },
                new PaintingStory
                {
                    Id = 48,
                    Title = "Peinture à l’huile",
                    Type = "technique",
                    Subtitle = "à propos de la technique",
                    Text = "Depuis 1841, la peinture à l’huile est disponible dans des tubes de métal. Les artistes peuvent maintenant sortir et peindre à l’extérieur",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3931908a115a4e229c153dcf4468422282c74814f999464681d5ba1a28b18885/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 6
                },
                */

                /* Schilderij G - Quellinus */
                new PaintingStory
                {
                    Id = 58,
                    Title = "Achilles en de dochters van Lycomedes",
                    Type = "artwork",
                    Subtitle = "over het kunstwerk",
                    Text = "Dit verhaal is gebaseerd op verschillende schilderijen. Deze compositie gaat terug op een ontwerp voor een wandtapijt van Rubens over de Griekse held Achilles. Quellinus zelf schilderde drie verschillende versies van deze scène.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e8e022bf0ba64c549c9bba866d0e6a27cf21a60091304920b5aa3f1858c655e3/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 7
                },
                new PaintingStory
                {
                    Id = 61,
                    Title = "Achilles among the Daughters of Lycomedes",
                    Type = "artwork",
                    Subtitle = "about the artwork",
                    Text = "This story is based on several paintings. This composition goes back to a design for a tapestry by Rubens about the Greek hero Achilles. Quellinus himself painted three different versions of this scene.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e8e022bf0ba64c549c9bba866d0e6a27cf21a60091304920b5aa3f1858c655e3/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 7
                },
                new PaintingStory
                {
                    Id = 55,
                    Title = "Achille parmi les filles de Lycomède",
                    Type = "artwork",
                    Subtitle = "à propos de l'oeuvre",
                    Text = "Cette histoire est basée sur plusieurs tableaux. Cette composition remonte à la conception d'une tapisserie de Rubens sur le héros grec Achille. Quellinus lui-même a peint trois versions différentes de cette scène.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e8e022bf0ba64c549c9bba866d0e6a27cf21a60091304920b5aa3f1858c655e3/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 7
                },
                new PaintingStory
                {
                    Id = 83,
                    Title = "Achilles en de dochters van Lycomedes",
                    Type = "artwork",
                    Subtitle = "over het kunstwerk",
                    Text = "Achilles had een geheime relatie met Deidamia, een van de zeven dochters van koning Lycomedes. Ze kijkt hier triest omdat ze weet dat Achilles haar zal verlaten.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 7
                },
                new PaintingStory
                {
                    Id = 84,
                    Title = "Achilles among the Daughters of Lycomedes",
                    Type = "artwork",
                    Subtitle = "about the artwork",
                    Text = "Achilles had a secret relationship with Deidamia, one of the seven daughters of King Lycomedes. She looks sad here because she knows that Achilles will leave her.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 7
                },
                new PaintingStory
                {
                    Id = 82,
                    Title = "Achille parmi les filles de Lycomède",
                    Type = "style",
                    Subtitle = "à propos de l'oeuvre",
                    Text = "Achille avait une relation secrète avec Deidamia, une des sept filles du roi Lycomède. Elle a l'air triste parce qu'elle sait qu'Achille va la quitter.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 7
                },
                /*
                new PaintingStory
                {
                    Id = 56,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "à propos du mouvement",
                    Text = "La peinture baroque utilise des couleurs chaudes et vives ainsi que des contrastes (clair/obscur). La toile est éclairée par tâches contrairement au style de la  Renaissance ayant un éclairage uniforme de la toile",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 7
                },
                new PaintingStory
                {
                    Id = 57,
                    Title = "Peinture à l’huile",
                    Type = "style",
                    Subtitle = "à propos de la technique",
                    Text = "La peinture à l’huile met plus de temps à sécher  que d’autres types de peinture (environ 2 semaines, bien que certaines couleurs sèchent en quelques jours). De ce fait, le peintre pouvait enlever une couche complète de peinture et en recommencer une nouvelle",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ddd295ab406349bcaabd41e04e4aa7d3fa4285c4e274469ca4f84a09c82f7864/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 7
                },
                new PaintingStory
                {
                    Id = 59,
                    Title = "Barok",
                    Type = "style",
                    Subtitle = "over de stijlperiode",
                    Text = "Barok schilderijen maakt gebruik van warme en levendige kleuren en contrasten (Chiaroscuro). De verlichting van het schilderij concentreerde zich op sommige punten terwijl de Renaissance-stijl een consistente verlichting had",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 7
                },
                new PaintingStory
                {
                    Id = 60,
                    Title = "Olieverf",
                    Type = "style",
                    Subtitle = "over de techniek",
                    Text = "Omdat olieverf langer nat blijft dan andere verfsoorten, kan de schilder zijn verf langer bewaren. Het duurt meestal twee weken om te drogen (hoewel sommige kleuren binnen dagen drogen)",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ddd295ab406349bcaabd41e04e4aa7d3fa4285c4e274469ca4f84a09c82f7864/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 7
                },
                new PaintingStory
                {
                    Id = 62,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "about the movement",
                    Text = "Baroque painting uses warm and vivid colors as well as contrasts (Chiaroscuro). The painting’s lighting focused on some points while the Renaissance style had a consistent lighting",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 7
                },
                new PaintingStory
                {
                    Id = 63,
                    Title = "Oil paint",
                    Type = "style",
                    Subtitle = "about the technique",
                    Text = "As oil paint remains wet longer than other types of paint, the painter might remote an entire layer of paint. It usually takes a span of two weeks to dry (although some colors dry within days)",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ddd295ab406349bcaabd41e04e4aa7d3fa4285c4e274469ca4f84a09c82f7864/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 7
                },
                */
                /** H. Peter Lely **/
                new PaintingStory
                {
                    Id = 67,
                    Title = "Portret van Samuel Crew",
                    Type = "artwork",
                    Subtitle = "over het kunstwerk",
                    Text = "Peter Lely (geboren als Pieter van der Faes) studeerde in Haarlem. Hij werd bekend onder de naam Lely vanwege de afbeelding van een lelie op het huis van zijn vader in Den Haag.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5d9dc2d4aa554328a7fc82837d1f9aa660898545b73d452e9ef0cd2909c610f1/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 8
                },
                new PaintingStory
                {
                    Id = 70,
                    Title = "Portrait of Samuel Crew",
                    Type = "artwork",
                    Subtitle = "about the artwork",
                    Text = "Peter Lely (born as Pieter van der Faes) studied in Haarlem. He became known as Lely because of the image of a lily on his father's house in The Hague.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5d9dc2d4aa554328a7fc82837d1f9aa660898545b73d452e9ef0cd2909c610f1/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 8
                },
                new PaintingStory
                {
                    Id = 64,
                    Title = "Portrait de Samuel Crew",
                    Type = "artwork",
                    Subtitle = "à propos de l'oeuvre",
                    Text = "Peter Lely (né Pieter van der Faes) a étudié à Haarlem. Il est connu sous le nom de Lely en raison de l'image d'un lys sur la maison de son père à La Haye.",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5d9dc2d4aa554328a7fc82837d1f9aa660898545b73d452e9ef0cd2909c610f1/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 8
                },
                /*
                new PaintingStory
                {
                    Id = 65,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "à propos du mouvement",
                    Text = "La peinture baroque se caractérise par l’asymétrie: le sujet n’est pas toujours au centre du tableau",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/d5500b6e47c64cbba935e3dc2d68f8d6d652dd7e5a2943ed8fccd4ba779d8fe9/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 8
                },
                new PaintingStory
                {
                    Id = 66,
                    Title = "Peinture à l’huile",
                    Type = "style",
                    Subtitle = "à propos de la technique",
                    Text = "L’avantage de la peinture à l’huile est qu’elle met plus de temps à sécher, ce qui permet au peintre de développer son oeuvre au fur et à mesure, contrairement à la tempéra aux oeufs",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/07e8711ec42e4a659843bc2de2e78657108b44bc1fa24dbdaaca756a3c33f1e9/browse.jpg",
                    LanguageId = 1,
                    PaintingId = 8
                },
                new PaintingStory
                {
                    Id = 68,
                    Title = "Barok",
                    Type = "style",
                    Subtitle = "over de stijlperiode",
                    Text = "Barok schilderijen wordt gekenmerkt door asymmetrie: het onderwerp staat niet altijd centraal in het schilderij",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/d5500b6e47c64cbba935e3dc2d68f8d6d652dd7e5a2943ed8fccd4ba779d8fe9/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 8
                },
                new PaintingStory
                {
                    Id = 69,
                    Title = "Olieverf",
                    Type = "style",
                    Subtitle = "over de techniek",
                    Text = "Het voordeel van olieverf is dat het langzaam droogt, waardoor de kunstenaar een schilderij geleidelijk kan ontwikkelen, in tegenstelling tot eitempera",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/07e8711ec42e4a659843bc2de2e78657108b44bc1fa24dbdaaca756a3c33f1e9/browse.jpg",
                    LanguageId = 2,
                    PaintingId = 8
                },
                new PaintingStory
                {
                    Id = 71,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "about the movement",
                    Text = "Baroque painting is characterised by asymmetry: the subject is not always at the center of the painting",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/d5500b6e47c64cbba935e3dc2d68f8d6d652dd7e5a2943ed8fccd4ba779d8fe9/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 8
                },
                new PaintingStory
                {
                    Id = 72,
                    Title = "Oil paint",
                    Type = "style",
                    Subtitle = "about the technique",
                    Text = "The advantage of oil paint is its slow drying which enables  the artist to develop a painting gradually, as opposed to egg tempera",
                    ImageUrl = "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/07e8711ec42e4a659843bc2de2e78657108b44bc1fa24dbdaaca756a3c33f1e9/browse.jpg",
                    LanguageId = 3,
                    PaintingId = 8
                },*/

                /** I.	Jacob van Oost, Roeping van Mattheüs **/
                new PaintingStory
                {
                    Id = 76,
                    Title = "Roeping van Mattheüs",
                    Type = "artwork",
                    Subtitle = "over het kunstwerk",
                    Text = "Mattheüs, de tollenaar, is op zijn rug afgebeeld. De hond symboliseert zijn trouw aan Jezus en aan zijn geloof.",
                    ImageUrl = "",
                    LanguageId = 2,
                    PaintingId = 9
                },
                new PaintingStory
                {
                    Id = 79,
                    Title = "The Calling of St Matthew",
                    Type = "artwork",
                    Subtitle = "about the artwork",
                    Text = "Matthew, the tax collector, is depicted on his back. The dog symbolizes his faithfulness to Jesus and to his faith.",
                    ImageUrl = "",
                    LanguageId = 3,
                    PaintingId = 9
                },
                 new PaintingStory
                {
                    Id = 73,
                    Title = "La Vocation de saint Matthieu",
                    Type = "artwork",
                    Subtitle = "à propos de l'oeuvre",
                    Text = "Matthieu, le percepteur, est représenté sur son dos. Le chien symbolise sa fidélité à Jésus et à sa foi.",
                    ImageUrl = "",
                    LanguageId = 1,
                    PaintingId = 9
                },
                new PaintingStory
                {
                    Id = 77,
                    Title = "Barok",
                    Type = "style",
                    Subtitle = "over de stijlperiode",
                    Text = "Typisch voor een barokschilderij is dat het meest dramatische moment van een gebeurtenis wordt afgebeeld.",
                    ImageUrl = "",
                    LanguageId = 2,
                    PaintingId = 9
                },
                new PaintingStory
                {
                    Id = 80,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "about the movement",
                    Text = "Typical for a Baroque painting is that the most dramatic moment of an event is depicted.",
                    ImageUrl = "",
                    LanguageId = 3,
                    PaintingId = 9
                }/*,
                new PaintingStory
                {
                    Id = 74,
                    Title = "Baroque",
                    Type = "style",
                    Subtitle = "à propos du mouvement",
                    Text = "Typique d'une peinture baroque, le moment le plus dramatique d'un événement est représenté.",
                    ImageUrl = "",
                    LanguageId = 1,
                    PaintingId = 9
                },
                new PaintingStory
                {
                    Id = 75,
                    Title = "Peinture à l’huile",
                    Type = "style",
                    Subtitle = "à propos de la technique",
                    Text = "Les artistes remplacèrent la peinture sur bois par la toile car les pigments tenaient mieux",
                    ImageUrl = "",
                    LanguageId = 1,
                    PaintingId = 9
                },
                new PaintingStory
                {
                    Id = 78,
                    Title = "Olieverf",
                    Type = "style",
                    Subtitle = "over de techniek",
                    Text = "Kunstenaars begonnen te schilderen op canvas in plaats van hout omdat het pigment beter vasthoudt",
                    ImageUrl = "",
                    LanguageId = 2,
                    PaintingId = 9
                },
                new PaintingStory
                {
                    Id = 81,
                    Title = "Oil paint",
                    Type = "style",
                    Subtitle = "about the technique",
                    Text = "Artists started painting on canvas instead of wood because it holds the pigments better",
                    ImageUrl = "",
                    LanguageId = 3,
                    PaintingId = 9
                }*/
            );

            modelBuilder.Entity<Building>()
            .HasData(
                new Building
                {
                    Id = 1,
                    Year = 1400,
                    MuseumCode = "AB",
                    UseId = 1,
                    MovementId = 2,
                },
                new Building
                {
                    Id = 2,
                    Year = 1699,
                    MuseumCode = "AC",
                    UseId = 1,
                    MovementId = 2
                }
            );

            modelBuilder.Entity<Use>()
            .HasData(
                new Use
                {
                    Id = 1,
                    StartYear = 1400,
                    EndYear = -1
                }
            );

            modelBuilder.Entity<UseTranslation>()
            .HasData(
                new UseTranslation
                {
                    Id = 1,
                    UseId = 1,
                    Name = "Hôtel de Ville",
                    LanguageId = 1,
                    Description = "FR",
                    SourceLink = "https://fr.wikipedia.org/wiki/Baroque"
                
                },
                new UseTranslation
                {
                    Id = 2,
                    UseId = 1,
                    Name = "Stadhuis",
                    LanguageId = 2,
                    Description = "NL",
                    SourceLink = "https://nl.wikipedia.org/wiki/Barok_(stijlperiode)"
                },
                new UseTranslation
                {
                    Id = 3,
                    UseId = 1,
                    Name = "Town Hall",
                    LanguageId = 3,
                    Description = "EN",
                    SourceLink = "https://en.wikipedia.org/wiki/Baroque"
                },
                new UseTranslation
                {
                    Id = 4,
                    UseId = 1,
                    Name = "Rathaus",
                    LanguageId = 4,
                    Description = "DE",
                    SourceLink = "https://de.wikipedia.org/wiki/Barock"
                },
                new UseTranslation
                {
                    Id = 5,
                    UseId = 1,
                    Name = "Ayuntamiento",
                    LanguageId = 5,
                    Description = "ES",
                    SourceLink = "https://es.wikipedia.org/wiki/Barroco"
                }
            );

            modelBuilder.Entity<BuildingTranslation>()
            .HasData(
                new BuildingTranslation
                {
                    Id = 1,
                    BuildingId = 1,
                    LanguageId = 1,
                    Name = "Hôtel de Ville de Bruges",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I"
                },
                new BuildingTranslation
                {
                    Id = 2,
                    BuildingId = 1,
                    LanguageId = 2,
                    Name = "Stadhuis van Brugge",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I"
                },
                new BuildingTranslation
                {
                    Id = 3,
                    BuildingId = 1,
                    LanguageId = 3,
                    Name = "Town Hall of Bruges",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I"
                },
                new BuildingTranslation
                {
                    Id = 4,
                    BuildingId = 1,
                    LanguageId = 4,
                    Name = "Rathaus von Brügge",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I"
                },
                new BuildingTranslation
                {
                    Id = 5,
                    BuildingId = 1,
                    LanguageId = 5,
                    Name = "Ayuntamiento de Brujas",
                    Description = null,
                    SourceLink = "http://groeningemuseum.be/collection/work/data/0000_GRO0004_I"
                }
            );

            modelBuilder.Entity<BuildingStory>()
            .HasData(
                new BuildingStory
                {
                    Id = 82,
                    Title = "Stadhuis FR",
                    Type = "style",
                    Subtitle = "about the technique",
                    Text = "Artists started painting on canvas instead of wood because it holds the pigments better",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7d/Burg_in_Brugge_-_Belgi%C3%AB.jpg",
                    LanguageId = 1,
                    BuildingId = 1
                },
                new BuildingStory
                {
                    Id = 83,
                    Title = "Stadhuis NL",
                    Type = "style",
                    Subtitle = "about the technique",
                    Text = "Artists started painting on canvas instead of wood because it holds the pigments better",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7d/Burg_in_Brugge_-_Belgi%C3%AB.jpg",
                    LanguageId = 2,
                    BuildingId = 1
                }
            );
        }

    }
}
