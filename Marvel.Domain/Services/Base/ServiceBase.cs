using Marvel.Domain.Abstration.Repository.Base;
using Marvel.Domain.Abstration.Service.Base;
using Marvel.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Domain.Services.Base
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : Entity
    {
        private readonly IRepositoryBase<TEntity> _repository;

        protected ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await _repository.UpdateAsync(entity);
        }
    }
}