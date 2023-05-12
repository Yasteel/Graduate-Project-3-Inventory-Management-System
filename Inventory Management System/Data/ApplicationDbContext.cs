namespace Inventory_Management_System.Data
{
    using Inventory_Management_System.Models;

    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<Products> Products { get; set; }
        
        DbSet<Categories> Categories { get; set; }
    }
}
