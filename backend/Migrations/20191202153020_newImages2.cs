using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class newImages2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/ad04cf876f154b339a72fbae1d4e3afdc80b2c2582fc42ac9338e7e7d67398db/browse.jpg");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ImageUrl",
                value: "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3e9cda9a68b34f5eb9ef3efaf8ab8cf85ee8a754f5eb409aa67275b49956a63f/browse.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ImageUrl",
                value: "http://groeningemuseum.be/collection/work/representation/0000_GRO0184_I");

            migrationBuilder.UpdateData(
                table: "Painting",
                keyColumn: "Id",
                keyValue: 7L,
                column: "ImageUrl",
                value: "http://groeningemuseum.be/collection/work/representation/1991_GRO0007_I");
        }
    }
}
