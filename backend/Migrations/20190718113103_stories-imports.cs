using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class storiesimports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { "à propos de l'oeuvre", "Paysage boisé avec gué" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Subtitle",
                value: "à propos du mouvement");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Subtitle",
                value: "à propos de la technique");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { "over het kunstwerk", "Boslandschap met wad" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Subtitle",
                value: "over de stijlperiode");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Subtitle",
                value: "over de techniek");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { "about the artwork", "Wooded Landscape with Ford" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Subtitle",
                value: "about the movement");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Subtitle",
                value: "about the technique");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { "à propos de l'oeuvre", "Portrait d'une famille brugeoise" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Subtitle",
                value: "à propos du mouvement");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Subtitle",
                value: "à propos de la technique");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { "Over het kunstwerk", "Portret van een Brugse familie" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Subtitle",
                value: "over de stijlperiode");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Subtitle",
                value: "over de techniek");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { "About the artwork", "Portrait of a Bruges family" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Subtitle",
                value: "about the movement");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Subtitle",
                value: "about the technique");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { "à propos de l'oeuvre", "Portrait d’un théologien et son secrétaire" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Subtitle",
                value: "à propos du mouvement");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Subtitle",
                value: "à propos de la technique");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { "over het kunstwerk", "Portret van een theoloog met zijn secretaris" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Subtitle",
                value: "over de stijlperiode");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Subtitle",
                value: "over de techniek");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { "About the artwork", "Portrait of a Theologue and his Secretary" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Subtitle",
                value: "about the movement");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Subtitle",
                value: "about the technique");

            migrationBuilder.InsertData(
                table: "PaintingStory",
                columns: new[] { "Id", "ImageUrl", "LanguageId", "PaintingId", "Subtitle", "Text", "Title" },
                values: new object[,]
                {
                    { 79L, "/api/images/painting-stories/", 3L, 9L, "about the artwork", "Matthew, the tax collector, is represented from behind. His dog reflects his master’s emotion as if the painter wanted to tell us “a believer listens to Jesus like a dog listens to his master”", "The Calling of St Matthew" },
                    { 56L, "/api/images/painting-stories/8_MOV@2x-100.jpg", 1L, 7L, "à propos du mouvement", "La peinture baroque utilise des couleurs chaudes et vives ainsi que des contrastes (clair/obscur). La toile est éclairée par tâches contrairement au style de la  Renaissance ayant un éclairage uniforme de la toile", "Baroque" },
                    { 57L, "/api/images/painting-stories/8_TECH@2x-100.jpg", 1L, 7L, "à propos de la technique", "La peinture à l’huile met plus de temps à sécher  que d’autres types de peinture (environ 2 semaines, bien que certaines couleurs sèchent en quelques jours). De ce fait, le peintre pouvait enlever une couche complète de peinture et en recommencer une nouvelle", "Peinture à l’huile" },
                    { 58L, "/api/images/painting-stories/8_ART@2x-100.jpg", 2L, 7L, "over het kunstwerk", "Dit Trojaans verhaal is gebaseerd op verschillende schilderijen. Quellinus zelf schilderde drie verschillende versies van deze scène. Deze versie wordt gekenmerkt door de schilder zijn liefde voor klassieke architectuur uit die periode", "Achilles en de dochters van Lycomedes" },
                    { 59L, "/api/images/painting-stories/8_MOV@2x-100.jpg", 2L, 7L, "over de stijlperiode", "Barok schilderijen maakt gebruik van warme en levendige kleuren en contrasten (Chiaroscuro). De verlichting van het schilderij concentreerde zich op sommige punten terwijl de Renaissance-stijl een consistente verlichting had", "Barok" },
                    { 60L, "/api/images/painting-stories/8_TECH@2x-100.jpg", 2L, 7L, "over de techniek", "Omdat olieverf langer nat blijft dan andere verfsoorten, kan de schilder zijn verf langer bewaren. Het duurt meestal twee weken om te drogen (hoewel sommige kleuren binnen dagen drogen)", "Olieverf" },
                    { 61L, "/api/images/painting-stories/8_ART@2x-100.jpg", 3L, 7L, "about the artwork", "This Troyan story is the base of many paintings.  Quellinus self painted three versions of this scene. This version is characterised by the painter’s love for Classical Architecture of the time of painting", "Achilles among the Daughters of Lycomedes" },
                    { 62L, "/api/images/painting-stories/8_MOV@2x-100.jpg", 3L, 7L, "about the movement", "Baroque painting uses warm and vivid colors as well as contrasts (Chiaroscuro). The painting’s lighting focused on some points while the Renaissance style had a consistent lighting", "Baroque" },
                    { 63L, "/api/images/painting-stories/8_TECH@2x-100.jpg", 3L, 7L, "about the technique", "As oil paint remains wet longer than other types of paint, the painter might remote an entire layer of paint. It usually takes a span of two weeks to dry (although some colors dry within days)", "Oil paint" },
                    { 64L, "/api/images/painting-stories/9_ART@2x-100.jpg", 1L, 8L, "à propos de l'oeuvre", "Lely (de son vrai nom était van der Faes) étudia à Haarlem et pris pour nom d’artiste Lely (Lys en néerlandais) car la fleur de Lys était représentée sur le pignon de la maison de son père", "Portrait de Samuel Crew" },
                    { 65L, "/api/images/painting-stories/9_MOV@2x-100.jpg", 1L, 8L, "à propos du mouvement", "La peinture baroque se caractérise par l’asymétrie: le sujet n’est pas toujours au centre du tableau", "Baroque" },
                    { 66L, "/api/images/painting-stories/9_TECH@2x-100.jpg", 1L, 8L, "à propos de la technique", "L’avantage de la peinture à l’huile est qu’elle met plus de temps à sécher, ce qui permet au peintre de développer son oeuvre au fur et à mesure, contrairement à la tempéra aux oeufs", "Peinture à l’huile" },
                    { 67L, "/api/images/painting-stories/9_ART@2x-100.jpg", 2L, 8L, "over het kunstwerk", "Lely (Zijn echte naam was van der Faes) studeerde in Haarlem en nam Lely (Lelie in het Nederlands) als een artiestennaam omdat er op zijn huis een Lelie stond)", "Portret van Samuel Crew" },
                    { 68L, "/api/images/painting-stories/9_MOV@2x-100.jpg", 2L, 8L, "over de stijlperiode", "Barok schilderijen wordt gekenmerkt door asymmetrie: het onderwerp staat niet altijd centraal in het schilderij", "Barok" },
                    { 69L, "/api/images/painting-stories/9_TECH@2x-100.jpg", 2L, 8L, "over de techniek", "Het voordeel van olieverf is dat het langzaam droogt, waardoor de kunstenaar een schilderij geleidelijk kan ontwikkelen, in tegenstelling tot eitempera", "Olieverf" },
                    { 70L, "/api/images/painting-stories/9_ART@2x-100.jpg", 3L, 8L, "about the artwork", "Lely (his real name was van der Faes) studied in Haarlem and took Lely (lily in Dutch) as an artist name  because his house had a Lily on it", "Portrait of Samuel Crew" },
                    { 71L, "/api/images/painting-stories/9_MOV@2x-100.jpg", 3L, 8L, "about the movement", "Baroque painting is characterised by asymmetry: the subject is not always at the center of the painting", "Baroque" },
                    { 72L, "/api/images/painting-stories/9_TECH@2x-100.jpg", 3L, 8L, "about the technique", "The advantage of oil paint is its slow drying which enables  the artist to develop a painting gradually, as opposed to egg tempera", "Oil paint" },
                    { 73L, "/api/images/painting-stories/", 1L, 9L, "à propos de l'oeuvre", "Matthieu, le percepteur d’impôt, est représenté de dos. Son chien prend l’expression de son maitre, comme si le peintre voulait nous dire “un croyant écoute Jésus comme un chien écoute son maitre”", "La Vocation de saint Matthieu" },
                    { 74L, "/api/images/painting-stories/", 1L, 9L, "à propos du mouvement", "Contrairement à la peinture de la Renaissance (qui illustre le moment précédant un événement important), les peintres baroques choisissent de représenter le moment le plus dramatique de la scène", "Baroque" },
                    { 75L, "/api/images/painting-stories/", 1L, 9L, "à propos de la technique", "Les artistes remplacèrent la peinture sur bois par la toile car les pigments tenaient mieux", "Peinture à l’huile" },
                    { 76L, "/api/images/painting-stories/", 2L, 9L, "over het kunstwerk", "Mattheüs, de tollenaar, is op zijn rug afgebeeld. Zijn hond weerspiegelt zijn meesters emotie alsof de schilder ons wil vertellen “een gelovige luistert naar jezus zoals een hond luistert naar zijn baasje”", "Roeping van Mattheüs" },
                    { 77L, "/api/images/painting-stories/", 2L, 9L, "over de stijlperiode", "In tegenstelling tot de Renaissance schilderijen ( die belangrijke gebeurtenissen afbeelden), kiezen Baroque schilders ervoor om het meest dramatische moment van de gebeurtenis af te beelden", "Barok" },
                    { 78L, "/api/images/painting-stories/", 2L, 9L, "over de techniek", "Kunstenaars begonnen te schilderen op canvas in plaats van hout omdat het pigment beter vasthoudt", "Olieverf" },
                    { 55L, "/api/images/painting-stories/8_ART@2x-100.jpg", 1L, 7L, "à propos de l'oeuvre", "L’histoire de la guerre de Troie fut la base de nombreux tableaux. Quellinus peignit trois versions de cette scène. Cette version est caractérisée par l’amour du peintre pour l’architecture classique de cette période", "Achille parmi les filles de Lycomède" },
                    { 54L, "/api/images/painting-stories/4_TECH@2x-100.jpg", 3L, 6L, "about the technique", "Since 1841, oil paint has been available in metal tube. Now, artists could go and paint outdoors", "Oil paint" },
                    { 41L, "/api/images/painting-stories/7_MOV@2x-100.jpg", 1L, 5L, "over de stijlperiode", "Het schilderen van religieuze scènes werd gebruikt om de ongeletterde bevolking het verhaal te doen begrijpen", "Barok" },
                    { 52L, "/api/images/painting-stories/4_ART@2x-100.jpg", 3L, 6L, "about the artwork", "Fovin de Hasque was a swordsman of the Sint Michiels guild, the oldest swordsmanship guild known in Flanders", "Portrait of Fovin de Hasque" },
                    { 28L, "/api/images/painting-stories/6_ART@2x-100.jpg", 1L, 4L, "à propos de l'oeuvre", "Figure au dos de cette peinture: “J. Van Oost en tant qu’amis 1697”", "Portrait d' un homme" },
                    { 29L, "/api/images/painting-stories/6_MOV@2x-100.jpg", 1L, 4L, "à propos du mouvement", "Les artistes créaient des innovations pour rendre leurs oeuvres plus réalistes et émotives", "Baroque" },
                    { 30L, "/api/images/painting-stories/6_TECH@2x-100.jpg", 1L, 4L, "à propos de la technique ", "Jusqu’au 19ème siècle, les peintres préparaient leurs propres couleurs, en expérimentant", "Peinture à l’huile" },
                    { 31L, "/api/images/painting-stories/6_ART@2x-100.jpg", 2L, 4L, "over het kunstwerk ", "Het schilderij is ondertekend en gedateerd op de achterkant: “J. Van Oost als vriend 1697”", "Portret van een man" },
                    { 32L, "/api/images/painting-stories/6_MOV@2x-100.jpg", 2L, 4L, "over de stijlperiode ", "Kunstenaars creëerden innovaties om hun werk realistischer en gevoeliger te maken", "Barok" },
                    { 33L, "/api/images/painting-stories/6_TECH@2x-100.jpg", 2L, 4L, "over de techniek ", "Tot de 19e eeuw, schilders maakten hun eigen kleuren op basis van ervaring", "Olieverf" },
                    { 34L, "/api/images/painting-stories/6_ART@2x-100.jpg", 3L, 4L, "about the artwork", "The painting is signed and dated on the rear: J. Van Oost als vriend 1697 (J. Van Oost as a friend 1697)", "Portrait of a Man" },
                    { 35L, "/api/images/painting-stories/6_MOV@2x-100.jpg", 3L, 4L, "about the movement", "Artists created innovations to make their works more realistic and emotive", "Baroque" },
                    { 36L, "/api/images/painting-stories/6_TECH@2x-100.jpg", 3L, 4L, "about the technique", "Until the 19th century, painters prepared their own colors based on experience.", "Oil paint" },
                    { 37L, "/api/images/painting-stories/7_ART@2x-100.jpg", 1L, 5L, "à propos de l'oeuvre", "Le peintre de cette oeuvre est resté inconnu jusque dans les années 70 bien qu’elle ressemblait au style de Rubens. On découvrit plus tard qu’Artus Wolfordt était l’artiste, après une reconstruction de son oeuvre “Women bathing”", "Sainte Trinité" },
                    { 38L, "/api/images/painting-stories/7_MOV@2x-100.jpg", 1L, 5L, "à propos du mouvement", "La peinture de scènes religieuses servait à enseigner la religion à la population analphabète", "Baroque" },
                    { 53L, "/api/images/painting-stories/4_MOV@2x-100.jpg", 3L, 6L, "about the movement", "The baroque style became a symbol of wealth and power", "Baroque" },
                    { 39L, "/api/images/painting-stories/7_TECH@2x-100.jpg", 1L, 5L, "à propos de la technique", "Les peintres expérimentent l’épaisseur de la pâte pour accentuer les lumières", "Peinture à l’huile" },
                    { 80L, "/api/images/painting-stories/", 3L, 9L, "about the movement", "Contrary to the Renaissance art (which showed the moment before an important event), Baroque painters chose to represent the most dramatic point", "Baroque" },
                    { 42L, "/api/images/painting-stories/7_TECH@2x-100.jpg", 1L, 5L, "over de techniek", "Schilders beginnen te experimenteren met de dikte van de verf om het licht te accentueren", "Olieverf" },
                    { 43L, "/api/images/painting-stories/7_ART@2x-100.jpg", 1L, 5L, "about the artwork", "The painter was unknown until the 1970’s and thought to be by Rubens. It was later found to be painted by Artus Wolfordt, after a reconstruction on one of his artwork “Women bathing” from this", "Holy Trinity" },
                    { 44L, "/api/images/painting-stories/7_MOV@2x-100.jpg", 1L, 5L, "about the movement", "Painting of religious scenes was used for religious instruction for the illiterate population", "Baroque" },
                    { 45L, "/api/images/painting-stories/7_TECH@2x-100.jpg", 1L, 5L, "about the technique", "Painters start to experiment with the thickness of the paint to accentuate the light", "Oil paint" },
                    { 46L, "/api/images/painting-stories/4_ART@2x-100.jpg", 1L, 6L, "about the artwork", "Fovin de Hasque was a swordsman of the Sint Michiels guild, the oldest swordsmanship guild known in Flanders", "Portrait de Fovin de Hasque" },
                    { 47L, "/api/images/painting-stories/4_MOV@2x-100.jpg", 1L, 6L, "à propos du mouvement", "Le style baroque devint un symbole de richesse et pouvoir", "Baroque" },
                    { 48L, "/api/images/painting-stories/4_TECH@2x-100.jpg", 1L, 6L, "à propos de la technique", "Depuis 1841, la peinture à l’huile est disponible dans des tubes de métal. Les artistes peuvent maintenant sortir et peindre à l’extérieur", "Peinture à l’huile" },
                    { 49L, "/api/images/painting-stories/4_ART@2x-100.jpg", 2L, 6L, "over het kunstwerk", "Fovin de Hasque was een schermmeester van de Sint Michielsgilde,  de oudste zwaardvechtkunst gilde bekend in Vlaanderen", "Portret van Fovin de Hasque" },
                    { 50L, "/api/images/painting-stories/4_MOV@2x-100.jpg", 2L, 6L, "over de stijlperiode", "De barokstijl werd een symbool van rijkdom en macht", "Barok" },
                    { 51L, "/api/images/painting-stories/4_TECH@2x-100.jpg", 2L, 6L, "over de techniek", "Sinds 1841, olieverf was verkrijgbaar in metalen tubes. Nu konden kunstenaars buiten schilderen", "Olieverf" },
                    { 40L, "/api/images/painting-stories/7_ART@2x-100.jpg", 1L, 5L, "over het kunstwerk", "De schilder was onbekend tot in de jaren 1970 ze beschouwden het een werk van Rubens. Later bleek het een schilderij te zijn door Artus Wolfordt, na een reconstructie van een van zijn kunstwerken ‘badende vrouwen’", "Heilige Drievuldigheid" },
                    { 81L, "/api/images/painting-stories/", 3L, 9L, "about the technique", "Artists started painting on canvas instead of wood because it holds the pigments better", "Oil paint" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { null, "À propos de l'oeuvre" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { null, "Over het kunstwerk" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { null, "About the artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { null, "À propos de l'oeuvre" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { null, "Over het kunstwerk" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { null, "About the artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { null, "À propos de l'oeuvre" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { null, "Over het kunstwerk" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Subtitle", "Title" },
                values: new object[] { null, "About the artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Subtitle",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Subtitle",
                value: null);
        }
    }
}
