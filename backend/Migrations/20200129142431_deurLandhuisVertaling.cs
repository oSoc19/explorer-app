using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class deurLandhuisVertaling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ImageUrl", "Text" },
                values: new object[] { "https://www.visitflanders.com/nl/binaries/b901d286-b88c-4d90-abf1-1d48e61813b0_tcm14-154310.jpg", "Entrée vers la salle échevinale." });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ImageUrl", "Text" },
                values: new object[] { "https://www.visitflanders.com/nl/binaries/b901d286-b88c-4d90-abf1-1d48e61813b0_tcm14-154310.jpg", "Ingang naar de schepenzaal." });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ImageUrl", "Text" },
                values: new object[] { "https://www.visitflanders.com/nl/binaries/b901d286-b88c-4d90-abf1-1d48e61813b0_tcm14-154310.jpg", "Entrance to the aldermen's room." });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ImageUrl", "Text" },
                values: new object[] { "https://www.visitflanders.com/nl/binaries/b901d286-b88c-4d90-abf1-1d48e61813b0_tcm14-154310.jpg", "Eingang zum Schöffensaal." });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ImageUrl", "Text" },
                values: new object[] { "https://www.visitflanders.com/nl/binaries/b901d286-b88c-4d90-abf1-1d48e61813b0_tcm14-154310.jpg", "Entrada a la sala del escabinado." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "ImageUrl", "Text" },
                values: new object[] { "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/9d6c51e780e044759631a07bd9dcbd322af40c753c0549c7a69a6158a0874eb5/browse.jpg", "Au Moyen-Âge, ce bâtiment abritait l’une des résidences des comtes de Flandre." });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "ImageUrl", "Text" },
                values: new object[] { "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/9d6c51e780e044759631a07bd9dcbd322af40c753c0549c7a69a6158a0874eb5/browse.jpg", "Ingang naar de schepenzaal" });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "ImageUrl", "Text" },
                values: new object[] { "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/9d6c51e780e044759631a07bd9dcbd322af40c753c0549c7a69a6158a0874eb5/browse.jpg", "During the middle ages, this was one of the residences of the Counts of Flanders." });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "ImageUrl", "Text" },
                values: new object[] { "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/9d6c51e780e044759631a07bd9dcbd322af40c753c0549c7a69a6158a0874eb5/browse.jpg", "Im Mittelalter befand sich hier eine der Residenzen der Grafen von Flandern." });

            migrationBuilder.UpdateData(
                table: "BuildingStory",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "ImageUrl", "Text" },
                values: new object[] { "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/012e71463a0b41a19df118bf2ff08e0499a665fb247d4c3e95e3e0968a96b0f3/browse.jpg", "En la época medieval, aquí se encontraba ubicada una de las residencias de los condes de Flandes." });
        }
    }
}
