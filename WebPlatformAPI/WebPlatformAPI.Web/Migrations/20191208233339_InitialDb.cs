using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPlatformAPI.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Idinternal = table.Column<string>(nullable: true),
                    Document = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: true),
                    LastName = table.Column<string>(maxLength: 60, nullable: true),
                    Telephone = table.Column<string>(maxLength: 1, nullable: true),
                    Telephone1 = table.Column<string>(maxLength: 1, nullable: true),
                    Telephone2 = table.Column<string>(maxLength: 1, nullable: true),
                    Telephone3 = table.Column<string>(maxLength: 1, nullable: true),
                    Gender = table.Column<string>(maxLength: 1, nullable: true),
                    Addres = table.Column<string>(maxLength: 20, nullable: true),
                    BirthDate = table.Column<string>(maxLength: 10, nullable: true),
                    CivilStatus = table.Column<string>(maxLength: 20, nullable: true),
                    Company = table.Column<string>(maxLength: 100, nullable: true),
                    Job = table.Column<string>(maxLength: 60, nullable: true),
                    RNC = table.Column<string>(maxLength: 20, nullable: true),
                    Passport = table.Column<string>(maxLength: 20, nullable: true),
                    Nationality = table.Column<string>(maxLength: 60, nullable: true),
                    CreditLimit = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
