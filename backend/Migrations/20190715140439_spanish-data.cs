using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class spanishdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 5L, "ES", "Español" });

            migrationBuilder.InsertData(
                table: "ArtistTranslation",
                columns: new[] { "Id", "ArtistId", "Description", "LanguageId" },
                values: new object[,]
                {
                    { 24L, 1L, "Lucas Achtschellinck (Bruselas 1626–1699) fue un pintor barroco flamenco, especializado en la pintura de paisaje.Nació en Bruselas donde fue bautizado el 16 de enero de 1605. Entró como aprendiz de Pieter van der Borcht II en 1639 y aprendió la técnica de la pintura de paisaje con Lodewijk de Vadder. En 1657 fue aprobado como maestro en su ciudad natal, donde entre 1687 y 1689 desempeñó el cargo de decano de la corporación. Tuvo como discípulo a Theobald Michau.1 Influido por Jacques d'Arthois, sus paisajes, inspirados en el bosque de Soignes, siguen los efectos atmosféricos de los paisajes de Rubens, amplificando su valor pictórico y decorativo por la utilización de sutiles gradaciones de color.2 De él se conocen algunos paisajes animados con escenas bíblicas pintados para iglesias y conventos y, como en otros casos, es posible que colaborase con otros maestros, a los que pudo proporcionar los fondos de paisaje además de ocuparse en la ejecución de cartones para tapices.", 5L },
                    { 25L, 2L, "Jacob van Oost I o el Viejo (Brujas, 1603 – 1671), fue un pintor barroco flamenco, especializado en pintura religiosa e historiada y retratos.Nacido en Brujas, donde fue bautizado el 7 de enero de 1603, en octubre de 1621 ingresó en el gremio de San Lucas de su ciudad natal. Inmediatamente debió de marchar a Italia donde fue influido por la pintura caravaggista. De nuevo en Brujas, en 1629 fue elegido vicario del gremio y un año después contrajo matrimonio con Jaquemyne van Overdille, de la que enviudó en 1631, tras dar a luz a su hijo Martín. En 1633 casó en segundas nupcias con María van Tollenaere, con quien tuvo seis hijos, entre ellos el también pintor Jacob van Oost, llamado el joven. Decano del gremio de San Lucas en 1633-1634 y en 1643-1644, en enero de 1662 se le documenta por última vez como vicario de la organización gremial.Tuvo numerosos discípulos trabajando en su taller, entre ellos dos aprendices de origen portugués o español: Franscoeis o Francisco Gomes y Jan o Juan Ramón, documentados en Brujas en 1640 y 1666 respectivamente.Desde su primera obra firmada y fechada, la Adoración de los pastores del Museo del Ermitage(1630), caravaggista en el tratamiento de la luz y en la elección de los tipos populares, Van Oost fue frecuentemente reclamado por las iglesias locales para pintar retablos adaptados a la nueva sensibilidad contrarreformista. La influencia de Caravaggio no fue, no obstante, la única influencia italiana de Van Oost, que derivó tempranamente hacia las formulaciones clasicistas de Domenichino a la vez que aclaraba su paleta.", 5L },
                    { 26L, 3L, "Jacob van Oost II o el Joven (Brujas, 1639 – 1713) fue un pintor barroco flamenco, especializado en retratos y pintura historiada y de género.Hijo y discípulo de Jacob van Oost el Viejo, nació en Brujas, donde fue bautizado el 11 de febrero de 1639. Tras completar su formación en Roma, en el entorno de Simon Vouet, en 1668 se estableció en Lille donde en 1670 casó con Marie Bourgeois. En Lille trabajó principalmente para las iglesias y conventos de la ciudad —San Carlos Borromeo orando por el fin de la peste y San Antonio de Padua con el Niño Jesús para la iglesia de San Mauricio, la Resurrección de Lázaro para la iglesia de la Magdalena o San Macario de Gante socorriendo a los apestados, pasada al Museo del Louvre— en un estilo suave, influido tanto por el tardobarroco romano como por el clasicismo francés.2 Tras enviudar hacia 1697, en 1708 retornó a Brujas donde falleció el 29 de septiembre de 1713.", 5L },
                    { 27L, 4L, "Artus Wolffort, Wolfordt o Wolffaert (Amberes, 1581 -1641) fue un pintor barroco flamenco especializado en pintura historiada, principalmente de asunto religioso, aunque también cultivó el paisaje y el retrato.Formado en Dordrecht, ciudad a la que se habían trasladado sus padres cuando apenas contaba un año, en 1616 se encontraba de nuevo en Amberes, trabajando durante un corto espacio de tiempo en el taller de Otto van Veen, uno de los maestros de Rubens. Admitido en el gremio local de San Lucas en 1617, el 8 de septiembre de 1619 contrajo matrimonio con María Vandelaer. Del matrimonio nació en 1625 Jan-Baptiste Wolfaerts, quien llegaría a ser pintor especializado en paisajes y ocasionalmente copista de las obras paternas.Aunque recibió algún encargo importante con destino a la iglesia de San Pablo de Amberes, el grueso de su producción está formado por escenas evangélicas y series de apóstoles, evangelistas y padres de la Iglesia, destinadas a particulares. La abundancia de copias de sus obras y su desigual calidad, ha hecho suponer que se situase a la cabeza de un numeroso taller desde el que atender las demandas del mercado de arte. En él se formaron, además de su hijo, Peter van Lint y Peter van Mol.Su pintura, aunque arraigada en el clasicismo de Otto van Veen, recibe también influencias del más vitalista y animado estilo de Rubens, incluso adaptando composiciones de este al más seco estilo de su maestro.", 5L },
                    { 28L, 5L, "Erasmus Quellinus II, también llamado Erasmus el Joven(Amberes, 1607- 1678), fue un pintor y dibujante flamenco, miembro de una familia de artistas, principalmente escultores, oficio desempeñado por su padre Erasmus Quellinus I y su hermano, Artus Quellinus.Erasmus se formó inicialmente con su padre, pero habiendo optado por la pintura se inclinó hacia los pintores caravaggistas flamencos como Theodoor Rombouts o Gerard Seghers, para crear mediante el uso de la luz figuras rotundas de modelado escultórico.Hacia 1633 se estableció como maestro pintor independiente, ingresando en el Gremio de San Lucas de su ciudad natal, a la vez que comenzó a colaborar con Rubens, primero en las lujosas arquitecturas efímeras levantadas para conmemorar la «joyeuse entrée» del cardenal-infante don Fernando de Austria en la ciudad de Amberes el 15 de abril de 1635,1 y a continuación en el amplio ciclo de pinturas mitológicas encargadas por Felipe IV para la decoración de la Torre de la Parada, en el que Rubens se encontraba trabajando ya en noviembre de 1636.2 A Quellinus correspondieron en este encargo seis cuadros realizados sobre los bocetos de Rubens, todos ellos conservados en el Museo del Prado. A partir de este momento su pintura se hizo más ampulosa, eligiendo para sus escenas de asunto tanto histórico como mitológico o religioso lujosos fondos arquitectónicos de raíz clasicista.Colaboró también con cierta frecuencia con Daniel Seghers y con su cuñado Jan Philip van Thielen, pintando las figuras de sus célebres guirnaldas florales y, a partir de 1656, con su hermano Artus se encargó de la decoración del nuevo Ayuntamiento de Ámsterdam. Como dibujante proporcionó los diseños para series de tapices, como la dedicada a la historia de la familia Thurn und Taxis.Entre sus discípulos y colaboradores se contó su hijo, Jan Erasmus Quellinus.", 5L },
                    { 29L, 6L, "Peter Lely (Soest, Westfalia; 14 de septiembre de 1618-Covent Garden, Londres, Inglaterra; 30 de noviembre de 1680) fue un retratista danés, nacido en Soest, Westfalia, cuyo verdadero nombre era Pieter van der Faes.Se formó artísticamente en Haarlem, Países Bajos. En 1641 se estableció en Londres, y poco después recibió el encargo de retratar a los principales personajes de la corte inglesa.Carlos II de Inglaterra le nombró pintor de cámara en 1661 y le armó caballero en 1680.Su pintura, rica sobre todo en el colorido de los elegantes ropajes de los retratados, tiene una clara influencia de Anton van Dyck. La serie de cuadros Bellezas de Windsor (década de 1660) se encuentra en el palacio de Hampton Court, Londres. Otra serie, denominada Almirantes, se conserva en el Museo Marítimo Nacional de Greenwich, Londres.", 5L }
                });

            migrationBuilder.InsertData(
                table: "MovementTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "MovementId", "Name" },
                values: new object[] { 5L, "El Barroco fue un período de la historia en la cultura occidental originado por una nueva forma de concebir el arte (el «estilo barroco») y que, partiendo desde diferentes contextos histórico-culturales, produjo obras en numerosos campos artísticos: literatura, arquitectura, escultura, pintura, música, ópera, danza, teatro, etc. Se manifestó principalmente en la Europa occidental, aunque debido al colonialismo también se dio en numerosas colonias de las potencias europeas, principalmente en Latinoamérica. Cronológicamente, abarcó todo el siglo XVIIy principios del XVIII, con mayor o menor prolongación en el tiempo dependiendo de cada país. Se suele situar entre el Manierismo y el Rococó, en una época caracterizada por fuertes disputas religiosas entre países católicos y protestantes, así como marcadas diferencias políticas entre los Estados absolutistas y los parlamentarios, donde una incipiente burguesía empezaba a poner los cimientos del capitalismo.Como estilo artístico, el Barroco surgió a principios del siglo XVII (según otros autores a finales del XVI) en Italia —período también conocido en este país como Seicento—, desde donde se extendió hacia la mayor parte de Europa. Durante mucho tiempo (siglos XVIII y XIX) el término «barroco» tuvo un sentido peyorativo, con el significado de recargado, engañoso, caprichoso, hasta que fue posteriormente revalorizado a finales del siglo XIX por Jacob Burckhardt y, en el XX, por Benedetto Croce y Eugenio d'Ors. Algunos historiadores dividen el Barroco en tres períodos: «primitivo» (1580-1630), «maduro» o «pleno» (1630-1680) y «tardío» (1680-1750).", 5L, 1L, "Barroco" });

            migrationBuilder.InsertData(
                table: "PaintingTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "Name", "PaintingId" },
                values: new object[,]
                {
                    { 44L, null, 5L, "Retrato de Samuel Crew", 8L },
                    { 43L, null, 5L, "Achilles entre las hijas de Licomedes", 7L },
                    { 42L, null, 5L, "Retrato de Fovin de Hasque", 6L },
                    { 41L, null, 5L, "Santa Trinidad", 5L },
                    { 38L, null, 5L, "Retrato de una familia de Brujas", 2L },
                    { 39L, null, 5L, "Retrato de un Teólogo y su secretario", 3L },
                    { 45L, null, 5L, "El llamado de San Mateo", 9L },
                    { 37L, null, 5L, "Paisaje boscoso con fuerte", 1L },
                    { 40L, null, 5L, "Retrato de un hombre", 4L }
                });

            migrationBuilder.InsertData(
                table: "TechniqueTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "Name", "TechniqueId" },
                values: new object[] { 5L, "Una pintura al aceite es un tipo de pintura de secado lento que consiste de partículas de pigmentos en suspensión en un aceite secante. Las pinturas al aceite han sido utilizadas en Inglaterra desde el siglo XIII para decoración,1​ pero no se popularizaron para usos artísticos sino hasta el siglo XV. Los usos modernos más comunes de pinturas al aceite son la decoración de casas, donde su resistencia y colores luminosos las hacen apropiadas tanto para usos en interiores como en exteriores. Sus propiedades de secado lento han sido aprovechadas recientemente para realizar animación mediante pintura sobre vidrio.Cuando se la utiliza para fines artísticos es llamada pintura al óleo.", 5L, "Pintura al aceite", 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "TechniqueTranslation",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
