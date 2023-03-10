using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.InputModels.Common;
using WebAPI.Application.InputModels.Product;
using WebAPI.Application.Services;
using WebAPI.Application.ViewModels.Product;
using WebAPI.Controllers;

namespace ProductManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : DefaultController
    {
        [HttpPost]
        public async Task CreateProduct([FromBody] ProductInputModel productCreateInputModel, [FromServices] ProductAppService _productAppService)
        {
            await _productAppService.CreateProduct(productCreateInputModel);
        }

        [HttpGet]
        public async Task<IEnumerable<ProductsListViewModel>> GetProducts([FromServices] ProductAppService _productAppService)
        {
            return await _productAppService.GetProducts();
        }

        [HttpPost("search")]
        public async Task<IEnumerable<ProductsListViewModel>> SearchProducts([FromServices] ProductAppService _productAppService, [FromBody] SearchPaginationInputModel pagination)
        {
            return await _productAppService.SearchProducts(pagination);
        }

        [HttpPatch("{code}")]
        public async Task UpdateProduct([FromRoute] int code, [FromBody] ProductInputModel productCreateInputModel, [FromServices] ProductAppService _productAppService)
        {
            await _productAppService.UpdateProduct(code, productCreateInputModel);
        }

        [HttpPatch("{code}/isActive/{isActive}")]
        public async Task SetProductActive([FromRoute] int code, [FromBody] bool isActive, [FromServices] ProductAppService _productAppService)
        {
            await _productAppService.SetProductActive(code, isActive);
        }

        [HttpPatch("{code}/inactive/{isActive}")]
        public async Task SetProductInactive([FromRoute] int code, [FromBody] bool isActive, [FromServices] ProductAppService _productAppService)
        {
            await _productAppService.SetProductInactive(code, isActive);
        }
    }
}