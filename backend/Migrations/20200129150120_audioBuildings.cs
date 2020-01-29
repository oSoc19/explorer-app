using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class audioBuildings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingAudio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AudioUrl = table.Column<string>(nullable: true),
                    LanguageId = table.Column<long>(nullable: false),
                    BuildingId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingAudio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingAudio_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildingAudio_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BuildingAudio",
                columns: new[] { "Id", "AudioUrl", "BuildingId", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 1L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/240151bc61934d899e8e72bda7301beb98d571224db744a2bc967955d924fc17/browse.mp3", 1L, 1L, null },
                    { 2L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/8a8c5124faab430bad55be7e5499c26c1da0f4cb4592489ebd42ce3e43365176/browse.mp3", 1L, 2L, null },
                    { 3L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/8a186f7d78504408831f1fc8bb7f9f4ad10c61942b314397a9949435e0d86483/browse.mp3", 1L, 3L, null },
                    { 4L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/464617389c7d4cd59c77fb184d03158326c265aee38c433aa2117bae2d1a6ffb/browse.mp3", 1L, 4L, null },
                    { 5L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/58d13827e4d84a47bd03b40fdfbba012b52c7bec24594821b197c4b4cf8e7dbb/browse.mp3", 1L, 5L, null },
                    { 6L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/1dc5545666c54effbe4d03e8e081f32912763e9a8dbb4a6a8ba2c8bea043d345/browse.mp3", 4L, 1L, null },
                    { 7L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/732e132e789e4c7db2bfc2d54da6f4e03e7f2c00c727493d9e07971cb5ef8a0e/browse.mp3", 4L, 2L, null },
                    { 8L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3f16977087a24cc3a62f84ce7c65c88b95d23e9a573e4dfab303b9d1b0f113ee/browse.mp3", 4L, 3L, null },
                    { 9L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/fb161fc88d18470eb1e50244e3def1153becabebb66d48de9a8f01cd2fea5915/browse.mp3", 4L, 4L, null },
                    { 10L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/8f455c2eaf754c74ba19c373f990dabda7afb5649cc24b48a772262488051ddc/browse.mp3", 4L, 5L, null },
                    { 11L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/d39c65c14c20494ea4b84854b93f4ae967463ccffb374d57a9e086f1a0df63d9/browse.mp3", 2L, 1L, null },
                    { 12L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/3bdc151159c441529ce4c8ecbdd9208c45d160b87cc846a6bf0a0b7c8ca44f3e/browse.mp3", 2L, 2L, null },
                    { 13L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/5b5c2774cf754aa7b7e4cac2719fd7b338fc44b17a9248979220bd21d85a6ad0/browse.mp3", 2L, 3L, null },
                    { 14L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/29c25c7a38024c99b27d89ff5538c468c2617d20662c41f8ae300b995bd89cf6/browse.mp3", 2L, 4L, null },
                    { 15L, "https://mheuropehot.blob.core.windows.net/mediahaven-saas-browse-main/BRUGGE/c205edf23a2c4620a5d8bbb00019d92bc8ccb27732ee4eac96749e0938c41ee2/browse.mp3", 2L, 5L, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingAudio_BuildingId",
                table: "BuildingAudio",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingAudio_LanguageId",
                table: "BuildingAudio",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingAudio");
        }
    }
}
