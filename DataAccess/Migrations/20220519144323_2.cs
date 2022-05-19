using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResimYolu",
                table: "Musteriler");

            migrationBuilder.DropColumn(
                name: "ResimYolu",
                table: "Arabalar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResimYolu",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResimYolu",
                table: "Arabalar",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
