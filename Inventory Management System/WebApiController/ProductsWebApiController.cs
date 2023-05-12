

namespace Inventory_Management_System.WebApiController
{
    using DevExtreme.AspNet.Data;
    using DevExtreme.AspNet.Mvc;
    using Inventory_Management_System.Interfaces;
    using Inventory_Management_System.Models;
    using Microsoft.AspNetCore.Mvc;

    public class ProductsWebApiController : Controller
    {
        private readonly IProductService productService;

        public ProductsWebApiController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public Object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(this.productService.GetAll(), loadOptions);
        }
    }
}
