using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayerDotNetCoreApp.Business.Services.Abstract;
using NLayerDotNetCoreApp.Core.Dtos;
using System.Net;

namespace NLayerDotNetCoreApp.API.Controllers
{
    public class BookController : CustomBaseController
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IBookService todoService, IMapper mapper)
        {
            _bookService = todoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await _bookService.GetAllAsync<BooksWithAuthorsDto>();
            return CreateActionResult(CustomResponseDto<List<BooksWithAuthorsDto>>.Success((int)HttpStatusCode.OK, books.ToList()));
        }
    }
}
