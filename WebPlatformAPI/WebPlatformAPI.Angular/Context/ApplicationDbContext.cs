using Microsoft.EntityFrameworkCore;
using WebPlatformAPI.Common.Entities;

namespace WebPlatformAPI.Angular.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Cliente> clientes { get; set; }
    }
}
