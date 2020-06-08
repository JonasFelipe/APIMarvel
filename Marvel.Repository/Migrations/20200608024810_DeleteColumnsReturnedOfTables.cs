using Microsoft.EntityFrameworkCore.Migrations;

namespace Marvel.Repository.Migrations
{
    public partial class DeleteColumnsReturnedOfTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Returned",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "Returned",
                table: "Serie");

            migrationBuilder.DropColumn(
                name: "Returned",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Returned",
                table: "Comic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Returned",
                table: "Story",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Returned",
                table: "Serie",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Returned",
                table: "Event",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Returned",
                table: "Comic",
                type: "int",
                nullable: true);
        }
    }
}
