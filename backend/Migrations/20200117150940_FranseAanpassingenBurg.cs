using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class FranseAanpassingenBurg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 87L,
                column: "Text",
                value: "La Place du Bourg sur la Carte de Marcus Gerards (1561-1562).");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 192L,
                column: "Text",
                value: "L’emplacement de l’ancien château « Steen ».");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 197L,
                column: "Text",
                value: "« Steen » était probablement la première résidence des comtes de Flandre.");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Description",
                value: "<p><strong>11<sup>e</sup> siècle</strong><br>Construction du « Love », la résidence des comtes de Flandre.</p><p><strong>15<sup>e</sup> siècle</strong><br>L’administration du Franc de Bruges (la campagne brugeoise) déménage du bâtiment « Steen » pour s’installer dans ce bâtiment situé de l’autre côté.</p><p><strong>1520-1525</strong><br>Construction d’une salle échevinale avec une cheminée monumentale.</p><p><strong>1528-1532</strong><br>Construction d’une galerie avec arches.</p><p><strong>17<sup>e</sup> siècle</strong><br>Nouvelle extension avec une chapelle et une chambre des orphelins.</p><p><strong>1722-1727</strong><br>Transformation dans un style classique.</p><p><strong>1794</strong><br>La maison du Franc de Bruges devient un tribunal.</p><p><strong>1984</strong><br>Le bâtiment est utilisé par l’administration de la ville de Bruges.</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Description",
                value: "<p><strong>1280</strong><br>Après un incendie dans le Beffroi sur la Grand-Place, les échevins prennent possession de la « ghyselhuus », l’ancienne prison comtale.</p><p><strong>1376</strong><br>Le comte Louis de Male fait démolir la « ghyselhuus » pour la remplacer par une véritable « scepenhuus » imaginée par Jan Roegiers.</p><p><strong>1887</strong><br>Un incendie ravage l’intérieur.</p><p><strong>1895-1905</strong><br>Louis Delacenserie et Jean-Baptiste de Béthune rénovent l’intérieur dans un style néogothique.</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Description",
                value: "<p><strong>1134-1149</strong> <br>Construction d’une double chapelle romane pour les comtes de Flandre qui séjournent dans le « Steen » adjacent : la chapelle Saint-Basile inférieure et, plus tard, la chapelle du Saint-Sang supérieure. </p> <p><strong>13<sup>e</sup> siècle</strong> <br>La relique du Saint-Sang est conservée dans la chapelle supérieure. </p> <p><strong>15<sup>e</sup> siècle</strong> <br>Restauration de la chapelle supérieure dans un style gothique. </p> <p><strong>1528-1532</strong> <br>Construction d’un escalier de style gothique tardif pour accéder à la chapelle du Saint-Sang. </p> <p><strong>1819-1839</strong> <br>Reconstruction et restauration des chapelles avec la dévastation et le déclin sous la domination française. </p> <p><strong>1923</strong> <br>Élévation de la chapelle du Saint-Sang au rang de basilique. </p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 31L,
                column: "Description",
                value: "<p>La prévôté est (1666) l’ancien siège de la seigneurie ecclésiastique de Saint-Donatien.</p> <p>Le bâtiment de style baroque triomphaliste a été conçu par l’architecte Cornelis Verhouve et le chanoine Frederic Hillewerve, tous deux originaires d’Anvers. Les influences anversoises sont clairement visibles dans le bâtiment.</p> <p>La prévôté fait aujourd’hui partie de la résidence officielle du gouverneur de la province de Flandre occidentale.</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 36L,
                column: "Description",
                value: "<p><strong>944</strong> <br>Le comte Arnulf Ier fait construire ici une chapelle octogonale sur le modèle de la cathédrale d’Aix-la-Chapelle. </p> <p><strong>Du 10<sup>e</sup> au 13<sup>e</sup> siècle</strong> <br>Construction d’une église romane avec un cloître. </p> <p><strong>14<sup>e</sup> siècle</strong> <br>Construction d'une nef centrale et de nefs latérales dans un style gothique. </p> <p><strong>1559</strong> <br>Création du diocèse de Bruges : l’église devient une cathédrale. </p> <p><strong>1799</strong> <br>La cathédrale est vendue et est démolie sous le régime révolutionnaire français. </p> <p><strong>Fin des années 1920</strong> <br>L’hôtel Saint-Georges y ouvre ses portes. </p> <p><strong>1987-1991</strong> <br>Construction de l’hôtel Crowne Plaza. Les fondations de l’église qui datent du 12<sup>e</sup> siècle peuvent être admirées dans les caves de l’hôtel.</p>");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Classicisme#Architecture_classique");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 87L,
                column: "Text",
                value: "La Place du Bourg sur la Carte de Marcus Gerards (1591-1562).");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 192L,
                column: "Text",
                value: "L’emplacement de l’ancien château Steen.");

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 197L,
                column: "Text",
                value: "« Het Steen » était probablement la première résidence des comtes de Flandre.");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Description",
                value: "<p><strong>11<sup>e</sup> siècle</strong><br>Construction de « Love », la résidence des comtes de Flandre.</p><p><strong>15<sup>e</sup> siècle</strong><br>L’administration du Franc de Bruges (la campagne brugeoise) déménage du bâtiment « Het Steen » pour s’installer dans ce bâtiment situé de l’autre côté.</p><p><strong>1520-1525</strong><br>Construction d’une salle échevinale avec une cheminée monumentale.</p><p><strong>1528-1532</strong><br>Construction d’une galerie avec arches.</p><p><strong>17<sup>e</sup> siècle</strong><br>Nouvelle extension avec une chapelle et une chambre des orphelins.</p><p><strong>1722-1727</strong><br>Transformation dans un style classique.</p><p><strong>1794</strong><br>La maison du Franc de Bruges devient un tribunal.</p><p><strong>1984</strong><br>Le bâtiment est utilisé par l’administration de la ville de Bruges.</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Description",
                value: "<p><strong>1280</strong><br>Après un incendie dans le Beffroi sur la Grand-Place, les échevins prennent possession de la « ghyselhuus », l’ancienne prison comtale.</p><p><strong>1376</strong><br>Le comte Lodewijk van Male fait démolir la « ghyselhuus » pour la remplacer par une véritable « scepenhuus » imaginée par Jan Roegiers.</p><p><strong>1887</strong><br>Un incendie ravage l’intérieur.</p><p><strong>1895-1905</strong><br>Louis Delacenserie et Jean-Baptiste de Béthune rénovent l’intérieur dans un style néogothique.</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Description",
                value: "<p><strong>1134-1149</strong> <br>Construction d’une double chapelle romane pour les comtes de Flandre qui séjournent dans le « Het Steen » adjacent : la chapelle Saint-Basile inférieure et, plus tard, la chapelle du Saint-Sang supérieure. </p> <p><strong>13<sup>e</sup> siècle</strong> <br>La relique du Saint-Sang est conservée dans la chapelle supérieure. </p> <p><strong>15<sup>e</sup> siècle</strong> <br>Restauration de la chapelle supérieure dans un style gothique. </p> <p><strong>1528-1532</strong> <br>Construction d’un escalier de style gothique tardif pour accéder à la chapelle du Saint-Sang. </p> <p><strong>1819-1839</strong> <br>Reconstruction et restauration des chapelles avec la dévastation et le déclin sous la domination française. </p> <p><strong>1923</strong> <br>Élévation de la chapelle du Saint-Sang au rang de basilique. </p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 31L,
                column: "Description",
                value: "<p>La prévôté est l’ancien siège de la seigneurie ecclésiastique de Saint-Donatien.</p> <p>Le bâtiment de style baroque triomphaliste a été conçu par l’architecte Cornelis Verhouve et le chanoine Frederic Hillewerve, tous deux originaires d’Anvers. Les influences anversoises sont clairement visibles dans le bâtiment.</p> <p>La prévôté fait aujourd’hui partie de la résidence officielle du gouverneur de la province de Flandre occidentale.</p>");

            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 36L,
                column: "Description",
                value: "<p><strong>944</strong> <br>Le comte Arnulf Ier fait construire ici une chapelle octogonale sur le modèle de la cathédrale d’Aix-la-Chapelle. </p> <p><strong>Du 10<sup>e</sup> au 13<sup>e</sup> siècle</strong> <br>Construction d’une église romane avec un couvent. </p> <p><strong>14<sup>e</sup> siècle</strong> <br>Construction d'une nef centrale et de nefs latérales dans un style gothique. </p> <p><strong>1559</strong> <br>Création du diocèse de Bruges : l’église devient une cathédrale. </p> <p><strong>1799</strong> <br>La cathédrale est vendue et est démolie sous le régime révolutionnaire français. </p> <p><strong>Fin des années 1920</strong> <br>L’hôtel Saint-Georges y ouvre ses portes. </p> <p><strong>1987-1991</strong> <br>Construction de l’hôtel Crowne Plaza. Les fondations de l’église qui datent du 12<sup>e</sup> siècle peuvent être admirées dans les caves de l’hôtel.</p>");

            migrationBuilder.UpdateData(
                table: "MovementTranslation",
                keyColumn: "Id",
                keyValue: 21L,
                column: "SourceLink",
                value: "https://fr.wikipedia.org/wiki/Classicisme#Architecture");
        }
    }
}
