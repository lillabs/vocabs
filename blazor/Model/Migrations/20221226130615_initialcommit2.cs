using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class initialcommit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DESCRIPTION",
                table: "STUDY_SETS",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NAME",
                table: "STUDY_SETS",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DESCRIPTION",
                table: "FOLDERS",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NAME",
                table: "FOLDERS",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DESCRIPTION",
                table: "STUDY_SETS");

            migrationBuilder.DropColumn(
                name: "NAME",
                table: "STUDY_SETS");

            migrationBuilder.DropColumn(
                name: "DESCRIPTION",
                table: "FOLDERS");

            migrationBuilder.DropColumn(
                name: "NAME",
                table: "FOLDERS");
        }
    }
}
