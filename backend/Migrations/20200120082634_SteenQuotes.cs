using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class SteenQuotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Description",
                value: "<p><strong>1088</strong> <br>Nombrado por primera vez como residencia de los condes de Flandes </p> <p><strong>Siglo XII</strong> <br>Los condes abandonan el edificio y se instalan en el <em>Love</em> al otro lado del Burg (la actual <em>Landhuis</em> del <em>Brugse Vrije</em>), el <em>Steen</em> pasa a ser una cárcel&nbsp;</p> <p><strong>1689</strong> <br>El edificio se incendia casi en su totalidad </p> <p><strong>1751</strong> <br>La ciudad de Brujas pasa a ser propietaria del <em>Steen</em> y lo manda demoler en 1784 &nbsp;&nbsp;</p> <p><strong>1851</strong> <br>Se instala una herrería en este sitio </p> <p><strong>1931</strong> <br>Construcción de un edificio con tres fachadas escalonadas de estilo neogótico (en la actualidad <em>Brasserie Tompouce</em>)</p> <p><strong>1977</strong> <br>Construcción del pasaje comercial de <em>Ter Steeghere</em></p>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingTranslation",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Description",
                value: "<p><strong>1088</strong> <br>Nombrado por primera vez como residencia de los condes de Flandes </p> <p><strong>Siglo XII</strong> <br>Los condes abandonan el edificio y se instalan en el «<em>Love</em>» al otro lado del Burg (la actual <em>Landhuis</em> del <em>Brugse Vrije</em>), el <em>Steen</em> pasa a ser una cárcel&nbsp;</p> <p><strong>1689</strong> <br>El edificio se incendia casi en su totalidad </p> <p><strong>1751</strong> <br>La ciudad de Brujas pasa a ser propietaria del <em>Steen</em> y lo manda demoler en 1784 &nbsp;&nbsp;</p> <p><strong>1851</strong> <br>Se instala una herrería en este sitio </p> <p><strong>1931</strong> <br>Construcción de un edificio con tres fachadas escalonadas de estilo neogótico (en la actualidad <em>Brasserie Tompouce</em>)</p> <p><strong>1977</strong> <br>Construcción del pasaje comercial de <em>Ter Steeghere</em></p>");
        }
    }
}
