using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class initialcommit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FOLDERS_FOLDERS_PARENT_FOLDER_ID",
                table: "FOLDERS");

            migrationBuilder.AlterColumn<int>(
                name: "PARENT_FOLDER_ID",
                table: "FOLDERS",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FOLDERS_FOLDERS_PARENT_FOLDER_ID",
                table: "FOLDERS",
                column: "PARENT_FOLDER_ID",
                principalTable: "FOLDERS",
                principalColumn: "FOLDER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FOLDERS_FOLDERS_PARENT_FOLDER_ID",
                table: "FOLDERS");

            migrationBuilder.AlterColumn<int>(
                name: "PARENT_FOLDER_ID",
                table: "FOLDERS",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FOLDERS_FOLDERS_PARENT_FOLDER_ID",
                table: "FOLDERS",
                column: "PARENT_FOLDER_ID",
                principalTable: "FOLDERS",
                principalColumn: "FOLDER_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
