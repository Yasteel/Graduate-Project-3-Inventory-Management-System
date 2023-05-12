namespace Inventory_Management_System.Services
{
    using Inventory_Management_System.Data;
    using Inventory_Management_System.Interfaces;
    using Inventory_Management_System.Models;

    public class CategoriesService : GenericService<Categories>, ICategoriesService
    {
        public CategoriesService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
