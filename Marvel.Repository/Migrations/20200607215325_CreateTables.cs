using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marvel.Repository.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    Modified = table.Column<DateTime>(maxLength: 100, nullable: false),
                    ResourceURI = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Available = table.Column<int>(nullable: true),
                    Returned = table.Column<int>(nullable: true),
                    CollectionURI = table.Column<string>(maxLength: 200, nullable: true),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comic_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Available = table.Column<int>(nullable: true),
                    Returned = table.Column<int>(nullable: true),
                    CollectionURI = table.Column<string>(maxLength: 200, nullable: true),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(maxLength: 400, nullable: true),
                    Extension = table.Column<string>(maxLength: 400, nullable: true),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Available = table.Column<int>(nullable: true),
                    Returned = table.Column<int>(nullable: true),
                    CollectionURI = table.Column<string>(maxLength: 200, nullable: true),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Serie_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Story",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Available = table.Column<int>(nullable: true),
                    Returned = table.Column<int>(nullable: true),
                    CollectionURI = table.Column<string>(maxLength: 200, nullable: true),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Story_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Url",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(maxLength: 200, nullable: true),
                    Url = table.Column<string>(maxLength: 200, nullable: true),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Url", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Url_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComicSummary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceURI = table.Column<string>(maxLength: 600, nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    ComicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicSummary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComicSummary_Comic_ComicId",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventSummary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceURI = table.Column<string>(maxLength: 600, nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventSummary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventSummary_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerieSummary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceURI = table.Column<string>(maxLength: 600, nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    SerieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieSummary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SerieSummary_Serie_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorySummary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceURI = table.Column<string>(maxLength: 600, nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    Type = table.Column<string>(maxLength: 600, nullable: true),
                    StoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorySummary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorySummary_Story_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Story",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comic_CharacterId",
                table: "Comic",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComicSummary_ComicId",
                table: "ComicSummary",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_CharacterId",
                table: "Event",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventSummary_EventId",
                table: "EventSummary",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_CharacterId",
                table: "Image",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Serie_CharacterId",
                table: "Serie",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SerieSummary_SerieId",
                table: "SerieSummary",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Story_CharacterId",
                table: "Story",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StorySummary_StoryId",
                table: "StorySummary",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Url_CharacterId",
                table: "Url",
                column: "CharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComicSummary");

            migrationBuilder.DropTable(
                name: "EventSummary");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "SerieSummary");

            migrationBuilder.DropTable(
                name: "StorySummary");

            migrationBuilder.DropTable(
                name: "Url");

            migrationBuilder.DropTable(
                name: "Comic");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Serie");

            migrationBuilder.DropTable(
                name: "Story");

            migrationBuilder.DropTable(
                name: "Character");
        }
    }
}
