using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class initialcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "E_LANGUAGES",
                columns: table => new
                {
                    VALUE = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E_LANGUAGES", x => x.VALUE);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FOLDERS",
                columns: table => new
                {
                    FOLDERID = table.Column<int>(name: "FOLDER_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CREATEDAT = table.Column<DateTime>(name: "CREATED_AT", type: "datetime(6)", nullable: false),
                    PARENTFOLDERID = table.Column<int>(name: "PARENT_FOLDER_ID", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOLDERS", x => x.FOLDERID);
                    table.ForeignKey(
                        name: "FK_FOLDERS_FOLDERS_PARENT_FOLDER_ID",
                        column: x => x.PARENTFOLDERID,
                        principalTable: "FOLDERS",
                        principalColumn: "FOLDER_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ROLES",
                columns: table => new
                {
                    ROLEID = table.Column<int>(name: "ROLE_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDENTIFIER = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLES", x => x.ROLEID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    USERID = table.Column<int>(name: "USER_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    USERNAME = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMAIL = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PASSWORDHASH = table.Column<string>(name: "PASSWORD_HASH", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.USERID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WORDS_ST",
                columns: table => new
                {
                    WORDID = table.Column<int>(name: "WORD_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VALUE = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LANGUAGEID = table.Column<string>(name: "LANGUAGE_ID", type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WORDTYPE = table.Column<string>(name: "WORD_TYPE", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORDS_ST", x => x.WORDID);
                    table.ForeignKey(
                        name: "FK_WORDS_ST_E_LANGUAGES_LANGUAGE_ID",
                        column: x => x.LANGUAGEID,
                        principalTable: "E_LANGUAGES",
                        principalColumn: "VALUE",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "STUDY_SETS",
                columns: table => new
                {
                    STUDYSETID = table.Column<int>(name: "STUDY_SET_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CREATEDAT = table.Column<DateTime>(name: "CREATED_AT", type: "datetime(6)", nullable: false),
                    FOLDERID = table.Column<int>(name: "FOLDER_ID", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDY_SETS", x => x.STUDYSETID);
                    table.ForeignKey(
                        name: "FK_STUDY_SETS_FOLDERS_FOLDER_ID",
                        column: x => x.FOLDERID,
                        principalTable: "FOLDERS",
                        principalColumn: "FOLDER_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USER_HAS_ROLES_JT",
                columns: table => new
                {
                    USERID = table.Column<int>(name: "USER_ID", type: "int", nullable: false),
                    ROLEID = table.Column<int>(name: "ROLE_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_HAS_ROLES_JT", x => new { x.USERID, x.ROLEID });
                    table.ForeignKey(
                        name: "FK_USER_HAS_ROLES_JT_ROLES_ROLE_ID",
                        column: x => x.ROLEID,
                        principalTable: "ROLES",
                        principalColumn: "ROLE_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_HAS_ROLES_JT_USERS_USER_ID",
                        column: x => x.USERID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WORDPAIRS",
                columns: table => new
                {
                    WORDPAIRID = table.Column<int>(name: "WORDPAIR_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    STUDYSETID = table.Column<int>(name: "STUDY_SET_ID", type: "int", nullable: false),
                    KNOWNWORDID = table.Column<int>(name: "KNOWN_WORD_ID", type: "int", nullable: false),
                    LEARNINGWORDID = table.Column<int>(name: "LEARNING_WORD_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORDPAIRS", x => x.WORDPAIRID);
                    table.ForeignKey(
                        name: "FK_WORDPAIRS_STUDY_SETS_STUDY_SET_ID",
                        column: x => x.STUDYSETID,
                        principalTable: "STUDY_SETS",
                        principalColumn: "STUDY_SET_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WORDPAIRS_WORDS_ST_KNOWN_WORD_ID",
                        column: x => x.KNOWNWORDID,
                        principalTable: "WORDS_ST",
                        principalColumn: "WORD_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WORDPAIRS_WORDS_ST_LEARNING_WORD_ID",
                        column: x => x.LEARNINGWORDID,
                        principalTable: "WORDS_ST",
                        principalColumn: "WORD_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ROLES",
                columns: new[] { "ROLE_ID", "DESCRIPTION", "IDENTIFIER" },
                values: new object[] { 1, "Administrator", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_FOLDERS_PARENT_FOLDER_ID",
                table: "FOLDERS",
                column: "PARENT_FOLDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ROLES_IDENTIFIER",
                table: "ROLES",
                column: "IDENTIFIER",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_STUDY_SETS_FOLDER_ID",
                table: "STUDY_SETS",
                column: "FOLDER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_HAS_ROLES_JT_ROLE_ID",
                table: "USER_HAS_ROLES_JT",
                column: "ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_EMAIL",
                table: "USERS",
                column: "EMAIL",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_WORDS_ST_LANGUAGE_ID",
                table: "WORDS_ST",
                column: "LANGUAGE_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USER_HAS_ROLES_JT");

            migrationBuilder.DropTable(
                name: "WORDPAIRS");

            migrationBuilder.DropTable(
                name: "ROLES");

            migrationBuilder.DropTable(
                name: "USERS");

            migrationBuilder.DropTable(
                name: "STUDY_SETS");

            migrationBuilder.DropTable(
                name: "WORDS_ST");

            migrationBuilder.DropTable(
                name: "FOLDERS");

            migrationBuilder.DropTable(
                name: "E_LANGUAGES");
        }
    }
}
