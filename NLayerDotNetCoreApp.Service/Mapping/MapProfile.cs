using NLayerDotNetCoreApp.Core.Dtos;
using NLayerDotNetCoreApp.Core.Models;
using AutoMapper;

namespace NLayerDotNetCoreApp.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
            //CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            //CreateMap<ProductUpdateDto, Product>();
            //    CreateMap<Product, ProductWithCategoryDto>();
            //    CreateMap<Category, CategoryWithProductsDto>();
        }
    }
}
