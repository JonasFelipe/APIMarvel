using Marvel.Domain.Abstration.Repository.Base;
using Marvel.Domain.Entities.Base;
using Marvel.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Repository.Repositories.Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : Entity
    {
        protected readonly DbSet<TEntity> EntityDbSet;
        protected readonly MarvelContext EntityContext;

        public RepositoryBase(MarvelContext context)
        {
            EntityContext = context;
            EntityDbSet = EntityContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            EntityDbSet.Add(entity);
            await EntityContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            EntityDbSet.Remove(entity);
            await EntityContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> where, bool canTracking = false)
        {
            var query =
                canTracking
                    ? await EntityDbSet
                        .Where(where)
                        .ToListAsync()
                        .ConfigureAwait(false)

                    : await EntityDbSet
                        .Where(where)
                        .AsNoTracking()
                        .ToListAsync()
                        .ConfigureAwait(false);

            return query;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var query =
                await EntityDbSet
                    .ToListAsync()
                    .ConfigureAwait(false);

            return query;
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            var currentId = int.Parse(id.ToString());
            Expression<Func<TEntity, bool>> predicate = t => t.Id == currentId;

            return await EntityContext.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var currentEntity = await GetByIdAsync(entity.Id).ConfigureAwait(false);
            EntityContext.Entry(currentEntity).CurrentValues.SetValues(entity);

            await EntityContext.SaveChangesAsync();
            return entity;
        }
    }
}
