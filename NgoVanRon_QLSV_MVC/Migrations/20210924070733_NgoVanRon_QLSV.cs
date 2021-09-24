using Microsoft.EntityFrameworkCore.Migrations;

namespace NgoVanRon_QLSV_MVC.Migrations
{
    public partial class NgoVanRon_QLSV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ngovanron_lop",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ngovanron_lop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ngovanron_sinhvien",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSinhVien = table.Column<string>(nullable: false),
                    DiaChi = table.Column<string>(nullable: false),
                    IdLop = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ngovanron_sinhvien", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ngovanron_lop");

            migrationBuilder.DropTable(
                name: "ngovanron_sinhvien");
        }
    }
}
