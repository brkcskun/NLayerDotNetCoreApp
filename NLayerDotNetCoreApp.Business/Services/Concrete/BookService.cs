using AutoMapper;
using NLayerDotNetCoreApp.Business.Services.Abstract;
using NLayerDotNetCoreApp.Core.Dtos;
using NLayerDotNetCoreApp.Core.Models;
using NLayerDotNetCoreApp.Core.Repositories;
using NLayerDotNetCoreApp.Core.UnitOfWorks;
using NLayerDotNetCoreApp.Service.Services;

namespace NLayerDotNetCoreApp.Business.Services.Concrete
{
    public class BookService : Service<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IGenericRepository<Book> repository, IUnitOfWork unitOfWork, IBookRepository bookRepository, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<BookWithAuthorsDto>>> GetBookByIdWithAuthorsAsync(int bookId)
        {
            var books = await _bookRepository.GetBooksWithAuthors();

            var bookDtos = _mapper.Map<List<BookWithAuthorsDto>>(books);

            return CustomResponseDto<List<BookWithAuthorsDto>>.Success(200, bookDtos);
        }
    }
}