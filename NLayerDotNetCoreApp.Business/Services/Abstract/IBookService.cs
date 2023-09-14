using NLayerDotNetCoreApp.Core.Dtos;
using NLayerDotNetCoreApp.Core.Models;
using NLayerDotNetCoreApp.Core.Services;

namespace NLayerDotNetCoreApp.Business.Services.Abstract
{
    public interface IBookService : IService<Book>
    {
        public Task<CustomResponseDto<List<BookWithAuthorsDto>>> GetBookByIdWithAuthorsAsync(int bookId);
    }
}
