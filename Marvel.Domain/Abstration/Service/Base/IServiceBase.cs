using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Domain.Abstration.Service.Base
{
    public interface IServiceBase<TEntity>
    {
        Task<TEntity> GetByIdAsync(object id);
        Task AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
