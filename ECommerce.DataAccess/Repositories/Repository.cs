using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ECommerceDbText _eCommerceDbText;
        public Repository(ECommerceDbText eCommerceDbText)
        {
            this._eCommerceDbText = eCommerceDbText;
        }

        public async Task AddAsync(TEntity entity)
        {
             await _eCommerceDbText.Set<TEntity>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _eCommerceDbText.Set<TEntity>().AddRangeAsync(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _eCommerceDbText.Set<TEntity>().Where(predicate); 
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _eCommerceDbText.Set<TEntity>().ToListAsync();
        }

        public ValueTask<TEntity> GetByIdAsync(int id)
        {
            return _eCommerceDbText.Set<TEntity>().FindAsync();
        }

        public void Remove(TEntity entity)
        {
            _eCommerceDbText.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _eCommerceDbText.Set<TEntity>().RemoveRange(entities);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
           return await _eCommerceDbText.Set<TEntity>().SingleOrDefaultAsync(predicate);
        }
    }
}
