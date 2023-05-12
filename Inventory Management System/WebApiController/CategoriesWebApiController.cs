using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Inventory_Management_System.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Management_System.WebApiController
{
    public class CategoriesWebApiController : Controller
    {
        private readonly ICacheService cache;

        public CategoriesWebApiController(ICacheService cache)
        {
            this.cache = cache;
        }

        [HttpGet]
        public Object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(this.cache.GetCategories(), loadOptions);
        }
    }
}
