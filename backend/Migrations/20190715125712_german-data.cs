using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class germandata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 4L, "DE", "Deutsch" });

            migrationBuilder.UpdateData(
                table: "TechniqueTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Name",
                value: "Olieverfschilderij");

            migrationBuilder.InsertData(
                table: "ArtistTranslation",
                columns: new[] { "Id", "ArtistId", "Description", "LanguageId" },
                values: new object[,]
                {
                    { 18L, 1L, "Lucas Achtschellinck (* 16. Januar 1626 in Brüssel; † 12. Mai 1699) war ein flämischer Landschaftsmaler.1639 wurde Achtschellinck als Schüler von Peter van der Borcht in die Brüsseler Malergilde aufgenommen und wurde stark beeinflusst von Jacques d’Arthois. 1657 wurde er als Freimeister in Brüssel zugelassen. Seine Bilder zeichnen sich aus durch Großräumigkeit der Bilder, ein kräftiges Grün und eine etwas derbe Formanschauung.Am 13. März 1674 heiratete er Anna Parys.", 4L },
                    { 19L, 2L, "Jakob van Oost der Ältere (* um 1600 in Brügge; † um 1671 in Brügge) war ein flämischer Maler des Barocks in Brügge. Zu seinem Œuvre zählen Historien- und Porträtgemälde.Am 19. Januar 1619 wurde Jakob van Oost als Lehrling seines Bruders Franz van Oost (1618 Freimeister in Brügge; † um 1625) in der Brügger Malergilde aufgelistet. Zu seinem Frühwerk zählen Kopien der Gemälde Jan van Eycksund Peter Paul Rubens, die 1857 teils als Originale galten. Im Jahr 1621 erfolgte seine Ernennung zum Freimeister. Zeitgemäß studierte er in den 20er Jahren in Italien die von Caravaggio beeinflussten Werke Hannibal/Annibale Carraccis. Nach seiner Rückkehr wurde er ab 1630 ein gefragter Auftragskünstler für Porträts, Historiengemälde und Altarwerke. Im Jahr 1633 fand seine Wahl zum Oberhaupt, dem Dekan der Schildergilde statt. Zu seinen Schülern zählten u. a. seine Söhne Jakob van Oost der Jüngere, der die Schule seines Vaters fortsetzte und Willem van Oost (~8. März 1651 in Brügge; † 31. August 1866 ebenda), der Maler und Dominikanerlaienbruder war.Nach seinen Rubenskopien gelangte er zu seinem eigenen Stil in dunkler und toniger Gesamthaltung. Sein Spätwerk ab 1660 besteht aus schwärzlich getonten Werken. Seine Gemälde finden sich in religiösen Einrichtungen und Sammlungen in Brügge, als auch in belgischem Privatbesitz und in folgenden Museen von Bergues, Berlin, Brüssel, Caen, Dijon, Dünkirchen, Leningrad, Lille, London, Lyon, New York City (Histor.Soc.[1] Kat. 1903 und Metropolitan Museum), Oostende, Paris, Tournai, Valenciennes und Wien.", 4L },
                    { 20L, 3L, "Jakob van Oost der Jüngere (* 1637 in Brügge; † 29. September 1713 in Brügge) war ein flämischer Maler des Barocks.Zunächst von seinem Vater Jakob van Oost dem Älteren in Brügge ausgebildet, vertiefte er seine Kunststudien zwei Jahre lang in Paris. Anschließend widmete er sich mehrere Jahre der Antike und den alten Meistern in Rom. Nach seiner Rückkehr in Brügge wollte er zwar zurück nach Paris, blieb aber in Lille bei seinen Freunden aus der Studienzeit und lebte seit 1668 für 41 Jahre in dieser nordfranzösischen Stadt.Jakob van Oost der Jüngere wurde in dieser Stadt neben Arnould de Vuezein anerkannter Porträtmaler[1]. Zeitgemäß beinhalteten seine Gemälde religiöse Themen. Im Jahr 1670 heiratete er Marie Bourgeois aus Lille, die ihm unter anderem den Sohn Dominique van Oost gebar, welcher ebenfalls Maler wurde.Im Jahr 1709 verließ er als Folge des Spanischen Erbfolgekriegs Lille und kehrte zum Schutz vor dem Krieg in seine Heimatstadt Brügge zurück, wo er vier Jahre später 76-jährig verstarb.", 4L },
                    { 21L, 4L, "Artus Wolffordt (* 1581 in Antwerpen; † 1641 ebenda) (auch: Wolfaerts, Wolffort, Wolfert) war ein flämischer Maler.Kurz nach seiner Geburt zogen seine Eltern nach Dordrecht. Am 29. Dezember 1603 wurde er dort Mitglied in der St. Lucasgilde, doch bald wieder aus ihr gestrichen, da er nicht mehr vermögend genug war. 1615 wurde er Assistent von Otto van Veen in Antwerpen. 1617 soll er in der Kathedrale St. Paul in Antwerpen am Altar Die Auferstehung und Mariä Himmelfahrt gemalt haben.In seiner Werkstatt sind zahlreiche Werke mit religiösen Motiven entstanden.Zu seinen Schülern zählten Pieter Van Mol (1599–1650) und Pieter van Lint(1609–1690).", 4L },
                    { 22L, 5L, "Erasmus Quellinus II., auch Erasmus Quellinus der Jüngere, (* 19. November 1607 in Antwerpen; † 7. November1678 ebenda) war ein flämischer Maler, Schüler von Rubens, und Kupferstecher aus der Antwerpener KünstlerfamilieQuellinus.Er ist Sohn des Bildhauers Erasmus Quellinus I. und Bruder von Artus Quellinus I. und Hubertus Quellinus. Er wurde nach seiner Ausbildung bei Rubens 1633/34 Meister der Antwerpener Lukasgilde. Nach dem Tod von Rubens wurde er Stadtmaler von Antwerpen und überführte die ausgesprochen barocke Kunstauffassung von Rubens in eine eher klassizistisch grundierte Malerei. Gut dokumentieren lässt sich diese Neuorientierung an einem seiner wichtigsten Ausstattungsprojekte, die des Paleis op de Dam in Amsterdam, das er um 1656 zusammen mit seinem Bruder Artus Quellinus I ausstattete.Sein Sohn Jan Erasmus Quellinus ist ebenfalls eine bekannte Persönlichkeit unter den Barockmalern der Spanischen Niederlande. Er führte die Hinwendung des Vaters zu einer eher klassizistischen Kunstströmung in Flandern in das 18. Jahrhundert fort.", 4L },
                    { 23L, 6L, "Sir Peter Lely (eigentlich Pieter van der Faes, * 14. September 1618 im westfälischen Soest;[1] † 30. November 1680 in London) war ein englischerMaler niederländischer Herkunft.Mit 19 Jahren wurde Lely 1637 Schüler bei Pieter de Grebber in Haarlem. Mit Bürgschaft seines Lehrers de Grebber konnte er auch der Lukasgildebeitreten.1643 ging Lely nach England und ließ sich 1647 in London nieder. Schon bald war er überall im Gespräch, da er seine Porträts ganz im Stil Anthonis van Dycks gestaltete. Da van Dyck vor einigen Jahren gestorben war, schloss Lely mit seinen Bildern eine große Lücke. Darum wurde Lely wahrscheinlich auch die Mitgliedschaft der altehrwürdigen Company of Painter Stainers angeboten.Mit der Zeit wurde Lely, zusammen mit William Dobson, einer der führenden Porträtisten der englischen Revolution unter Oliver Cromwell und der nachfolgenden Herrscher. 1651 bewarb sich Lely für die Gestaltung verschiedener Wandmalereien in Whitehall.Zehn Jahre später berief König Karl II. Lely zu seinem offiziellen Hofmaler. Ein Jahr später, 1662, wurde Lely die britische Staatsbürgerschaft verliehen. In den Jahren 1666 bis 1667 schuf Lely für Anne Hyde eine Serie von Porträts verschiedener Hofdamen; heute noch bekannt unter dem Titel The Windsor Beauties. Fast zeitgleich entstand eine weitere Porträtserie von Admirälen, The Flagmen.Am 11. Januar 1680 wurde Lely von König Karl II. persönlich zum Knight Bachelor („Sir“) geschlagen.[2] Bereits ein Jahr später starb Sir Peter Lely im Alter von 62 Jahren.Nach seiner stark niederländisch beeinflussten Phase gelangte Lely im Alter zu einer gelösten freien Maltechnik. Neben vielen Schülern Lelys sei hier vertretend für alle Nicolas de Largillière genannt.", 4L }
                });

            migrationBuilder.InsertData(
                table: "MovementTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "MovementId", "Name" },
                values: new object[] { 4L, "Als Barock (Maskulinum „der Barock“, oder gleichwertig Neutrum „das Barock“) wird eine Epoche der europäischen Kunstgeschichte bezeichnet, die Ende des 16. Jahrhunderts begann[1] und bis ca. 1760/70 reicht. Es handelt sich nicht um einen völlig einheitlichen Stilbegriff, da es innerhalb des Barockzeitalters gleichzeitig zum Teil sehr verschiedene künstlerische Ausprägungen und Unterströmungen und auch eine Entwicklung gab,[2] nicht zuletzt auch große Unterschiede in verschiedenen Gegenden und Ländern.[3]Eine grobe Unterteilung in drei oder vier Unterepochen ist üblich, deren zeitliche Abgrenzung jedoch nicht völlig eindeutig angegeben werden kann: Frühbarock (bis ca. 1650), Hochbarock (ca. 1650–1700), Spätbarock (ca. 1700–1730)[4] und Rokoko (ca. 1730–1760/70). Gelegentlich werden Spätbarock und Rokoko gleichgesetzt, andererseits wird das Rokoko auch als eigenständige Epoche angesehen.Dem Barock voraus gingen die Epochen der Renaissance und des Manierismus, ihm folgte der Klassizismus.", 4L, 1L, "Baroque" });

            migrationBuilder.InsertData(
                table: "PaintingTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "Name", "PaintingId" },
                values: new object[,]
                {
                    { 35L, null, 4L, "Porträt des Samuel Crew", 8L },
                    { 34L, null, 4L, "Achilles unter den Töchtern des Lycomedes", 7L },
                    { 33L, null, 4L, "Porträt des Fovin de Hasque", 6L },
                    { 32L, null, 4L, "Heilige Dreifaltigkeit", 5L },
                    { 29L, null, 4L, "Porträt einer Brüggener Familie", 2L },
                    { 30L, null, 4L, "Porträt eines Theologen mit seinem Sekretär", 3L },
                    { 36L, null, 4L, "Berufung des Hl. Matthäus", 9L },
                    { 28L, null, 4L, "Waldlandschaft mit Furt", 1L },
                    { 31L, null, 4L, "Porträt eines Mannes", 4L }
                });

            migrationBuilder.InsertData(
                table: "TechniqueTranslation",
                columns: new[] { "Id", "Description", "LanguageId", "Name", "TechniqueId" },
                values: new object[] { 4L, "Die Ölmalerei ist die künstlerische Malerei mit Ölfarben und gilt als „klassische Königsdisziplin“ der Kunst, die insbesondere bei Porträt-, Landschafts-, Stillleben- und Genremalerei zur Anwendung kommt. Die Haltbarkeit und Farbbrillanz der Ölmalerei ist unübertroffen. Öl ist als Bindemittel ein Hauptbestandteil der Ölfarbe, woraus sich die Bezeichnung für die Ölmalerei ableitet.", 4L, "Ölmalerei", 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "ArtistTranslation",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "TechniqueTranslation",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.UpdateData(
                table: "TechniqueTranslation",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Name",
                value: "olieverfschilderij");
        }
    }
}
