using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class initialmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Deathdate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movement",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technique",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technique", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArtistTranslation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArtistId = table.Column<long>(nullable: false),
                    LanguageId = table.Column<long>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistTranslation_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistTranslation_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Painting",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AuthorId = table.Column<long>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Height = table.Column<float>(nullable: false),
                    Width = table.Column<float>(nullable: false),
                    MovementId = table.Column<long>(nullable: false),
                    TechniqueId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Painting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Painting_Artist_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Painting_Movement_MovementId",
                        column: x => x.MovementId,
                        principalTable: "Movement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Painting_Technique_TechniqueId",
                        column: x => x.TechniqueId,
                        principalTable: "Technique",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaintingAudio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AudioUrl = table.Column<string>(nullable: true),
                    LanguageId = table.Column<long>(nullable: false),
                    PaintingId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaintingAudio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaintingAudio_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaintingAudio_Painting_PaintingId",
                        column: x => x.PaintingId,
                        principalTable: "Painting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaintingStory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    LanguageId = table.Column<long>(nullable: false),
                    PaintingId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaintingStory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaintingStory_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaintingStory_Painting_PaintingId",
                        column: x => x.PaintingId,
                        principalTable: "Painting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaintingTranslation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PaintingId = table.Column<long>(nullable: false),
                    LanguageId = table.Column<long>(nullable: false),
                    FieldTranslated = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaintingTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaintingTranslation_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaintingTranslation_Painting_PaintingId",
                        column: x => x.PaintingId,
                        principalTable: "Painting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistTranslation_ArtistId",
                table: "ArtistTranslation",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistTranslation_LanguageId",
                table: "ArtistTranslation",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Painting_AuthorId",
                table: "Painting",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Painting_MovementId",
                table: "Painting",
                column: "MovementId");

            migrationBuilder.CreateIndex(
                name: "IX_Painting_TechniqueId",
                table: "Painting",
                column: "TechniqueId");

            migrationBuilder.CreateIndex(
                name: "IX_PaintingAudio_LanguageId",
                table: "PaintingAudio",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PaintingAudio_PaintingId",
                table: "PaintingAudio",
                column: "PaintingId");

            migrationBuilder.CreateIndex(
                name: "IX_PaintingStory_LanguageId",
                table: "PaintingStory",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PaintingStory_PaintingId",
                table: "PaintingStory",
                column: "PaintingId");

            migrationBuilder.CreateIndex(
                name: "IX_PaintingTranslation_LanguageId",
                table: "PaintingTranslation",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PaintingTranslation_PaintingId",
                table: "PaintingTranslation",
                column: "PaintingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistTranslation");

            migrationBuilder.DropTable(
                name: "PaintingAudio");

            migrationBuilder.DropTable(
                name: "PaintingStory");

            migrationBuilder.DropTable(
                name: "PaintingTranslation");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Painting");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Movement");

            migrationBuilder.DropTable(
                name: "Technique");
        }
    }
}
