using System.Linq.Expressions;

namespace NLayerDotNetCoreApp.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<TDto> GetByIdAsync<TDto>(int id);
        Task<IEnumerable<TDto>> GetAllAsync<TDto>();
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<TDto> AddAsync<TDto>(TDto entity);
        Task<IEnumerable<TDto>> AddRangeAsync<TDto>(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
