using AutoMapper;
using NLayerDotNetCoreApp.Business.Services.Abstract;
using NLayerDotNetCoreApp.Core.Models;
using NLayerDotNetCoreApp.Core.Repositories;
using NLayerDotNetCoreApp.Core.UnitOfWorks;
using NLayerDotNetCoreApp.Service.Services;

namespace NLayerDotNetCoreApp.Business.Services.Concrete
{
    public class AuthorService : Service<Author>, IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IGenericRepository<Author> repository, IUnitOfWork unitOfWork, IAuthorRepository authorRepository, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }
    }
}
