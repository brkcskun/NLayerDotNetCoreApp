using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NLayerDotNetCoreApp.Business.Exceptions;
using NLayerDotNetCoreApp.Core.Repositories;
using NLayerDotNetCoreApp.Core.Services;
using NLayerDotNetCoreApp.Core.UnitOfWorks;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NLayerDotNetCoreApp.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public Service(IGenericRepository<T> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<TDto> AddAsync<TDto>(TDto entityDto)
        {
            var entity = _mapper.Map<T>(entityDto);

            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();

            var response = _mapper.Map<TDto>(entity);

            return response;
        }

        public async Task<IEnumerable<TDto>> AddRangeAsync<TDto>(IEnumerable<T> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();

            var response = _mapper.Map<IEnumerable<TDto>>(entities);

            return response;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.AnyAsync(expression);
        }

        public async Task<IEnumerable<TDto>> GetAllAsync<TDto>()
        {
            var entities = _repository.GetAllAsync();
            var response = await entities.ProjectTo<TDto>(_mapper.ConfigurationProvider).ToListAsync();

            return response;
        }

        public async Task<TDto> GetByIdAsync<TDto>(int id)
        {
            var entity = await _repository.GetByIdAsync(id);

            var response = _mapper.Map<TDto>(entity);
            return response;
        }

        public async Task RemoveAsync(T entity)
        {
            _repository.Remove(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
