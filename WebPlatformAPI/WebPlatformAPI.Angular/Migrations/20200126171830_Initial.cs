using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformAPI.Angular.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idcliente = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Nombre2 = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Apellido2 = table.Column<string>(nullable: true),
                    Cedula = table.Column<string>(nullable: true),
                    Pasaporte = table.Column<string>(nullable: true),
                    RNC = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Telefon2 = table.Column<string>(nullable: true),
                    Telefono3 = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Pais = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true),
                    Municipio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
