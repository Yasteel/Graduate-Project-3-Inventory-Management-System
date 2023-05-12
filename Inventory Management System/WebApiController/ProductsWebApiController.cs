

namespace Inventory_Management_System.WebApiController
{
    using DevExtreme.AspNet.Data;
    using DevExtreme.AspNet.Mvc;
    using FluentValidation;
    using FluentValidation.AspNetCore;
    using Inventory_Management_System.Interfaces;
    using Inventory_Management_System.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Newtonsoft.Json;

    [Route("api/[controller]")]
    public class ProductsWebApiController : Controller
    {
        private readonly IProductService productService;
        private readonly IValidator<Products> validator;

        public ProductsWebApiController
        (
            IProductService productService, 
            IValidator<Products> validator    
        )
        {
            this.productService = productService;
            this.validator = validator;
        }

        [HttpGet("/Get")]

        public Object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(this.productService.GetAll(), loadOptions);
        }

        [HttpPost]
        public async Task<IActionResult> Create(string values)
        {
            var model = new Products();

            JsonConvert.PopulateObject(values, model);

            var result = this.validator.Validate(model, _ => _.IncludeRuleSets("Create"));

            if(!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return this.BadRequest(this.ModelState);

			}
            this.productService.Create(model);

			return this.Ok();

        }

        [HttpPost]
        public async Task<IActionResult> Update(int key, string values)
        {
            var model = this.productService.Get(key);

            JsonConvert.PopulateObject(values, model);

            var result = this.validator.Validate(model, _ => _.IncludeRuleSets("Update"));

            if(!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return this.BadRequest(this.ModelState);

            }

            this.productService.Update(model);
            return this.Ok();
        }

        public async Task<IActionResult> Delete(int key)
        {
            this.productService.Delete(key);
            return this.Ok();
        }
    }
}
