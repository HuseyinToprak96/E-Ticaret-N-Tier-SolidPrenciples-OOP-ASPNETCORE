using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class addmigrationinitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    UyeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UyeAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.UyeId);
                });

            migrationBuilder.CreateTable(
                name: "AltKategori",
                columns: table => new
                {
                    AltKategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltKategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltKategori", x => x.AltKategoriId);
                    table.ForeignKey(
                        name: "FK_AltKategori_Kategori_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategori",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fatura",
                columns: table => new
                {
                    FaturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeId = table.Column<int>(type: "int", nullable: false),
                    FaturaTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatura", x => x.FaturaId);
                    table.ForeignKey(
                        name: "FK_Fatura_Uyeler_UyeId",
                        column: x => x.UyeId,
                        principalTable: "Uyeler",
                        principalColumn: "UyeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    SepetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepet", x => x.SepetId);
                    table.ForeignKey(
                        name: "FK_Sepet_Uyeler_UyeId",
                        column: x => x.UyeId,
                        principalTable: "Uyeler",
                        principalColumn: "UyeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltKategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunId);
                    table.ForeignKey(
                        name: "FK_Urunler_AltKategori_AltKategoriId",
                        column: x => x.AltKategoriId,
                        principalTable: "AltKategori",
                        principalColumn: "AltKategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaturaDetay",
                columns: table => new
                {
                    FaturaDetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    FaturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaDetay", x => x.FaturaDetayId);
                    table.ForeignKey(
                        name: "FK_FaturaDetay_Fatura_FaturaId",
                        column: x => x.FaturaId,
                        principalTable: "Fatura",
                        principalColumn: "FaturaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FaturaDetay_Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunler",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SepetDetay",
                columns: table => new
                {
                    SepetDetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    SepetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SepetDetay", x => x.SepetDetayId);
                    table.ForeignKey(
                        name: "FK_SepetDetay_Sepet_SepetId",
                        column: x => x.SepetId,
                        principalTable: "Sepet",
                        principalColumn: "SepetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SepetDetay_Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunler",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AltKategori_KategoriId",
                table: "AltKategori",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_UyeId",
                table: "Fatura",
                column: "UyeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FaturaDetay_FaturaId",
                table: "FaturaDetay",
                column: "FaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaDetay_UrunId",
                table: "FaturaDetay",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Sepet_UyeId",
                table: "Sepet",
                column: "UyeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SepetDetay_SepetId",
                table: "SepetDetay",
                column: "SepetId");

            migrationBuilder.CreateIndex(
                name: "IX_SepetDetay_UrunId",
                table: "SepetDetay",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_AltKategoriId",
                table: "Urunler",
                column: "AltKategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FaturaDetay");

            migrationBuilder.DropTable(
                name: "SepetDetay");

            migrationBuilder.DropTable(
                name: "Fatura");

            migrationBuilder.DropTable(
                name: "Sepet");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Uyeler");

            migrationBuilder.DropTable(
                name: "AltKategori");

            migrationBuilder.DropTable(
                name: "Kategori");
        }
    }
}
