using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using ProductManagement.MongoDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.DTOs.Product;
using WebAPI.Core.Exceptions.Product;

namespace WebAPI.Core.Services
{
    public class ProductService : BaseService
    {
        public ProductService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task CreateProduct(ProductDto productCreateDto)
        {
            if (productCreateDto == null)
            {
                throw new InvalidProductException();
            }

            var product = new Product
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Code = productCreateDto.Code,
                Description = productCreateDto.Description,
                FabricationDate = productCreateDto.FabricationDate,
                ValidationDate = productCreateDto.ValidationDate,
                IsActive = productCreateDto.IsActive,
                SupplierCode = productCreateDto.SupplierCode,
                SupplierDescription = productCreateDto.SupplierDescription,  
                SupplierCnpj = productCreateDto.SupplierCnpj
            };

            await DbContext.Products.InsertOneAsync(product);
        }

        public async Task<IEnumerable<ProductsListDto>> GetProducts()
        {
            var productsList = await DbContext.Products
                                    .AsQueryable()
                                    .Select(p => new ProductsListDto
                                    {
                                        Id = p.Id,
                                        Code = p.Code,
                                        Description = p.Description,
                                        FabricationDate = p.FabricationDate,
                                        ValidationDate = p.ValidationDate,
                                        IsActive = p.IsActive,
                                        SupplierCode = p.SupplierCode,
                                        SupplierDescription = p.SupplierDescription,
                                        SupplierCnpj = p.SupplierCnpj
                                    })
                                    .ToListAsync();
                                    
            return productsList;
        }

        public async Task<List<ProductsListDto>> SearchProducts(int skip, int take, string searchTerms = null)
        {
            var listProducts = DbContext.Products
                       .AsQueryable()
                       .Where(c => c.Description.ToLower().Contains(searchTerms.ToLower()) 
                           || c.SupplierDescription.ToLower().Contains(searchTerms.ToLower()))
                       .Select(p => new ProductsListDto
                       {
                           Id = p.Id,
                           Code = p.Code,
                           Description = p.Description,
                           FabricationDate = p.FabricationDate,
                           ValidationDate = p.ValidationDate,
                           IsActive = p.IsActive,
                           SupplierCode = p.SupplierCode,
                           SupplierDescription = p.SupplierDescription,
                           SupplierCnpj = p.SupplierCnpj
                       })
                       .Skip(skip)
                       .Take(take)
                       .ToList();

            return listProducts;
        }

        public async Task UpdateProduct(int code, ProductDto productDto)
        {
            if (code != null)
            {
                var update = Builders<Product>.Update
                                .Set(p => p.Description, productDto.Description)
                                .Set(p => p.IsActive, productDto.IsActive)
                                .Set(p => p.SupplierCnpj, productDto.SupplierCnpj)
                                .Set(p => p.SupplierCode, productDto.SupplierCode)
                                .Set(p => p.SupplierDescription, productDto.SupplierDescription)
                                .Set(p => p.ValidationDate, productDto.ValidationDate);

                if (productDto.FabricationDate >= productDto.ValidationDate)
                {
                    throw new NotUpdateFabricationDateException();
                }
                else
                {
                    update.Set(p => p.FabricationDate, productDto.FabricationDate);
                }

                await DbContext.Products.UpdateOneAsync(p => p.Code == code, update);
            }
        }

        public async Task SetProductActive(int code, bool isActive)
        {
            var isActiveProduct = await DbContext.Products
                                .AsQueryable()
                                .Where(p => p.Code == code)
                                .Select(p => p.IsActive)
                                .FirstOrDefaultAsync();

            if (!isActiveProduct && isActive)
            {
                var update = Builders<Product>.Update
                                .Set(p => p.IsActive, isActive);

                await DbContext.Products.UpdateOneAsync(p => p.Code == code, update);
            }
        }

        public async Task SetProductInactive(int code, bool isActive)
        {
            var isActiveProduct = await DbContext.Products
                                .AsQueryable()
                                .Where(p => p.Code == code)
                                .Select(p => p.IsActive)
                                .FirstOrDefaultAsync();

            if (isActiveProduct && !isActive)
            {
                var update = Builders<Product>.Update
                                .Set(p => p.IsActive, isActive);

                await DbContext.Products.UpdateOneAsync(p => p.Code == code, update);
            }
        }
    }
}
