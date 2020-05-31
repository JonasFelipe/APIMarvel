using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Domain.Abstration.Repository.Base
{
    public interface IRepositoryBase<TEntity>
    {
        Task AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> where, bool canTracking = false);
        Task<TEntity> GetByIdAsync(object id);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
