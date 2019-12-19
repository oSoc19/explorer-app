using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class theoloogAanpassing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Description",
                value: "Un théologien, vraisemblablement un jésuite, lit et commente les décisions des conciles ecclésiastiques. Son secrétaire prend des notes. Le pupitre à gauche, décoré d'une sculpture d'un groupe de calvaire, tient le tome 36 des décisions des conciles. Sur la table, couverte d'une nappe richement colorée, se trouvent un globe en un livre, des attributs relatifs aux études. Sur l'arrière-plan, on voit une bibliothèque, remplie de plusieurs éditions de la Bible et de la littérature sur la théologie, l'exégèse et le droit canonique. En haut à gauche, on lit l'âge du théologien: 'Aetatis 47' (à l'âge de 47 ans). Comme souvent, Van Oost s'inspire ici des portraits d'Anthony Van Dyck. ");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Description",
                value: "Een theoloog, waarschijnlijk een jezuïet, leest de conciliebesluiten en becommentarieert ze. Zijn seculiere secretaris noteert. Links staat de lezenaar, versierd met een sculptuur van een Calvariegroep, en met deel 36 van de verzamelde conciliebesluiten er op. Rechts een werktafel met een rijk gekleurd tafelkleed, waaraan de priester en de secretaris zitten. Op de tafel bevinden zich studie-attributen, zoals een wereldbol en een boek. Erachter ziet men een boekenkast met bijbeluitgaven en literatuur op het gebied van theologie, exegese en kerkelijk recht. Linksboven staat de leeftijd van de theoloog: 'Aetatis 47' (op de leeftijd van 47 jaar). Zoals vaak, inspireert Van Oost zich ook hier weer op de portretten van Anthony van Dyck. ");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Description",
                value: "A theologian, probably a Jesuit, reads and comments on the council decisions. His secular secretary notes. On the left is the lectern, decorated with a sculpture of a Calvary group, and with part 36 of the collected council decrees on it. On the right a work table with a richly coloured tablecloth, on which the priest and the secretary are seated. On the table there are study attributes, such as a globe and a book. Behind it is a bookcase with biblical editions and literature in the field of theology, exegesis and ecclesiastical law. In the upper left corner is the age of the theologian: 'Aetatis 47' (at the age of 47). As is often the case, Van Oost is again inspired by the portraits of Anthony van Dyck. ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Description",
                value: "Een theoloog, waarschijnlijk een jezuïet, leest de conciliebesluiten en becommentarieert ze. Zijn seculiere secretaris noteert. Links staat de lezenaar, versierd met een sculptuur van een Calvariegroep, en met deel 36 van de verzamelde conciliebesluiten er op. Rechts een werktafel  met een rijk gekleurd tafelkleed, waaraan de priester en de secretaris zitten. Op de tafel bevinden zich studie-attributen, zoals een wereldbol en een boek. Erachter ziet men een boekenkast met bijbeluitgaven en literatuur op het gebied van theologie, exegese en kerkelijk recht. Zoals vaak, inspireert Van Oost zich ook hier weer op de portretten van Anthony van Dyck. ");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Description",
                value: "A theologian, probably a Jesuit, reads and comments on the council decisions. His secular secretary notes. On the left is the lectern, decorated with a sculpture of a Calvary group, and with part 36 of the collected council decrees on it. On the right a work table with a richly coloured tablecloth, on which the priest and the secretary are seated. On the table there are study attributes, such as a globe and a book. Behind it is a bookcase with biblical editions and literature in the field of theology, exegesis and ecclesiastical law. As is often the case, Van Oost is again inspired by the portraits of Anthony van Dyck. ");
        }
    }
}
