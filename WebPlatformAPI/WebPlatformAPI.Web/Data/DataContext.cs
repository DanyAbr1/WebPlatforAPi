
namespace WebPlatformAPI.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using WebPlatformAPI.Web.Data.Entities;

    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)  {}
        public DbSet<Customer> Customers { get; set; }  
    }
}
