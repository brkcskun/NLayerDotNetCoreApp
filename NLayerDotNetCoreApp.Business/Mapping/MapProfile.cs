using NLayerDotNetCoreApp.Core.Dtos;
using NLayerDotNetCoreApp.Core.Models;
using AutoMapper;

namespace NLayerDotNetCoreApp.Business.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
        }
    }
}
