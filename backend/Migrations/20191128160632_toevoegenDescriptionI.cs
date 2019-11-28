using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class toevoegenDescriptionI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Description",
                value: "Ce tableau représente un vers de la Bible : ‘De là étant allé plus loin, Jésus vit un homme assis au lieu des péages, et qui s’appelait Matthieu. Il lui dit: Suis-moi. Cet homme se leva, et le suivit.’ (Matthieu 9:9). La personne âgée derrière la table est probablement Matthieu. Jésus lui fait signe. L’adolescent assis à l’autre côté de la table semble être quelqu’un qui vient payer ses dettes chez Matthieu, le publicain. Il semble penser que le Christ lui appelle. En bas à droite, un chien grondant regarde la scène. Le tableau a clairement été inspiré par celui de Caravaggio du même nom. Cependant, Van Oost a peint beaucoup plus de figures. Il détourne ainsi l’attention de l’essence de la scène. Vers 1870, ce tableau a été donné à l’église Notre-Dame de Bruges. En 1944, la marine allemande l’enlève et l’héberge dans la mine de sel d’Altaussee (Autriche). Un an plus tard, le tableau revient à Bruges. (D’après : Jean-Luc Meulemeester, Jacob van Oost de Oudere en het zeventiende-eeuwse Brugge, Brugge 1984.)");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Description",
                value: "Het schilderij verbeeldt een vers uit de Bijbel: ‘Toen Jezus vandaar verder ging, zag Hij iemand aan het tolhuis zitten die Mattheüs heette, en Hij zei tot hem: “Volg mij.” De man stond op en volgde Hem.’ (Mattheüs 9:9). De oudere man achter de tafel is waarschijnlijk Mattheüs. Christus wenkt naar hem. De jongere man aan de andere zijde van de tafel komt wellicht zijn schulden afbetalen bij tollenaar Mattheüs. Hij lijkt te denken dat Christus hem roept. Rechts beneden kijkt een hond grommend toe. Het schilderij is duidelijk geïnspireerd op het gelijknamige werk van Caravaggio, maar Van Oost heeft veel meer figuren opgesteld. Daardoor leidt hij de aandacht van af van de essentie. Omstreeks 1870 wordt het schilderij geschonken aan de Onze-Lieve-Vrouwekerk in Brugge. In 1944 neemt de Duitse marine het weg en brengt het onder in de zoutmijn van Altaussee (Oostenrijk). Een jaar later komt het terug naar Brugge. (Naar: Jean-Luc Meulemeester, Jacob van Oost de Oudere en het zeventiende-eeuwse Brugge, Brugge 1984.)");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Description",
                value: "The painting depicts a verse from the Bible: ‘And when Jesus passed on from hence, he saw a man sitting in the custom house, named Matthew; and he saith to him: Follow me. And he rose up and followed him.’ (Matthew 9:9). The elderly man behind the table is probably Matthew. Christ beckons him. The young man sitting on the other side of the table probably wants to pay off his debts to Matthew, the publican. He seems to think that Christ calls him. In the lower right corner, a growling dog observes the scene. The painting is clearly inspired by the work of Caravaggio of the same name, but Van Oost has depicted more figures, diverting the attention from the painting’s essence. Around 1870, this painting was donated to the Church of Our Lady in Bruges. In 1944, the German marine transported it to the salt mine of Altaussee (Austria). It was returned to Bruges a year later. (After: Jean-Luc Meulemeester, Jacob van Oost de Oudere en het zeventiende-eeuwse Brugge, Brugge 1984.)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Description",
                value: null);
        }
    }
}
