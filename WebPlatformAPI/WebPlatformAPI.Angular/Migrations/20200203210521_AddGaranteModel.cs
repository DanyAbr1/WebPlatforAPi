using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformAPI.Angular.Migrations
{
    public partial class AddGaranteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Garantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGarante = table.Column<string>(maxLength: 50, nullable: true),
                    Nombre1 = table.Column<string>(maxLength: 50, nullable: false),
                    Nombre2 = table.Column<string>(maxLength: 50, nullable: true),
                    Apellido1 = table.Column<string>(maxLength: 50, nullable: false),
                    Apellido2 = table.Column<string>(maxLength: 50, nullable: true),
                    Cedula = table.Column<string>(maxLength: 15, nullable: false),
                    Pasaporte = table.Column<string>(maxLength: 50, nullable: true),
                    Sexo = table.Column<string>(maxLength: 1, nullable: false),
                    Telefono1 = table.Column<string>(maxLength: 50, nullable: false),
                    Telefono2 = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    NombreEmpresa = table.Column<string>(maxLength: 50, nullable: false),
                    DireccionLaboral = table.Column<string>(maxLength: 150, nullable: false),
                    TelefonoLaboral = table.Column<string>(maxLength: 15, nullable: false),
                    Sueldo = table.Column<double>(maxLength: 20, nullable: false),
                    Puesto = table.Column<string>(maxLength: 100, nullable: false),
                    JefeInmediato = table.Column<string>(maxLength: 100, nullable: false),
                    TiempoLaborando = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garantes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garantes");
        }
    }
}
