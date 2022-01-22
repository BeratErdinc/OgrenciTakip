using Microsoft.EntityFrameworkCore.Migrations;

namespace SatışÖrnek.Migrations
{
    public partial class bitti32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ders",
                columns: table => new
                {
                    DersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdı = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ders", x => x.DersId);
                });

            migrationBuilder.CreateTable(
                name: "Kulup",
                columns: table => new
                {
                    KulupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KulupAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KulupKontejan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kulup", x => x.KulupId);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencıs",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrencıCınsıyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciKulup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KulupId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencıs", x => x.OgrenciId);
                    table.ForeignKey(
                        name: "FK_Ogrencıs_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "DersId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ogrencıs_Kulup_KulupId",
                        column: x => x.KulupId,
                        principalTable: "Kulup",
                        principalColumn: "KulupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notlar",
                columns: table => new
                {
                    NotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sınav1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sınav2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sınav3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ortalama = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notlar", x => x.NotId);
                    table.ForeignKey(
                        name: "FK_Notlar_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "DersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notlar_Ogrencıs_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrencıs",
                        principalColumn: "OgrenciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notlar_DersId",
                table: "Notlar",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_Notlar_OgrenciId",
                table: "Notlar",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencıs_DersId",
                table: "Ogrencıs",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencıs_KulupId",
                table: "Ogrencıs",
                column: "KulupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notlar");

            migrationBuilder.DropTable(
                name: "Ogrencıs");

            migrationBuilder.DropTable(
                name: "Ders");

            migrationBuilder.DropTable(
                name: "Kulup");
        }
    }
}
