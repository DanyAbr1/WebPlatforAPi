using Microsoft.EntityFrameworkCore;
using WebPlatformAPI.Angular.Models;

namespace WebPlatformAPI.Angular.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
    }
}
