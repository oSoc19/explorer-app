using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class firstmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    nationality = table.Column<string>(nullable: true),
                    birthDate = table.Column<DateTime>(nullable: false),
                    deathDate = table.Column<DateTime>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Paintings",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    AuthorId = table.Column<long>(nullable: false),
                    imageUrl = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    place = table.Column<string>(nullable: true),
                    height = table.Column<float>(nullable: false),
                    width = table.Column<float>(nullable: false),
                    owner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paintings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Paintings_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    Paintingid = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                    table.ForeignKey(
                        name: "FK_Category_Paintings_Paintingid",
                        column: x => x.Paintingid,
                        principalTable: "Paintings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    Paintingid = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tag_Paintings_Paintingid",
                        column: x => x.Paintingid,
                        principalTable: "Paintings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_Paintingid",
                table: "Category",
                column: "Paintingid");

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_AuthorId",
                table: "Paintings",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_Paintingid",
                table: "Tag",
                column: "Paintingid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Paintings");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
