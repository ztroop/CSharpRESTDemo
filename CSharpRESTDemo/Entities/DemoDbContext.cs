using Microsoft.EntityFrameworkCore;

namespace CSharpRESTDemo.Entities
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}