using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class MovementBuildings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MovementId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 6L,
                column: "MovementId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 7L,
                column: "MovementId",
                value: 1L);

            migrationBuilder.InsertData(
                table: "Movement",
                column: "Id",
                values: new object[]
                {
                    3L,
                    4L,
                    5L,
                    6L
                });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "L’architecture baroque s’est développée en Italie au début du 17<sup>e</sup> siècle et s’est ensuite répandue dans toute l’Europe. Il s’agit d’un style hautement décoratif et théâtral qui veut impressionner le visiteur. Le style a été fortement promu par l'Église catholique.");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "De barokarchitectuur ontwikkelde zich in Italië in de vroege 17de eeuw en verspreidde zich van daar over Europa. Het is een sterk decoratieve en theatrale stijl die indruk wil maken op de bezoeker. De stijl werd sterk gepromoot door de Katholieke Kerk.", "Barok" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Description",
                value: "Baroque architecture was developed in Italy in the early 17th century and its popularity extended from there across the rest of Europe. It is a highly decorative and theatrical style which aims to make a lasting impression upon visitors. This style was given prominence by the Catholic Church.");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Die Architektur des Barocks entwickelte sich im frühen 17. Jahrhundert in Italien und verbreitete sich von dort aus über Europa. Der Barockstil ist ein stark dekorativer und theatralischer Stil, der Besucher beeindrucken soll. Dieser Stil wurde von der katholischen Kirche stark gefördert.", "Barock" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Description",
                value: "La arquitectura barroca se desarrolló en Italia a principios del siglo XVII, y de ahí se extendió por toda Europa. Se trata de un estilo fuertemente decorativo y teatral que tiene por objeto causar impresión en el visitante. La Iglesia católica promovió firmemente este estilo.");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "L'architecture gothique est née en France au 12e siècle. À l’origine, ce style architectural était surtout utilisé pour les édifices religieux. Dès la fin du 15e siècle, les cathédrales gothiques ont également inspiré la construction d'hôtels de ville dans le nord de la France, en Belgique et aux Pays-Bas actuels.", "Gothique" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Gotische architectuur ontstond in het 12de-eeuwse Frankrijk. Aanvankelijk werd de bouwstijl vooral toegepast voor kerkgebouwen. Vanaf de late 15de eeuw inspireerden de gotische kathedralen ook de bouw van stadhuizen in het huidige Noord-Frankrijk, België en Nederland.", "Gotisch" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "The Gothic style of architecture emerged in the 12th century in France. Initially, this style was used for churches. From the late 15th century, gothic cathedrals were the inspiration for the construction of town halls in what is now northern France, Belgium and the Netherlands.", "Gothic" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Die gotische Architektur entstand in Frankreich im 12. Jahrhundert. Zunächst kam der Baustil vor allem in Kirchengebäuden zum Einsatz. Ab dem 15. Jahrhundert ließ man sich beim Bau von Rathäusern im heutigen Nordfrankreich, Belgien und den Niederlanden auch von den gotischen Kathedralen inspirieren.", "Gotisch" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "La arquitectura gótica surgió en la Francia del siglo XII. Originariamente, el estilo de construcción se aplicó principalmente a edificios de iglesias. Desde finales del siglo XV, las catedrales góticas también inspiraron la construcción actual de ayuntamientos en el norte de Francia, Bélgica y los Países Bajos.", "Gótico" });

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MovementId",
                value: 5L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 3L,
                column: "MovementId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 5L,
                column: "MovementId",
                value: 6L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 8L,
                column: "MovementId",
                value: 6L);

            migrationBuilder.InsertData(
                table: "MovementTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "MovementId", "Name", "SourceLink" },
                values: new object[,]
                {
                    { 28L, "<p><strong>Romanesque</strong></p> <p>Romanesque architecture flourished between 1000 and 1200. It took inspiration from Carolingian and Ottoman architects, who in turn were inspired by Roman and Byzantine architecture. Thick walls, rounded arches and robust columns are typical features of Romanesque architecture.</p> <p><strong>Gothic</strong></p> <p>The Gothic style of architecture emerged in the 12th century in France. Initially, this style was used for churches. From the late 15th century, gothic cathedrals were the inspiration for the construction of town halls in what is now northern France, Belgium and the Netherlands.</p>", 3L, 6L, "Romanesque / Gothique", "https://en.wikipedia.org/wiki/Gothic_architecture" },
                    { 27L, "<p><strong>Romaans</strong></p> <p>De romaanse architectuur bloeide tussen 1000 en 1200. Ze inspireerde zich op de Karolingische een Ottoonse architecten, die op hun beurt op Romeinse en Byzantijnse voorbeelden navolgden. Dikke muren, rondbogen en robuuste zuilen zijn typisch voor de romaanse architectuur.</p> <p><strong>Gotisch</strong></p> <p>Gotische architectuur ontstond in het 12<sup>de</sup>-eeuwse Frankrijk. Aanvankelijk werd de bouwstijl vooral toegepast voor kerkgebouwen. Vanaf de late 15de eeuw inspireerden de gotische kathedralen ook de bouw van stadhuizen in het huidige Noord-Frankrijk, België en Nederland.</p>", 2L, 6L, "Romaans / Gotisch", "https://nl.wikipedia.org/wiki/Gotiek_(bouwkunst)" },
                    { 26L, "<p><strong>Roman</strong></p> <p>L’architecture romane s'est développée entre 1000 et 1200. Elle s’est inspirée des architectes carolingiens et ottoniens qui, à leur tour, ont suivi des exemples romains et byzantins. Des murs épais, des arcs en demi-cercle et des colonnes robustes sont typiques de l'architecture romane.</p> <p><strong>Gotique</strong></p> <p>L'architecture gothique est née en France au 12<sup>e</sup> siècle. À l’origine, ce style architectural était surtout utilisé pour les édifices religieux. Dès la fin du 15<sup>e</sup> siècle, les cathédrales gothiques ont également inspiré la construction d'hôtels de ville dans le nord de la France, en Belgique et aux Pays-Bas actuels.</p>", 1L, 6L, "Roman / Gotique", "https://fr.wikipedia.org/wiki/Architecture_gothique" },
                    { 25L, "Ya desde la época renacentista, la arquitectura de la antigüedad clásica volvía a ser fuente de inspiración para los arquitectos. En la arquitectura clasicista se aplican las proporciones fijas en la composición y la columna, la pilastra y el frontón forman los elementos arquitectónicos más importantes.", 5L, 5L, "Clasicismo", "https://es.wikipedia.org/wiki/Arquitectura_g%C3%B3tica" },
                    { 24L, "Bereits seit der Renaissance diente die Baukunst des antiken Altertums erneut als Inspirationsquelle für Architekten. In der klassizistischen Architektur werden feste Proportionsverhältnisse angewandt. Säule, Pilaster und Fronton sind die wichtigsten Bauelemente.", 4L, 5L, "Klassizismus", "https://de.wikipedia.org/wiki/Gotik#Baukunst" },
                    { 23L, "From as far back as the Renaissance, the architecture of ancient times has been a source of inspiration for architects. In classical architecture, there are fixed proportions for composition, and columns, pilasters and pediments are the most important features.", 3L, 5L, "Classicism", "https://en.wikipedia.org/wiki/Gothic_architecture" },
                    { 22L, "Al vanaf de renaissance vormde de bouwkunst van de antieke oudheid opnieuw een inspiratiebron voor architecten. In de classicistische architectuur worden vaste verhoudingen in de compositie toegepast en zijn de zuil, de pilaster en het fronton de belangrijkste bouwelementen.", 2L, 5L, "Classicisme", "https://nl.wikipedia.org/wiki/Gotiek_(bouwkunst)" },
                    { 21L, "Dès la Renaissance, l’architecture de l’Antiquité est redevenue une source d'inspiration pour les architectes. Dans l’architecture classique, des proportions fixes sont utilisées dans la composition et la colonne, le pilastre ainsi que le fronton sont les éléments de construction les plus importants.", 1L, 5L, "Classicisme", "https://fr.wikipedia.org/wiki/Architecture_gothique" },
                    { 11L, "L’architecture romane s'est développée entre 1000 et 1200. Elle s’est inspirée des architectes carolingiens et ottoniens qui, à leur tour, ont suivi des exemples romains et byzantins. Des murs épais, des arcs en demi-cercle et des colonnes robustes sont typiques de l'architecture romane.", 1L, 3L, "Roman", "https://fr.wikipedia.org/wiki/Architecture_gothique" },
                    { 20L, "A partir de aproximadamente 1400 resurge la arquitectura griega y romana. De igual forma que en la antigüedad, la arquitectura renacentista concede mucha importancia a la proporción y a la armonía. Los arquitectos adquieren un mayor prestigio y seguridad en sí mismos. Hacia el año 1600 el barroco sustituye a la arquitectura renacentista.", 5L, 4L, "Renacimiento", "https://es.wikipedia.org/wiki/Arquitectura_g%C3%B3tica" },
                    { 19L, "Ab etwa 1400 wurde die griechische und römische Baukunst wiederentdeckt. Wie im Altertum wurde in der Architektur der Renaissance ausgewogenen Proportionen und Harmonie viel Bedeutung beigemessen. Die Baumeister erwarben ein größeres Ansehen und mehr Selbstvertrauen. Um 1600 ging die Renaissance-Architektur in den Barock über.", 4L, 4L, "Renaissance", "https://de.wikipedia.org/wiki/Gotik#Baukunst" },
                    { 18L, "Greek and Roman architecture was rediscovered in around 1400. Just like in ancient times, Renaissance architecture put great emphasis on the importance of proportions and harmony. Architects were given more respect and their confidence grew. The Renaissance period gave way to the Baroque style in around 1600.", 3L, 4L, "Renaissance", "https://en.wikipedia.org/wiki/Gothic_architecture" },
                    { 17L, "Vanaf ongeveer 1400 werd de Griekse en Romeinse bouwkunst herontdekt. Net zoals in de oudheid hechtte renaissancearchitectuur veel belang aan proportie en harmonie. Bouwmeesters kregen meer aanzien en zelfvertrouwen. Omstreeks 1600 ging de renaissancearchitectuur over in de barok.", 2L, 4L, "Renaissance", "https://nl.wikipedia.org/wiki/Gotiek_(bouwkunst)" },
                    { 16L, "L’architecture grecque et romaine a été redécouverte aux alentours de 1400. Comme dans les temps anciens, l’architecture de la Renaissance accordait une importante toute particulière à la proportion et à l’harmonie. Les architectes et bâtisseurs ont bénéficié d’une plus grande considération et ont gagné en confiance. Vers 1600, l’architecture de la Renaissance est passée à l’ère baroque.", 1L, 4L, "Renaissance", "https://fr.wikipedia.org/wiki/Architecture_gothique" },
                    { 15L, "La arquitectura románica prosperó entre los años 1000 y 1200. Se inspiró en arquitectos carolingios y otomanos, que, a su vez, seguían los ejemplos romanos y bizantinos. Los elementos típicos de la arquitectura románica son los muros de gran grosor, los arcos de medio punto y las robustas columnas.", 5L, 3L, "Románico", "https://es.wikipedia.org/wiki/Arquitectura_g%C3%B3tica" },
                    { 14L, "Die romanische Architektur erlebte ihre Blütezeit zwischen 1000 und 1200. Sie wurde von karolingischen und ottonischen Architekten inspiriert, die ihrerseits römischen und byzantinischen Vorbildern folgten. Typisch für die romanische Architektur sind dicke Mauern, Rundbogen und robuste Säulen.", 4L, 3L, "Romanisch", "https://de.wikipedia.org/wiki/Gotik#Baukunst" },
                    { 13L, "Romanesque architecture flourished between 1000 and 1200. It took inspiration from Carolingian and Ottoman architects, who in turn were inspired by Roman and Byzantine architecture. Thick walls, rounded arches and robust columns are typical features of Romanesque architecture.", 3L, 3L, "Romanesque", "https://en.wikipedia.org/wiki/Gothic_architecture" },
                    { 12L, "De romaanse architectuur bloeide tussen 1000 en 1200. Ze inspireerde zich op de Karolingische een Ottoonse architecten, die op hun beurt op Romeinse en Byzantijnse voorbeelden navolgden. Dikke muren, rondbogen en robuuste zuilen zijn typisch voor de romaanse architectuur.", 2L, 3L, "Gotisch", "https://nl.wikipedia.org/wiki/Gotiek_(bouwkunst)" },
                    { 29L, "<p><strong>Romanisch</strong></p> <p>Die romanische Architektur erlebte ihre Blütezeit zwischen 1000 und 1200. Sie wurde von karolingischen und ottonischen Architekten inspiriert, die ihrerseits römischen und byzantinischen Vorbildern folgten. Typisch für die romanische Architektur sind dicke Mauern, Rundbogen und robuste Säulen.</p> <p><strong>Gotisch</strong></p> <p>Die gotische Architektur entstand in Frankreich im 12. Jahrhundert. Zunächst kam der Baustil vor allem in Kirchengebäuden zum Einsatz. Ab dem 15. Jahrhundert ließ man sich beim Bau von Rathäusern im heutigen Nordfrankreich, Belgien und den Niederlanden auch von den gotischen Kathedralen inspirieren.</p>", 4L, 6L, "Romanisch / Gotisch", "https://de.wikipedia.org/wiki/Gotik#Baukunst" },
                    { 30L, "<p><strong>Románico</strong></p> <p>La arquitectura románica prosperó entre los años 1000 y 1200. Se inspiró en arquitectos carolingios y otomanos, que, a su vez, seguían los ejemplos romanos y bizantinos. Los elementos típicos de la arquitectura románica son los muros de gran grosor, los arcos de medio punto y las robustas columnas.&nbsp;</p> <p><strong>Gótico</strong></p> <p>La arquitectura gótica surgió en la Francia del siglo XII. Originariamente, el estilo de construcción se aplicó principalmente a edificios de iglesias. Desde finales del siglo XV, las catedrales góticas también inspiraron la construcción actual de ayuntamientos en el norte de Francia, Bélgica y los Países Bajos.</p>", 5L, 6L, "Románico / Gótico", "https://es.wikipedia.org/wiki/Arquitectura_g%C3%B3tica" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Movement",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Movement",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Movement",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Movement",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 1L,
                column: "MovementId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 2L,
                column: "MovementId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 3L,
                column: "MovementId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 5L,
                column: "MovementId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 6L,
                column: "MovementId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 7L,
                column: "MovementId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Building",
                keyColumn: "Id",
                keyValue: 8L,
                column: "MovementId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Description",
                value: "Le baroque est un mouvement artistique qui trouve son origine en Italie dans des villes telles que Rome, Mantoue, Venise et Florence dès le milieu du XVIe siècle et qui se termine au milieu du XVIIIe siècle. Il y a un âge baroque différent selon les domaines, qu'ils soient intellectuels, historiques ou artistiques. Certains critiques y voient une constante culturelle qui revient tout au long de l'histoire comme l'a écrit Eugenio d'Ors. Le baroque, qui touche tous les domaines, se caractérise par l’exagération du mouvement, la surcharge décorative, les effets dramatiques, la tension, l’exubérance des formes, la grandeur parfois pompeuse et le contraste. ");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "De barok is een Europese stijlperiode die aan het begin van de 17e eeuw in Italië tot ontwikkeling kwam en tot in de eerste helft van de 18e eeuw voortduurde, en die zich kenmerkt door overdaad van vorm en heftigheid van gevoelsuitdrukking. De barok kwam tot uiting op alle terreinen van de cultuur, zoals architectuur, tuinarchitectuur, schilderkunst, beeldhouwkunst, literatuur en muziek. Er wordt een onderscheid gemaakt tussen vroeg-, hoog- en laatbarok. De laatbarok wordt ook wel rococo genoemd. ", "Barok (stijlperiode)" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Description",
                value: "The Baroque is a highly ornate and often extravagant style of architecture, music, dance, painting, sculpture and other arts that flourished in Europe from the early 17th until the mid-18th century. It followed Renaissance art and Mannerism and preceded the Rococo (in the past often referred to as 'late Baroque') and Neoclassical styles. It was encouraged by the Catholic Church as a means to counter the simplicity and austerity of Protestant architecture, art and music, though Lutheran Baroque art developed in parts of Europe as well. The Baroque style used contrast, movement, exuberant detail, deep colour, grandeur and surprise to achieve a sense of awe. The style began at the start of the 17th century in Rome, then spread rapidly to France, northern Italy, Spain and Portugal, then to Austria and southern Germany. ");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Als Barock wird eine Epoche der europäischen Kunstgeschichte bezeichnet, die Ende des 16. Jahrhunderts begann und bis ca. 1760/70 reicht. Es handelt sich nicht um einen völlig einheitlichen Stilbegriff, da es innerhalb des Barockzeitalters gleichzeitig zum Teil sehr verschiedene künstlerische Ausprägungen und Unterströmungen und auch eine Entwicklung gab, nicht zuletzt auch große Unterschiede in verschiedenen Gegenden und Ländern. Eine grobe Unterteilung in drei oder vier Unterepochen ist üblich, deren zeitliche Abgrenzung jedoch nicht völlig eindeutig angegeben werden kann: Frühbarock (bis ca. 1650), Hochbarock (ca. 1650–1700), Spätbarock (ca. 1700–1730) und Rokoko (ca. 1730–1760/70). Gelegentlich werden Spätbarock und Rokoko gleichgesetzt, andererseits wird das Rokoko auch als eigenständige Epoche angesehen. ", "Baroque" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Description",
                value: "El Barroco fue un período de la historia en la cultura occidental originado por una nueva forma de concebir el arte (el «estilo barroco») y que, partiendo desde diferentes contextos histórico-culturales, produjo obras en numerosos campos artísticos: literatura, arquitectura, escultura, pintura, música, ópera, danza, teatro, etc. Se manifestó principalmente en la Europa occidental, aunque debido al colonialismo también se dio en numerosas colonias de las potencias europeas, principalmente en Latinoamérica. Cronológicamente, abarcó todo el siglo XVII y principios del XVIII, con mayor o menor prolongación en el tiempo dependiendo de cada país. Se suele situar entre el Manierismo y el Rococó, en una época caracterizada por fuertes disputas religiosas entre países católicos y protestantes, así como marcadas diferencias políticas entre los Estados absolutistas y los parlamentarios, donde una incipiente burguesía empezaba a poner los cimientos del capitalismo. ");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Le baroque est un mouvement artistique qui trouve son origine en Italie dans des villes telles que Rome, Mantoue, Venise et Florence dès le milieu du XVIe siècle et qui se termine au milieu du XVIIIe siècle. Il y a un âge baroque différent selon les domaines, qu'ils soient intellectuels, historiques ou artistiques. Certains critiques y voient une constante culturelle qui revient tout au long de l'histoire comme l'a écrit Eugenio d'Ors.Le baroque, qui touche tous les domaines, se caractérise par l’exagération du mouvement, la surcharge décorative, les effets dramatiques, la tension, l’exubérance des formes, la grandeur parfois pompeuse et le contraste, ce même contraste dont parlait Philippe Beaussant : l’époque baroque a tenté de dire « un monde où tous les contraires seraient harmonieusement possibles »", "Architecture gothique" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "De barok is een Europese stijlperiode die aan het begin van de 17e eeuw in Italië tot ontwikkeling kwam en tot in de eerste helft van de 18e eeuw voortduurde, en die zich kenmerkt door overdaad van vorm en heftigheid van gevoelsuitdrukking. De barok kwam tot uiting op alle terreinen van de cultuur, zoals architectuur, tuinarchitectuur, schilderkunst, beeldhouwkunst, literatuur en muziek. Er wordt een onderscheid gemaakt tussen vroeg-, hoog- en laatbarok. De laatbarok wordt ook wel rococo genoemd.", "Gotische architectuur" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Gothic art was a style of medieval art that developed in Northern France out of Romanesque art in the 12th century AD, led by the concurrent development of Gothic architecture.It spread to all of Western Europe, and much of Southern and Central Europe, never quite effacing more classical styles in Italy. In the late 14th century, the sophisticated court style of International Gothic developed, which continued to evolve until the late 15th century.In many areas, especially Germany, Late Gothic art continued well into the 16th century, before being subsumed into Renaissance art. Primary media in the Gothic period included sculpture, panel painting, stained glass, fresco and illuminated manuscripts.The easily recognizable shifts in architecture from Romanesque to Gothic, and Gothic to Renaissance styles, are typically used to define the periods in art in all media, although in many ways figurative art developed at a different pace.", "Gothic architecture" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Als Barock (Maskulinum „der Barock“, oder gleichwertig Neutrum „das Barock“) wird eine Epoche der europäischen Kunstgeschichte bezeichnet, die Ende des 16. Jahrhunderts begann und bis ca. 1760/70 reicht. Es handelt sich nicht um einen völlig einheitlichen Stilbegriff, da es innerhalb des Barockzeitalters gleichzeitig zum Teil sehr verschiedene künstlerische Ausprägungen und Unterströmungen und auch eine Entwicklung gab, nicht zuletzt auch große Unterschiede in verschiedenen Gegenden und Ländern. Eine grobe Unterteilung in drei oder vier Unterepochen ist üblich, deren zeitliche Abgrenzung jedoch nicht völlig eindeutig angegeben werden kann: Frühbarock (bis ca. 1650), Hochbarock (ca. 1650–1700), Spätbarock (ca. 1700–1730) und Rokoko (ca. 1730–1760/70). Gelegentlich werden Spätbarock und Rokoko gleichgesetzt, andererseits wird das Rokoko auch als eigenständige Epoche angesehen.Dem Barock voraus gingen die Epochen der Renaissance und des Manierismus, ihm folgte der Klassizismus.", "Gotische Architektur" });

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Description", "Name" },
                values: new object[] { "El Barroco fue un período de la historia en la cultura occidental originado por una nueva forma de concebir el arte (el «estilo barroco») y que, partiendo desde diferentes contextos histórico-culturales, produjo obras en numerosos campos artísticos: literatura, arquitectura, escultura, pintura, música, ópera, danza, teatro, etc. Se manifestó principalmente en la Europa occidental, aunque debido al colonialismo también se dio en numerosas colonias de las potencias europeas, principalmente en Latinoamérica. Cronológicamente, abarcó todo el siglo XVII y principios del XVIII, con mayor o menor prolongación en el tiempo dependiendo de cada país. Se suele situar entre el Manierismo y el Rococó, en una época caracterizada por fuertes disputas religiosas entre países católicos y protestantes, así como marcadas diferencias políticas entre los Estados absolutistas y los parlamentarios, donde una incipiente burguesía empezaba a poner los cimientos del capitalismo.Como estilo artístico, el Barroco surgió a principios del siglo XVII (según otros autores a finales del XVI) en Italia —período también conocido en este país como Seicento—, desde donde se extendió hacia la mayor parte de Europa. Durante mucho tiempo (siglos XVIII y XIX) el término «barroco» tuvo un sentido peyorativo, con el significado de recargado, engañoso, caprichoso, hasta que fue posteriormente revalorizado a finales del siglo XIX por Jacob Burckhardt y, en el XX, por Benedetto Croce y Eugenio d'Ors. Algunos historiadores dividen el Barroco en tres períodos: «primitivo» (1580-1630), «maduro» o «pleno» (1630-1680) y «tardío» (1680-1750).", "Arquitectura gótica" });
        }
    }
}
