using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity> GetAsync(int Id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task AddAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        Task<int> GetCountAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> predicate);
        Task SaveAsync();
    }
}
