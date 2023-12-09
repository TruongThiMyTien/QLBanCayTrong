using Microsoft.EntityFrameworkCore.Migrations;

namespace BanCayTrong.Data.Migrations
{
    public partial class themtruong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "daxoa",
                table: "KhachHang",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "daxoa",
                table: "KhachHang");
        }
    }
}
