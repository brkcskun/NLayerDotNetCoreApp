using Microsoft.EntityFrameworkCore;
using NLayerDotNetCoreApp.Core.Dtos;
using NLayerDotNetCoreApp.Core.Models;
using NLayerDotNetCoreApp.Core.Repositories;
using NLayerDotNetCoreApp.Data.EntityFramework;

namespace NLayerDotNetCoreApp.Data.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Book>> GetBooksWithAuthors()
        {
            var books = await _context.Books.Include(x => x.Authors).ThenInclude(x=>x.Author).ToListAsync();

            return books;
        }
    }
}
