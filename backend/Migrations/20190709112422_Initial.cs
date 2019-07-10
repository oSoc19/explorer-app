using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movement",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movement", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Technique",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technique", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    nationality = table.Column<string>(nullable: true),
                    birthDate = table.Column<DateTime>(nullable: false),
                    deathDate = table.Column<DateTime>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    Movementid = table.Column<long>(nullable: true),
                    Techniqueid = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.id);
                    table.ForeignKey(
                        name: "FK_Artists_Movement_Movementid",
                        column: x => x.Movementid,
                        principalTable: "Movement",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artists_Technique_Techniqueid",
                        column: x => x.Techniqueid,
                        principalTable: "Technique",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paintings",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    authorId = table.Column<long>(nullable: false),
                    imageUrl = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    height = table.Column<float>(nullable: false),
                    width = table.Column<float>(nullable: false),
                    movementId = table.Column<long>(nullable: false),
                    techniqueId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paintings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Paintings_Artists_authorId",
                        column: x => x.authorId,
                        principalTable: "Artists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paintings_Movement_movementId",
                        column: x => x.movementId,
                        principalTable: "Movement",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paintings_Technique_techniqueId",
                        column: x => x.techniqueId,
                        principalTable: "Technique",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_Movementid",
                table: "Artists",
                column: "Movementid");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_Techniqueid",
                table: "Artists",
                column: "Techniqueid");

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_authorId",
                table: "Paintings",
                column: "authorId");

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_movementId",
                table: "Paintings",
                column: "movementId");

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_techniqueId",
                table: "Paintings",
                column: "techniqueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paintings");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Movement");

            migrationBuilder.DropTable(
                name: "Technique");
        }
    }
}
