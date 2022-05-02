using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galeriler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(name: "Created Date", type: "datetime2", nullable: true),
                    CreatedComputerName = table.Column<string>(name: "Created Computer Name", type: "nvarchar(max)", nullable: true),
                    CreatedIP = table.Column<string>(name: "Created IP", type: "nvarchar(max)", nullable: true),
                    CreatedADUsername = table.Column<string>(name: "Created AD Username", type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(name: "Created By", type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "datetime2", nullable: true),
                    ModifiedComputerName = table.Column<string>(name: "Modified Computer Name", type: "nvarchar(max)", nullable: true),
                    ModifiedIP = table.Column<string>(name: "Modified IP", type: "nvarchar(max)", nullable: true),
                    ModifiedADUserName = table.Column<string>(name: "Modified AD User Name", type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<int>(name: "Modified By", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galeriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: true),
                    DogumGunu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(name: "Created Date", type: "datetime2", nullable: true),
                    CreatedComputerName = table.Column<string>(name: "Created Computer Name", type: "nvarchar(max)", nullable: true),
                    CreatedIP = table.Column<string>(name: "Created IP", type: "nvarchar(max)", nullable: true),
                    CreatedADUsername = table.Column<string>(name: "Created AD Username", type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(name: "Created By", type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "datetime2", nullable: true),
                    ModifiedComputerName = table.Column<string>(name: "Modified Computer Name", type: "nvarchar(max)", nullable: true),
                    ModifiedIP = table.Column<string>(name: "Modified IP", type: "nvarchar(max)", nullable: true),
                    ModifiedADUserName = table.Column<string>(name: "Modified AD User Name", type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<int>(name: "Modified By", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ucret = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Stok = table.Column<int>(type: "int", nullable: true),
                    Birim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GaleriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(name: "Created Date", type: "datetime2", nullable: true),
                    CreatedComputerName = table.Column<string>(name: "Created Computer Name", type: "nvarchar(max)", nullable: true),
                    CreatedIP = table.Column<string>(name: "Created IP", type: "nvarchar(max)", nullable: true),
                    CreatedADUsername = table.Column<string>(name: "Created AD Username", type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(name: "Created By", type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "datetime2", nullable: true),
                    ModifiedComputerName = table.Column<string>(name: "Modified Computer Name", type: "nvarchar(max)", nullable: true),
                    ModifiedIP = table.Column<string>(name: "Modified IP", type: "nvarchar(max)", nullable: true),
                    ModifiedADUserName = table.Column<string>(name: "Modified AD User Name", type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<int>(name: "Modified By", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arabalar_Galeriler_GaleriId",
                        column: x => x.GaleriId,
                        principalTable: "Galeriler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MusteriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OnaylandiMi = table.Column<bool>(type: "bit", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(name: "Created Date", type: "datetime2", nullable: true),
                    CreatedComputerName = table.Column<string>(name: "Created Computer Name", type: "nvarchar(max)", nullable: true),
                    CreatedIP = table.Column<string>(name: "Created IP", type: "nvarchar(max)", nullable: true),
                    CreatedADUsername = table.Column<string>(name: "Created AD Username", type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(name: "Created By", type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "datetime2", nullable: true),
                    ModifiedComputerName = table.Column<string>(name: "Modified Computer Name", type: "nvarchar(max)", nullable: true),
                    ModifiedIP = table.Column<string>(name: "Modified IP", type: "nvarchar(max)", nullable: true),
                    ModifiedADUserName = table.Column<string>(name: "Modified AD User Name", type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<int>(name: "Modified By", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siparisler_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SiparisDetaylar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Miktar = table.Column<int>(type: "int", nullable: true),
                    SiparisId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(name: "Created Date", type: "datetime2", nullable: true),
                    CreatedComputerName = table.Column<string>(name: "Created Computer Name", type: "nvarchar(max)", nullable: true),
                    CreatedIP = table.Column<string>(name: "Created IP", type: "nvarchar(max)", nullable: true),
                    CreatedADUsername = table.Column<string>(name: "Created AD Username", type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(name: "Created By", type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(name: "Modified Date", type: "datetime2", nullable: true),
                    ModifiedComputerName = table.Column<string>(name: "Modified Computer Name", type: "nvarchar(max)", nullable: true),
                    ModifiedIP = table.Column<string>(name: "Modified IP", type: "nvarchar(max)", nullable: true),
                    ModifiedADUserName = table.Column<string>(name: "Modified AD User Name", type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<int>(name: "Modified By", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisDetaylar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiparisDetaylar_Arabalar_ArabaId",
                        column: x => x.ArabaId,
                        principalTable: "Arabalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisDetaylar_Siparisler_SiparisId",
                        column: x => x.SiparisId,
                        principalTable: "Siparisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_GaleriId",
                table: "Arabalar",
                column: "GaleriId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetaylar_ArabaId",
                table: "SiparisDetaylar",
                column: "ArabaId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetaylar_SiparisId",
                table: "SiparisDetaylar",
                column: "SiparisId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_MusteriId",
                table: "Siparisler",
                column: "MusteriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiparisDetaylar");

            migrationBuilder.DropTable(
                name: "Arabalar");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "Galeriler");

            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
