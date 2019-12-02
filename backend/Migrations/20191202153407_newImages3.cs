using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class newImages3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/48736d8d6adb4ef7a88aefc14a231e47550087be043845c18f27e4d731c25151/browse.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3e9cda9a68b34f5eb9ef3efaf8ab8cf85ee8a754f5eb409aa67275b49956a63f/browse.jpg");
        }
    }
}
