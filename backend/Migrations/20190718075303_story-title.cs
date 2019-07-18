using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class storytitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "PaintingStory",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Description",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "PaintingStory");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Description",
                value: "View of a clearing in the woods, with market vendors and farmers, near a fordable place in a stream. On the other side of the water is a man with two horses. Through the trees one has a view on a distant, partially wooded background, where also people can be seen. The characters in the foreground seem to have been painted by Achtschellinck himself; they are clearly related to the figures of his contemporary David Teniers the Younger. The painting shows a similar in style to the other wooded landscapes of Lucas Achtschellinck in the collection of the Groeninge Museum (0000.GRO0001.I-0000.GRO0003.I, 0000.GRO0005.I). (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, pp. 14).");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Description",
                value: "The bourgeois ostentatiously points to the countryside to draw our attention to his possessions. The low point of view makes that the characters make an impressive impression. The family is unknown, but because of the recognizable silhouette of the city of Bruges, the family has to be situated in a Bruges context. The ages of the family members are unobtrusively integrated: with the man on the heel of his shoe (46), with the woman on her fan (26), with the little boy next to her in his hat (3), with the sitting girl on the pillow in her basket (15), with the young man on his boot (17), and with the child in the arms of the nanny on the piece of bread in her hands (1). From the large age difference between the husbands on the one hand, and the young age of the woman on the other hand, it can be deduced that the children have to come from two marriages. Probably only the two smallest children were born from the marriage with the woman depicted here. On the far left of the painting is a gardener with a spade over his shoulder, descending to the garden. As with most family portraits, this work contains an underlying symbolism, referring to love, purity and fertility, as conditions for a harmonious family life. In addition, the social status of the family is highlighted. (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, pp. 194-195.)");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Description",
                value: "A theologian, probably a Jesuit, reads and comments on the council decisions. His secular secretary notes. On the left is the lectern, decorated with a sculpture of a Calvary group, and with part 36 of the collected council decrees on it. On the right a work table with a richly coloured tablecloth, on which the priest and the secretary are seated. On the table there are study attributes, such as a globe and a book. Behind it is a bookcase with biblical editions and literature in the field of theology, exegesis and ecclesiastical law. As is often the case, Van Oost is again inspired by the portraits of Anthony van Dyck. (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 198; E. Tahon, in: musea@brugge, augustus 2003, pp. 13-14.)");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Description",
                value: "Bust of a man dressed in black in a three-quarter turn. Oval painting, framed in a rectangular frame. From the inscription on the back, this is a friend of the artist. (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, pp. 208.)");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Description",
                value: "God the Father, with tiara on his head, shows Christ, the Son, who ostentatiously shows his wounds. Above them floats the Holy Spirit, in the form of a dove. The iconography followed here has an old tradition: in the end it goes back to Dürer's print of the same name from 1511, which in turn reflects earlier Old Dutch prototypes. In the past, the painting was written successively as a work by Gerard Seghers, a copy after Rubens, by the hand of Nicolaas de Liemaeker, in connection with Abraham Janssens, and attributable to Joos de Momper. The most recent attribution shows that it came from the studio of the Antwerp painter Artus Wolffort. This is mainly based on the characteristic facial typing. There are different versions of this composition.");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Description",
                value: "The fencing master of the Bruges Guild of St Michael is shown here with a sword on his belt. With his right hand he holds the shaft of a halberd or a stand. The inscription reads: This is the image of Fovin d'Hasque Schermmeester van Brugghe vaillant / Die alhier ghebracht heeft de olie van [de] H. Walburgis uyt duytslant / 1670 (Translation: This is the image of Fovin d'Hasque vaillant van Brugge vaillant / Who brought the oil from Schermmeester van H. Walburgis from Germany to this place / 1670). The latter was done by De Hasque in 1669, at the request of the parish priests, chaplains and church masters of Sint-Walburga in Bruges. He died that same year. Possibly this portrait was painted on the occasion of his death. (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 204.)");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Description",
                value: "Thetis was predicted that her son Achilles would be killed in the Trojan War. To avoid this fate, she hid him dressed as a woman at the court of King Lycomedes. For the Greek captains Odysseus and Diomedes, however, Achilles was indispensable. They found out about his hiding place, and with a trick they wanted to expose him. The two commanders gave gifts, including weapons, to the daughters of Lycomedes, including the dressed Achilles. Spontaneously Achilles grabbed a helmet and a sword, by which he betrayed himself. On the left in the foreground of the painting Odysseus and Diomedes are depicted. One of them grabs Achilles by the sleeve, as soon as he fits a helmet and grabs a weapon from the gifts that are in a basket on the right and around which the daughters of Lycomedes gather. The scene takes place on a terrace, with on the left a view of a garden. The Antwerp painter Erasmus Quellinus II belonged to a family of sculptors, painters, etchers and woodcarvers. He was a pupil and collaborator of Peter Paul Rubens, whom he succeeded as a city painter of Antwerp (H. Vlieghe, Stedelijke Musea Brugge. Catalogus Schilderijen 17de en 18de eeuw, Brugge, 1994, p. 143.)");

            migrationBuilder.UpdateData(
                table: "PaintingTranslation",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Description",
                value: "This is an early portrait of Lely from 1650 of Samuel Crew, or his brother Nathaniel Crew, descendants of an important English family and both Protestant priests. Their father John Crew of Stene was a member of the English Parliament and served as Speaker of the House between 1623 and 1625. With this portrait Lely clearly wanted to meet the expectations of his client and his most important patron. With great virtuosity - in which reflections of the portrait art of Frans Hals can be recognised - Lely paints the clothing of the young gentleman (presumably Samuel), with great attention to the texture and the incidence of light on the black textile. The white shirt shines in the middle of the dark, rather sombre atmosphere of the painting. Only the face and hair are clearly emphasized by the incidence of light. Lely does not boldly show his model in the centre of the canvas, but positions the young man just out of the middle axis of the painting. In this way he avoids the formalism of portraits.");
        }
    }
}
