using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class MovementBuilding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingTranslation_Painting_BuildingId",
                table: "BuildingTranslation");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingTranslation_Building_BuildingId1",
                table: "BuildingTranslation");

            migrationBuilder.DropIndex(
                name: "IX_BuildingTranslation_BuildingId1",
                table: "BuildingTranslation");

            migrationBuilder.DropColumn(
                name: "BuildingId1",
                table: "BuildingTranslation");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BuildingTranslation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BuildingTranslation",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MovementId",
                table: "Building",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Movement",
                column: "Id",
                value: 2L);

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

            migrationBuilder.InsertData(
                table: "MovementTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "MovementId", "Name", "SourceLink" },
                values: new object[,]
                {
                    { 6L, "Le baroque est un mouvement artistique qui trouve son origine en Italie dans des villes telles que Rome, Mantoue, Venise et Florence dès le milieu du xvie siècle et qui se termine au milieu du xviiie siècle. Il y a un âge baroque différent selon les domaines, qu'ils soient intellectuels, historiques ou artistiques. Certains critiques y voient une constante culturelle qui revient tout au long de l'histoire comme l'a écrit Eugenio d'Ors.Le baroque, qui touche tous les domaines, se caractérise par l’exagération du mouvement, la surcharge décorative, les effets dramatiques, la tension, l’exubérance des formes, la grandeur parfois pompeuse et le contraste, ce même contraste dont parlait Philippe Beaussant : l’époque baroque a tenté de dire « un monde où tous les contraires seraient harmonieusement possibles »", 1L, 2L, "Architecture gothique", "https://fr.wikipedia.org/wiki/Architecture_gothique" },
                    { 7L, "De barok is een Europese stijlperiode die aan het begin van de 17e eeuw in Italië tot ontwikkeling kwam en tot in de eerste helft van de 18e eeuw voortduurde, en die zich kenmerkt door overdaad van vorm en heftigheid van gevoelsuitdrukking. De barok kwam tot uiting op alle terreinen van de cultuur, zoals architectuur, tuinarchitectuur, schilderkunst, beeldhouwkunst, literatuur en muziek. Er wordt een onderscheid gemaakt tussen vroeg-, hoog- en laatbarok. De laatbarok wordt ook wel rococo genoemd.", 2L, 2L, "Gotische architectuur", "https://nl.wikipedia.org/wiki/Gotiek_(bouwkunst)" },
                    { 8L, "Gothic art was a style of medieval art that developed in Northern France out of Romanesque art in the 12th century AD, led by the concurrent development of Gothic architecture.It spread to all of Western Europe, and much of Southern and Central Europe, never quite effacing more classical styles in Italy. In the late 14th century, the sophisticated court style of International Gothic developed, which continued to evolve until the late 15th century.In many areas, especially Germany, Late Gothic art continued well into the 16th century, before being subsumed into Renaissance art. Primary media in the Gothic period included sculpture, panel painting, stained glass, fresco and illuminated manuscripts.The easily recognizable shifts in architecture from Romanesque to Gothic, and Gothic to Renaissance styles, are typically used to define the periods in art in all media, although in many ways figurative art developed at a different pace.", 3L, 2L, "Gothic architecture", "https://en.wikipedia.org/wiki/Gothic_architecture" },
                    { 9L, "Als Barock (Maskulinum „der Barock“, oder gleichwertig Neutrum „das Barock“) wird eine Epoche der europäischen Kunstgeschichte bezeichnet, die Ende des 16. Jahrhunderts begann[1] und bis ca. 1760/70 reicht. Es handelt sich nicht um einen völlig einheitlichen Stilbegriff, da es innerhalb des Barockzeitalters gleichzeitig zum Teil sehr verschiedene künstlerische Ausprägungen und Unterströmungen und auch eine Entwicklung gab,[2] nicht zuletzt auch große Unterschiede in verschiedenen Gegenden und Ländern.[3]Eine grobe Unterteilung in drei oder vier Unterepochen ist üblich, deren zeitliche Abgrenzung jedoch nicht völlig eindeutig angegeben werden kann: Frühbarock (bis ca. 1650), Hochbarock (ca. 1650–1700), Spätbarock (ca. 1700–1730)[4] und Rokoko (ca. 1730–1760/70). Gelegentlich werden Spätbarock und Rokoko gleichgesetzt, andererseits wird das Rokoko auch als eigenständige Epoche angesehen.Dem Barock voraus gingen die Epochen der Renaissance und des Manierismus, ihm folgte der Klassizismus.", 4L, 2L, "Gotische Architektur", "https://de.wikipedia.org/wiki/Gotik#Baukunst" },
                    { 10L, "El Barroco fue un período de la historia en la cultura occidental originado por una nueva forma de concebir el arte (el «estilo barroco») y que, partiendo desde diferentes contextos histórico-culturales, produjo obras en numerosos campos artísticos: literatura, arquitectura, escultura, pintura, música, ópera, danza, teatro, etc. Se manifestó principalmente en la Europa occidental, aunque debido al colonialismo también se dio en numerosas colonias de las potencias europeas, principalmente en Latinoamérica. Cronológicamente, abarcó todo el siglo XVIIy principios del XVIII, con mayor o menor prolongación en el tiempo dependiendo de cada país. Se suele situar entre el Manierismo y el Rococó, en una época caracterizada por fuertes disputas religiosas entre países católicos y protestantes, así como marcadas diferencias políticas entre los Estados absolutistas y los parlamentarios, donde una incipiente burguesía empezaba a poner los cimientos del capitalismo.Como estilo artístico, el Barroco surgió a principios del siglo XVII (según otros autores a finales del XVI) en Italia —período también conocido en este país como Seicento—, desde donde se extendió hacia la mayor parte de Europa. Durante mucho tiempo (siglos XVIII y XIX) el término «barroco» tuvo un sentido peyorativo, con el significado de recargado, engañoso, caprichoso, hasta que fue posteriormente revalorizado a finales del siglo XIX por Jacob Burckhardt y, en el XX, por Benedetto Croce y Eugenio d'Ors. Algunos historiadores dividen el Barroco en tres períodos: «primitivo» (1580-1630), «maduro» o «pleno» (1630-1680) y «tardío» (1680-1750).", 5L, 2L, "Arquitectura gótica", "https://es.wikipedia.org/wiki/Arquitectura_g%C3%B3tica" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Building_MovementId",
                table: "Building",
                column: "MovementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Building_Movement_MovementId",
                table: "Building",
                column: "MovementId",
                principalTable: "Movement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingTranslation_Building_BuildingId",
                table: "BuildingTranslation",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Building_Movement_MovementId",
                table: "Building");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildingTranslation_Building_BuildingId",
                table: "BuildingTranslation");

            migrationBuilder.DropIndex(
                name: "IX_Building_MovementId",
                table: "Building");

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Movement",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BuildingTranslation");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BuildingTranslation");

            migrationBuilder.DropColumn(
                name: "MovementId",
                table: "Building");

            migrationBuilder.AddColumn<long>(
                name: "BuildingId1",
                table: "BuildingTranslation",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BuildingTranslation_BuildingId1",
                table: "BuildingTranslation",
                column: "BuildingId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingTranslation_Painting_BuildingId",
                table: "BuildingTranslation",
                column: "BuildingId",
                principalTable: "Painting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingTranslation_Building_BuildingId1",
                table: "BuildingTranslation",
                column: "BuildingId1",
                principalTable: "Building",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
