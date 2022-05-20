using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DosyaYolu",
                table: "Siparisler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DosyaYolu",
                table: "SiparisDetaylar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DosyaYolu",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DosyaYolu",
                table: "Galeriler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DosyaYolu",
                table: "Arabalar",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DosyaYolu",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "DosyaYolu",
                table: "SiparisDetaylar");

            migrationBuilder.DropColumn(
                name: "DosyaYolu",
                table: "Musteriler");

            migrationBuilder.DropColumn(
                name: "DosyaYolu",
                table: "Galeriler");

            migrationBuilder.DropColumn(
                name: "DosyaYolu",
                table: "Arabalar");
        }
    }
}
