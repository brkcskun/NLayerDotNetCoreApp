using NLayerDotNetCoreApp.Core.Dtos;
using NLayerDotNetCoreApp.Core.Models;

namespace NLayerDotNetCoreApp.Core.Repositories
{
    public interface IBookRepository:IGenericRepository<Book>
    {
        Task<List<Book>> GetBooksWithAuthors();
    }
}
