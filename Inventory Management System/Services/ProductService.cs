namespace Inventory_Management_System.Services
{
    using Inventory_Management_System.Data;
    using Inventory_Management_System.Interfaces;
    using Inventory_Management_System.Models;

    public class ProductService : GenericService<Products>, IProductService
    {
        public ProductService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
