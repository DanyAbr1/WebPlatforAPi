using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformAPI.Angular.Migrations
{
    public partial class ModifingEmpresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdEmpresa",
                table: "Empresas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Empresas");
        }
    }
}
