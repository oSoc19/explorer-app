using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class updatedPaintingStories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 7L);

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
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 15L);

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
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 30L);

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
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 45L);

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
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 51L);

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
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 57L);

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
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 63L);

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
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 69L);

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
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2L,
                column: "LastName",
                value: "van Oost");

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 3L,
                column: "LastName",
                value: "van Oost");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Text",
                value: "Le mot baroque vient du portugais barroco, qui signifie 'perle de forme irrégulière'.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Text",
                value: "Avant l'invention de la peinture à l'huile, la plupart des artistes utilisaient la détrempe, un type de peinture dans lequel le pigment était mélangé au jaune d'œuf comme liant.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Het woord barok komt van het Portugese barroco, wat 'onregelmatig gevormde parel' betekent.", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Voordat olieverf werd uitgevonden gebruikten de meeste kunstenaars tempera, een verfsoort waarbij pigment gemengd werd met eigeel als bindmiddel.", "technique" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Text",
                value: "The word baroque comes from the Portuguese barroco, which means 'irregularly shaped pearl'.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Text",
                value: "Before oil paint was invented, most artists used tempera, a type of paint in which pigment was mixed with egg yolk as a binding agent.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Text",
                value: "L'âge des personnes se reflète dans toutes sortes de détails de l'œuvre d'art, comme les vêtements.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Text",
                value: "De leeftijd van de personen is weergegeven op allerlei details in het kunstwerk zoals de kledij.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Text",
                value: "The age of the persons is reflected in all kinds of details in the artwork such as the clothing.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Le tableau date de 1668. Sur l'inscription on peut lire 'AETETETIS 47' = à l'âge de 47 ans. Son identité reste à ce jour inconnue.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "La peinture blanche était faite de plomb. Il séchait rapidement et couvrait bien, mais il était très toxique. Comme peintre, vous avez risqué un empoisonnement au plomb.", "technique" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Het schilderij dateert uit 1668. Op het opschrift lezen we 'AETETIS 47' = op de leeftijd van 47. Zijn identiteit is tot op de dag van vandaag nog steeds onbekend.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Text",
                value: "Barokkunst werd vaak gemaakt als religieuze propaganda.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Witte verf werd gemaakt uit lood. Het droogde snel en bedekte goed, maar was heel giftig. Hierdoor had je als kunstschilder het risico een loodvergiftiging op te lopen.", "technique" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "The painting dates from 1668. On the inscription we read 'AETETIS 47' = at the age of 47. His identity is still unknown to this day.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "White paint was made of lead. It dried quickly and covered well, but was very toxic. As a painter, you risked getting lead poisoning.", "technique" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Text",
                value: "Le tableau est signé et daté au dos: 'J. van Oost comme ami / 1697'.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 31L,
                column: "Text",
                value: "Het schilderij is ondertekend en gedateerd op de achterkant: 'J. van Oost als vrient / 1697'.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 34L,
                column: "Text",
                value: "The painting is signed and dated on the back: 'J. van Oost as friend / 1697'.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Ce tableau a été attribué à divers artistes, dont Rubens. Ce n'est que dans les années 1990 qu'il a été attribué à Wolfordt.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Dit schilderij werd aan verschillende kunstenaars toegeschreven, onder andere aan Rubens. Pas in de jaren 1990 werd het toegeschreven aan Wolfordt.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 41L,
                column: "Text",
                value: "Het schilderen van religieuze scènes werd gebruikt om de ongeletterde bevolking het verhaal te doen begrijpen.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "This painting was attributed to various artists, including Rubens. It was not until the 1990s that it was attributed to Wolfordt.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 46L,
                column: "Text",
                value: "Fovin de Hasque était escrimeur de la guilde St Michel de Bruges, la plus ancienne guilde d'escrime connue en Flandre.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Fovin de Hasque was schermmeester van de Brugse Sint-Michielsgilde, de oudst bekende schermersgilde in Vlaanderen.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Fovin de Hasque was fencer of the Bruges St Michael's Guild, the oldest known fencer's guild in Flanders.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Cette histoire est basée sur plusieurs tableaux. Cette composition remonte à la conception d'une tapisserie de Rubens sur le héros grec Achille. Quellinus lui-même a peint trois versions différentes de cette scène.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Dit verhaal is gebaseerd op verschillende schilderijen. Deze compositie gaat terug op een ontwerp voor een wandtapijt van Rubens over de Griekse held Achilles. Quellinus zelf schilderde drie verschillende versies van deze scène.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "This story is based on several paintings. This composition goes back to a design for a tapestry by Rubens about the Greek hero Achilles. Quellinus himself painted three different versions of this scene.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Peter Lely (né Pieter van der Faes) a étudié à Haarlem. Il est connu sous le nom de Lely en raison de l'image d'un lys sur la maison de son père à La Haye.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Peter Lely (geboren als Pieter van der Faes) studeerde in Haarlem. Hij werd bekend onder de naam Lely vanwege de afbeelding van een lelie op het huis van zijn vader in Den Haag.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Peter Lely (born as Pieter van der Faes) studied in Haarlem. He became known as Lely because of the image of a lily on his father's house in The Hague.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Matthieu, le percepteur, est représenté sur son dos. Le chien symbolise sa fidélité à Jésus et à sa foi.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Mattheüs, de tollenaar, is op zijn rug afgebeeld. De hond symboliseert zijn trouw aan Jezus en aan zijn geloof.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 77L,
                column: "Text",
                value: "Typisch voor een barokschilderij is dat het meest dramatische moment van een gebeurtenis wordt afgebeeld.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Matthew, the tax collector, is depicted on his back. The dog symbolizes his faithfulness to Jesus and to his faith.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 80L,
                column: "Text",
                value: "Typical for a Baroque painting is that the most dramatic moment of an event is depicted.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 82L,
                column: "Text",
                value: "Achille avait une relation secrète avec Deidamia, une des sept filles du roi Lycomède. Elle a l'air triste parce qu'elle sait qu'Achille va la quitter.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Achilles had een geheime relatie met Deidamia, een van de zeven dochters van koning Lycomedes. Ze kijkt hier triest omdat ze weet dat Achilles haar zal verlaten.", "artwork" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Achilles had a secret relationship with Deidamia, one of the seven daughters of King Lycomedes. She looks sad here because she knows that Achilles will leave her.", "artwork" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2L,
                column: "LastName",
                value: "Van Oost");

            migrationBuilder.UpdateData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 3L,
                column: "LastName",
                value: "Van Oost");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Text",
                value: "Le mot “baroque” avait une connotation négative");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Text",
                value: "Avant que la peinture à l’huile ne soit inventée, la plupart des artistes utilisaient la tempera à l’oeuf");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Het woord “barok” was vroeger een negatief woord", "sttle" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Voordat olieverf werd uitgevonden gebruikten de meeste kunstenaars ei tempera", "tecnique" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Text",
                value: "The word 'baroque' used to be a negative term");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Text",
                value: "Before oil paint was invented, most artists used egg tempera");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Text",
                value: "Observez bien attentivement et vous pourrez apercevoir l’âge des personnages sur leurs vêtements");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Text",
                value: "Wist je dat de leeftijd van de personen weergegeven is in hun kledij?");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Text",
                value: "Did you know that the characters’ age is displayed within their clothing?");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Le tableau est daté de 1668. Selon l’inscription, le théologien serait âgé de 47 ans.  Son identité reste à ce jour inconnue", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "La peinture blanche était créée avec du plomb.  Elle séchait vite et couvrait bien", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Het schilderij dateert uit 1668. Volgens het opschrift is de theoloog 47 jaar oud. Zijn identiteit is tot op de dag van vandaag nog steeds onbekend", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Text",
                value: "Barok kunst werd gemaakt als religieuze propaganda");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Witte verf werd gemaakt uit lood. Het droogde snel en bedekte goed", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "The date on the painting is 1668 and according to the inscription on it, the theologue is 47 years old. The identity of the man is still unknown to this day", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "White paint was created with lead. It dried quickly and covered well", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Text",
                value: "Figure au dos de cette peinture: “J. Van Oost en tant qu’amis 1697”");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 31L,
                column: "Text",
                value: "Het schilderij is ondertekend en gedateerd op de achterkant: “J. Van Oost als vriend 1697”");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 34L,
                column: "Text",
                value: "The painting is signed and dated on the rear: J. Van Oost als vriend 1697 (J. Van Oost as a friend 1697)");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Le peintre de cette oeuvre est resté inconnu jusque dans les années 70 bien qu’elle ressemblait au style de Rubens. On découvrit plus tard qu’Artus Wolfordt était l’artiste, après une reconstruction de son oeuvre “Women bathing”", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "De schilder was onbekend tot in de jaren 1970 ze beschouwden het een werk van Rubens. Later bleek het een schilderij te zijn door Artus Wolfordt, na een reconstructie van een van zijn kunstwerken ‘badende vrouwen’", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 41L,
                column: "Text",
                value: "Het schilderen van religieuze scènes werd gebruikt om de ongeletterde bevolking het verhaal te doen begrijpen");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "The painter was unknown until the 1970’s and thought to be by Rubens. It was later found to be painted by Artus Wolfordt, after a reconstruction on one of his artwork “Women bathing” from this", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 46L,
                column: "Text",
                value: "Fovin de Hasque était un maître d’armes de la guilde de Sint Michiels, une des plus anciennes guildes d’escrime connues de Flandres.");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Fovin de Hasque was een schermmeester van de Sint Michielsgilde,  de oudste zwaardvechtkunst gilde bekend in Vlaanderen", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Fovin de Hasque was a swordsman of the Sint Michiels guild, the oldest swordsmanship guild known in Flanders", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "L’histoire de la guerre de Troie fut la base de nombreux tableaux. Quellinus peignit trois versions de cette scène. Cette version est caractérisée par l’amour du peintre pour l’architecture classique de cette période", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Dit Trojaans verhaal is gebaseerd op verschillende schilderijen. Quellinus zelf schilderde drie verschillende versies van deze scène. Deze versie wordt gekenmerkt door de schilder zijn liefde voor klassieke architectuur uit die periode", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "This Troyan story is the base of many paintings.  Quellinus self painted three versions of this scene. This version is characterised by the painter’s love for Classical Architecture of the time of painting", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Lely (de son vrai nom était van der Faes) étudia à Haarlem et pris pour nom d’artiste Lely (Lys en néerlandais) car la fleur de Lys était représentée sur le pignon de la maison de son père", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Lely (Zijn echte naam was van der Faes) studeerde in Haarlem en nam Lely (Lelie in het Nederlands) als een artiestennaam omdat er op zijn huis een Lelie stond)", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Lely (his real name was van der Faes) studied in Haarlem and took Lely (lily in Dutch) as an artist name  because his house had a Lily on it", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Matthieu, le percepteur d’impôt, est représenté de dos. Son chien prend l’expression de son maitre, comme si le peintre voulait nous dire “un croyant écoute Jésus comme un chien écoute son maitre”", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Mattheüs, de tollenaar, is op zijn rug afgebeeld. Zijn hond weerspiegelt zijn meesters emotie alsof de schilder ons wil vertellen “een gelovige luistert naar jezus zoals een hond luistert naar zijn baasje”", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 77L,
                column: "Text",
                value: "In tegenstelling tot de Renaissance schilderijen ( die belangrijke gebeurtenissen afbeelden), kiezen Baroque schilders ervoor om het meest dramatische moment van de gebeurtenis af te beelden");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Matthew, the tax collector, is represented from behind. His dog reflects his master’s emotion as if the painter wanted to tell us “a believer listens to Jesus like a dog listens to his master”", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 80L,
                column: "Text",
                value: "Contrary to the Renaissance art (which showed the moment before an important event), Baroque painters chose to represent the most dramatic point");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 82L,
                column: "Text",
                value: "Achille eut une liaison secrète avec Deidamia, une des 7 filles du Roi Lycomède. Celle-ci a l’air triste car elle sait que Achille est sur le point de partir");

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Achilles had een geheime relatie met een van de 7 dochters van koning Lycomede’s: namelijk Deidamia. Ze kijkt triest omdat ze weet dat Achilles haar zal verlaten", "style" });

            migrationBuilder.UpdateData(
                table: "PaintingStory",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "Text", "Type" },
                values: new object[] { "Achilles had a secret relationship with one of King Lycomedes’s 7 daughters: Deidamia. That is why she looks sad because she knows that  Achilles is going to leave", "style" });

            migrationBuilder.InsertData(
                table: "PaintingStory",
                columns: new[] { "Id", "ImageUrl", "LanguageId", "PaintingId", "Subtitle", "Text", "Title", "Type" },
                values: new object[,]
                {
                    { 59L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg", 2L, 7L, "over de stijlperiode", "Barok schilderijen maakt gebruik van warme en levendige kleuren en contrasten (Chiaroscuro). De verlichting van het schilderij concentreerde zich op sommige punten terwijl de Renaissance-stijl een consistente verlichting had", "Barok", "style" },
                    { 74L, "", 1L, 9L, "à propos du mouvement", "Contrairement à la peinture de la Renaissance (qui illustre le moment précédant un événement important), les peintres baroques choisissent de représenter le moment le plus dramatique de la scène", "Baroque", "style" },
                    { 60L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ddd295ab406349bcaabd41e04e4aa7d3fa4285c4e274469ca4f84a09c82f7864/browse.jpg", 2L, 7L, "over de techniek", "Omdat olieverf langer nat blijft dan andere verfsoorten, kan de schilder zijn verf langer bewaren. Het duurt meestal twee weken om te drogen (hoewel sommige kleuren binnen dagen drogen)", "Olieverf", "style" },
                    { 75L, "", 1L, 9L, "à propos de la technique", "Les artistes remplacèrent la peinture sur bois par la toile car les pigments tenaient mieux", "Peinture à l’huile", "style" },
                    { 63L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ddd295ab406349bcaabd41e04e4aa7d3fa4285c4e274469ca4f84a09c82f7864/browse.jpg", 3L, 7L, "about the technique", "As oil paint remains wet longer than other types of paint, the painter might remote an entire layer of paint. It usually takes a span of two weeks to dry (although some colors dry within days)", "Oil paint", "style" },
                    { 69L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/07e8711ec42e4a659843bc2de2e78657108b44bc1fa24dbdaaca756a3c33f1e9/browse.jpg", 2L, 8L, "over de techniek", "Het voordeel van olieverf is dat het langzaam droogt, waardoor de kunstenaar een schilderij geleidelijk kan ontwikkelen, in tegenstelling tot eitempera", "Olieverf", "style" },
                    { 78L, "", 2L, 9L, "over de techniek", "Kunstenaars begonnen te schilderen op canvas in plaats van hout omdat het pigment beter vasthoudt", "Olieverf", "style" },
                    { 72L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/07e8711ec42e4a659843bc2de2e78657108b44bc1fa24dbdaaca756a3c33f1e9/browse.jpg", 3L, 8L, "about the technique", "The advantage of oil paint is its slow drying which enables  the artist to develop a painting gradually, as opposed to egg tempera", "Oil paint", "style" },
                    { 65L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/d5500b6e47c64cbba935e3dc2d68f8d6d652dd7e5a2943ed8fccd4ba779d8fe9/browse.jpg", 1L, 8L, "à propos du mouvement", "La peinture baroque se caractérise par l’asymétrie: le sujet n’est pas toujours au centre du tableau", "Baroque", "style" },
                    { 66L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/07e8711ec42e4a659843bc2de2e78657108b44bc1fa24dbdaaca756a3c33f1e9/browse.jpg", 1L, 8L, "à propos de la technique", "L’avantage de la peinture à l’huile est qu’elle met plus de temps à sécher, ce qui permet au peintre de développer son oeuvre au fur et à mesure, contrairement à la tempéra aux oeufs", "Peinture à l’huile", "style" },
                    { 68L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/d5500b6e47c64cbba935e3dc2d68f8d6d652dd7e5a2943ed8fccd4ba779d8fe9/browse.jpg", 2L, 8L, "over de stijlperiode", "Barok schilderijen wordt gekenmerkt door asymmetrie: het onderwerp staat niet altijd centraal in het schilderij", "Barok", "style" },
                    { 62L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg", 3L, 7L, "about the movement", "Baroque painting uses warm and vivid colors as well as contrasts (Chiaroscuro). The painting’s lighting focused on some points while the Renaissance style had a consistent lighting", "Baroque", "style" },
                    { 71L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/d5500b6e47c64cbba935e3dc2d68f8d6d652dd7e5a2943ed8fccd4ba779d8fe9/browse.jpg", 3L, 8L, "about the movement", "Baroque painting is characterised by asymmetry: the subject is not always at the center of the painting", "Baroque", "style" },
                    { 42L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03c88b6c0857421985c8afe512996d300f59c58603f54e5a8a9371fad4d2c919/browse.jpg", 2L, 5L, "over de techniek", "Schilders beginnen te experimenteren met de dikte van de verf om het licht te accentueren", "Olieverf", "style" },
                    { 56L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e66cc133bb5f4c2aa7739d7e9e60f52c52e4cb84ea5047a9ba2755a8edeed163/browse.jpg", 1L, 7L, "à propos du mouvement", "La peinture baroque utilise des couleurs chaudes et vives ainsi que des contrastes (clair/obscur). La toile est éclairée par tâches contrairement au style de la  Renaissance ayant un éclairage uniforme de la toile", "Baroque", "style" },
                    { 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ce8835fad1b4288b17e627fa9fcbedf5d8a7c0ff5064c99be988e13675c8047/browse.jpg", 1L, 1L, "à propos de l'oeuvre", "Les feuilles sur les arbres ne sont en fait pas peintes une à une mais à coups de pinceaux", "Paysage boisé avec gué", "artwork" },
                    { 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ce8835fad1b4288b17e627fa9fcbedf5d8a7c0ff5064c99be988e13675c8047/browse.jpg", 2L, 1L, "over het kunstwerk", "De schilder gebruikte ruwe schilder stroken om de blaadjes aan de bomen te schilderen, niet blaadje per blaadje apart", "Boslandschap met wad", "artwork" },
                    { 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5ce8835fad1b4288b17e627fa9fcbedf5d8a7c0ff5064c99be988e13675c8047/browse.jpg", 3L, 1L, "about the artwork", "The painter used raw brush strokes to paint the leaves on the trees, not every leave separately.", "Wooded Landscape with Ford", "artwork" },
                    { 11L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5fdb481bb5f94f8697556ba58a986b659d9bfd331a374ad9810a549d601c2627/browse.jpg", 1L, 2L, "à propos du mouvement", "Les oeuvres catholiques baroques étaient souvent larges", "Baroque", "style" },
                    { 12L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e346459340324138861abea18b6c87d2d65c583136a44fb8906007a69871cc23/browse.jpg", 1L, 2L, "à propos de la technique", "Le bleu ultramarine était fabriqué avec du lapis lazuli qui était très onéreux. Après l’avoir mélangé avec l’huile, la peinture était conservée dans une vessie de porc", "Peinture à l’huile", "technique" },
                    { 14L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5fdb481bb5f94f8697556ba58a986b659d9bfd331a374ad9810a549d601c2627/browse.jpg", 2L, 2L, "over de stijlperiode", "Katholieke barok kunstwerken waren doorgaans groot", "Barok", "style" },
                    { 15L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e346459340324138861abea18b6c87d2d65c583136a44fb8906007a69871cc23/browse.jpg", 2L, 2L, "over de techniek", "Ultramarijnblauw werd gemaakt met lapis lazuli, iets wat zeer duur was. Na het mixen met olie werd het vaak bewaard in een varkensblaas", "Olieverf", "technique" },
                    { 17L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5fdb481bb5f94f8697556ba58a986b659d9bfd331a374ad9810a549d601c2627/browse.jpg", 3L, 2L, "about the movement", "Catholic baroque works were usually large", "Baroque", "style" },
                    { 18L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/e346459340324138861abea18b6c87d2d65c583136a44fb8906007a69871cc23/browse.jpg", 3L, 2L, "about the technique", "Ultramarine blue was made with lapis lazuli, which was very expensive. After mixing it with the oil, it was often stored in a pig’s bladder", "Oil paint", "technique" },
                    { 29L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5a47b5970737453b816a29a596b25ff9f37f58290f9b4ab18521a5ce7b610ad3/browse.jpg", 1L, 4L, "à propos du mouvement", "Les artistes créaient des innovations pour rendre leurs oeuvres plus réalistes et émotives", "Baroque", "style" },
                    { 30L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/efd4bf7eedcc4d768d02849291c823abd947d1a712a04e70980bc3e1086273b9/browse.jpg", 1L, 4L, "à propos de la technique ", "Jusqu’au 19ème siècle, les peintres préparaient leurs propres couleurs, en expérimentant", "Peinture à l’huile", "style" },
                    { 32L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5a47b5970737453b816a29a596b25ff9f37f58290f9b4ab18521a5ce7b610ad3/browse.jpg", 2L, 4L, "over de stijlperiode ", "Kunstenaars creëerden innovaties om hun werk realistischer en gevoeliger te maken", "Barok", "style" },
                    { 33L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/efd4bf7eedcc4d768d02849291c823abd947d1a712a04e70980bc3e1086273b9/browse.jpg", 2L, 4L, "over de techniek ", "Tot de 19e eeuw, schilders maakten hun eigen kleuren op basis van ervaring", "Olieverf", "style" },
                    { 35L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5a47b5970737453b816a29a596b25ff9f37f58290f9b4ab18521a5ce7b610ad3/browse.jpg", 3L, 4L, "about the movement", "Artists created innovations to make their works more realistic and emotive", "Baroque", "style" },
                    { 36L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/efd4bf7eedcc4d768d02849291c823abd947d1a712a04e70980bc3e1086273b9/browse.jpg", 3L, 4L, "about the technique", "Until the 19th century, painters prepared their own colors based on experience.", "Oil paint", "style" },
                    { 39L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03c88b6c0857421985c8afe512996d300f59c58603f54e5a8a9371fad4d2c919/browse.jpg", 1L, 5L, "à propos de la technique", "Les peintres expérimentent l’épaisseur de la pâte pour accentuer les lumières", "Peinture à l’huile", "style" },
                    { 45L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/03c88b6c0857421985c8afe512996d300f59c58603f54e5a8a9371fad4d2c919/browse.jpg", 3L, 5L, "about the technique", "Painters start to experiment with the thickness of the paint to accentuate the light", "Oil paint", "style" },
                    { 47L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/fecdb0f11ba34090822eafcc87302d21ca86d20df97b4fbe92d455ccd29a4e78/browse.jpg", 1L, 6L, "à propos du mouvement", "Le style baroque devint un symbole de richesse et pouvoir", "Baroque", "style" },
                    { 48L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3931908a115a4e229c153dcf4468422282c74814f999464681d5ba1a28b18885/browse.jpg", 1L, 6L, "à propos de la technique", "Depuis 1841, la peinture à l’huile est disponible dans des tubes de métal. Les artistes peuvent maintenant sortir et peindre à l’extérieur", "Peinture à l’huile", "style" },
                    { 50L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/fecdb0f11ba34090822eafcc87302d21ca86d20df97b4fbe92d455ccd29a4e78/browse.jpg", 2L, 6L, "over de stijlperiode", "De barokstijl werd een symbool van rijkdom en macht", "Barok", "style" },
                    { 51L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3931908a115a4e229c153dcf4468422282c74814f999464681d5ba1a28b18885/browse.jpg", 2L, 6L, "over de techniek", "Sinds 1841, olieverf was verkrijgbaar in metalen tubes. Nu konden kunstenaars buiten schilderen", "Olieverf", "style" },
                    { 53L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/fecdb0f11ba34090822eafcc87302d21ca86d20df97b4fbe92d455ccd29a4e78/browse.jpg", 3L, 6L, "about the movement", "The baroque style became a symbol of wealth and power", "Baroque", "style" },
                    { 54L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3931908a115a4e229c153dcf4468422282c74814f999464681d5ba1a28b18885/browse.jpg", 3L, 6L, "about the technique", "Since 1841, oil paint has been available in metal tube. Now, artists could go and paint outdoors", "Oil paint", "style" },
                    { 57L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ddd295ab406349bcaabd41e04e4aa7d3fa4285c4e274469ca4f84a09c82f7864/browse.jpg", 1L, 7L, "à propos de la technique", "La peinture à l’huile met plus de temps à sécher  que d’autres types de peinture (environ 2 semaines, bien que certaines couleurs sèchent en quelques jours). De ce fait, le peintre pouvait enlever une couche complète de peinture et en recommencer une nouvelle", "Peinture à l’huile", "style" },
                    { 81L, "", 3L, 9L, "about the technique", "Artists started painting on canvas instead of wood because it holds the pigments better", "Oil paint", "style" }
                });
        }
    }
}
