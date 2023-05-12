using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Inventory_Management_System.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Management_System.WebApiController
{
    public class CategoriesWebApiController : Controller
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesWebApiController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        [HttpGet]
        public Object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(this.categoriesService.GetAll(), loadOptions);
        }
    }
}
