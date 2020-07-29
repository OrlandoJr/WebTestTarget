using Application.Interfaces;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }


        public async Task<Int32> AddAsync(TEntity obj)
        {
            return await _serviceBase.AddAsync(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public async Task<bool> AnyAsync(TEntity obj)
        {
            return await _serviceBase.AnyAsync(obj);
        }


        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _serviceBase.GetAllAsync();
        }

        public async Task<TEntity> GetByIDAsync(Int32 ID)
        {
            return await _serviceBase.GetByIDAsync(ID);
        }

        public async Task RemoveAsync(TEntity obj)
        {
            await _serviceBase.RemoveAsync(obj);
        }

        public async Task UpdateAsync(TEntity obj)
        {
            await _serviceBase.UpdateAsync(obj);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> obj)
        {
            await _serviceBase.AddRangeAsync(obj);
        }

        public async Task UpdateRangeAsync(IEnumerable<TEntity> obj)
        {
            await _serviceBase.UpdateRangeAsync(obj);
        }
    }
}
