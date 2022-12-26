using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class initialcommit5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDY_SETS_FOLDERS_DIRECTORY_ID",
                table: "STUDY_SETS");

            migrationBuilder.AlterColumn<int>(
                name: "DIRECTORY_ID",
                table: "STUDY_SETS",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPTION",
                table: "STUDY_SETS",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPTION",
                table: "FOLDERS",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDY_SETS_FOLDERS_DIRECTORY_ID",
                table: "STUDY_SETS",
                column: "DIRECTORY_ID",
                principalTable: "FOLDERS",
                principalColumn: "FOLDER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDY_SETS_FOLDERS_DIRECTORY_ID",
                table: "STUDY_SETS");

            migrationBuilder.AlterColumn<int>(
                name: "DIRECTORY_ID",
                table: "STUDY_SETS",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "STUDY_SETS",
                keyColumn: "DESCRIPTION",
                keyValue: null,
                column: "DESCRIPTION",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPTION",
                table: "STUDY_SETS",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FOLDERS",
                keyColumn: "DESCRIPTION",
                keyValue: null,
                column: "DESCRIPTION",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPTION",
                table: "FOLDERS",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDY_SETS_FOLDERS_DIRECTORY_ID",
                table: "STUDY_SETS",
                column: "DIRECTORY_ID",
                principalTable: "FOLDERS",
                principalColumn: "FOLDER_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
