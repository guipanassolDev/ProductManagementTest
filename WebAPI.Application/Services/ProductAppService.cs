using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Exceptions;
using WebAPI.Application.InputModels.Common;
using WebAPI.Application.InputModels.Product;
using WebAPI.Application.ViewModels.Product;
using WebAPI.Core.DTOs.Product;
using WebAPI.Core.Services;


namespace WebAPI.Application.Services
{
    public class ProductAppService : BaseAppService
    {
        private ProductService _productService => GetRequiredService<ProductService>();

        public ProductAppService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task CreateProduct(ProductInputModel productCreateInputModel)
        {
            if (productCreateInputModel.FabricationDate >= productCreateInputModel.ValidationDate)
            {
                throw new InvalidFabricationDateException();
            }

            var productCreateDto = Map<ProductDto>(productCreateInputModel);
            await _productService.CreateProduct(productCreateDto);
        }

        public async Task<IEnumerable<ProductsListViewModel>> GetProducts()
        {
            var productsDto = await _productService.GetProducts();
            return Map<IEnumerable<ProductsListViewModel>>(productsDto);
        }

        public async Task<IEnumerable<ProductsListViewModel>> SearchProducts(SearchPaginationInputModel pagination)
        {
            var productsListDto = await _productService.SearchProducts(pagination.Skip, pagination.Take, pagination.SearchTerms);
            return Map<IEnumerable<ProductsListViewModel>>(productsListDto);
        }

        public async Task UpdateProduct(int code, ProductInputModel productCreateInputModel)
        {
           var productDto = Map<ProductDto>(productCreateInputModel);
           await _productService.UpdateProduct(code, productDto);
        }

        public async Task SetProductActive(int code, bool isActive)
        {
            await _productService.SetProductActive(code, isActive);
        }  
        
        public async Task SetProductInactive(int code, bool isActive)
        {
            await _productService.SetProductInactive(code, isActive);
        }
    }
}
