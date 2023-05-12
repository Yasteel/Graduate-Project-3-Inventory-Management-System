using Inventory_Management_System.Interfaces;
using Inventory_Management_System.Models;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace Inventory_Management_System.Services
{
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache cache;
        private readonly ICategoriesService categories;

        public CacheService
        (
            IMemoryCache cache,
            ICategoriesService categories
        )
        {
            this.cache = cache;
            this.categories = categories;
        }

        public List<Categories> GetCategories()
        {
            
            var cachedData = this.cache.Get<List<Categories>>("Categories");

            if ( cachedData is null ) 
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n===========================Got Catergories From Database===========================\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                cachedData = this.categories.GetAll();
                this.cache.Set("Categories", cachedData, TimeSpan.FromMinutes(10));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n===========================Got Catergories From Cache===========================\n\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return cachedData;
        }
    }
}
