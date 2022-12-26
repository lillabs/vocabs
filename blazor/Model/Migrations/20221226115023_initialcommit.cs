using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FOLDERS",
                columns: table => new
                {
                    FOLDER_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PARENT_FOLDER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOLDERS", x => x.FOLDER_ID);
                    table.ForeignKey(
                        name: "FK_FOLDERS_FOLDERS_PARENT_FOLDER_ID",
                        column: x => x.PARENT_FOLDER_ID,
                        principalTable: "FOLDERS",
                        principalColumn: "FOLDER_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WORDS_ST",
                columns: table => new
                {
                    WORD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VALUE = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LANGUAGE = table.Column<int>(type: "int", nullable: false),
                    WORD_TYPE = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORDS_ST", x => x.WORD_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "STUDY_SETS",
                columns: table => new
                {
                    STUDY_SET_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DIRECTORY_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDY_SETS", x => x.STUDY_SET_ID);
                    table.ForeignKey(
                        name: "FK_STUDY_SETS_FOLDERS_DIRECTORY_ID",
                        column: x => x.DIRECTORY_ID,
                        principalTable: "FOLDERS",
                        principalColumn: "FOLDER_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WORDPAIRS",
                columns: table => new
                {
                    WORDPAIR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    STUDY_SET_ID = table.Column<int>(type: "int", nullable: false),
                    KNOWN_WORD_ID = table.Column<int>(type: "int", nullable: false),
                    LEARNING_WORD_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORDPAIRS", x => x.WORDPAIR_ID);
                    table.ForeignKey(
                        name: "FK_WORDPAIRS_STUDY_SETS_STUDY_SET_ID",
                        column: x => x.STUDY_SET_ID,
                        principalTable: "STUDY_SETS",
                        principalColumn: "STUDY_SET_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WORDPAIRS_WORDS_ST_KNOWN_WORD_ID",
                        column: x => x.KNOWN_WORD_ID,
                        principalTable: "WORDS_ST",
                        principalColumn: "WORD_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WORDPAIRS_WORDS_ST_LEARNING_WORD_ID",
                        column: x => x.LEARNING_WORD_ID,
                        principalTable: "WORDS_ST",
                        principalColumn: "WORD_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FOLDERS_PARENT_FOLDER_ID",
                table: "FOLDERS",
                column: "PARENT_FOLDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_STUDY_SETS_DIRECTORY_ID",
                table: "STUDY_SETS",
                column: "DIRECTORY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WORDPAIRS_KNOWN_WORD_ID",
                table: "WORDPAIRS",
                column: "KNOWN_WORD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WORDPAIRS_LEARNING_WORD_ID",
                table: "WORDPAIRS",
                column: "LEARNING_WORD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_WORDPAIRS_STUDY_SET_ID",
                table: "WORDPAIRS",
                column: "STUDY_SET_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WORDPAIRS");

            migrationBuilder.DropTable(
                name: "STUDY_SETS");

            migrationBuilder.DropTable(
                name: "WORDS_ST");

            migrationBuilder.DropTable(
                name: "FOLDERS");
        }
    }
}
