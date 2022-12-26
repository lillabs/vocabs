using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class initialcommit6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDY_SETS_FOLDERS_DIRECTORY_ID",
                table: "STUDY_SETS");

            migrationBuilder.RenameColumn(
                name: "DIRECTORY_ID",
                table: "STUDY_SETS",
                newName: "FOLDER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_STUDY_SETS_DIRECTORY_ID",
                table: "STUDY_SETS",
                newName: "IX_STUDY_SETS_FOLDER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDY_SETS_FOLDERS_FOLDER_ID",
                table: "STUDY_SETS",
                column: "FOLDER_ID",
                principalTable: "FOLDERS",
                principalColumn: "FOLDER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDY_SETS_FOLDERS_FOLDER_ID",
                table: "STUDY_SETS");

            migrationBuilder.RenameColumn(
                name: "FOLDER_ID",
                table: "STUDY_SETS",
                newName: "DIRECTORY_ID");

            migrationBuilder.RenameIndex(
                name: "IX_STUDY_SETS_FOLDER_ID",
                table: "STUDY_SETS",
                newName: "IX_STUDY_SETS_DIRECTORY_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDY_SETS_FOLDERS_DIRECTORY_ID",
                table: "STUDY_SETS",
                column: "DIRECTORY_ID",
                principalTable: "FOLDERS",
                principalColumn: "FOLDER_ID");
        }
    }
}
