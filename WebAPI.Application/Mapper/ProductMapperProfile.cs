using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.InputModels.Common;
using WebAPI.Application.InputModels.Product;
using WebAPI.Application.ViewModels.Product;
using WebAPI.Core.DTOs.Common;
using WebAPI.Core.DTOs.Product;

namespace WebAPI.Application.Mapper
{
    public class ProductMapperProfile : Profile
    {
        public ProductMapperProfile()
        {
            CreateMap<ProductDto, ProductInputModel>();
            CreateMap<ProductInputModel, ProductDto>();


            CreateMap<PaginationInputModel, PaginationDto>();
            CreateMap<PaginationDto, PaginationInputModel>();
            CreateMap<ProductsListDto, ProductsListViewModel>();
            CreateMap<ProductsListViewModel, ProductsListDto>();
        }
    }
}
