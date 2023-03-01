using Microsoft.EntityFrameworkCore;

namespace EE5209_3592_Assignment.Models
{
    public class AquaContext : DbContext
    {
        public AquaContext(DbContextOptions<AquaContext> options) : base(options)
        {

        }
    public DbSet<Category_Type> Category_Types { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }
    }

}
