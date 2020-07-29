
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        Task<Int32> AddAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
        Task RemoveAsync(TEntity obj);
        Task<bool> AnyAsync(TEntity obj);
        void Dispose();
        Task<TEntity> GetByIDAsync(Int32 ID);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddRangeAsync(IEnumerable<TEntity> obj);
        Task UpdateRangeAsync(IEnumerable<TEntity> obj);
    }
}
