using Core.Common;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _entities;
        public EFRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.FromResult<IEnumerable<TEntity>>(_entities.Where(predicate));
        }

        public async Task<TEntity> GetAsync(int Id)
        {
            return await _entities.FindAsync(Id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Task.FromResult<IEnumerable<TEntity>>(_entities);
        }

        public async Task<int> GetCountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.CountAsync(predicate);

        }

        public async Task RemoveAsync(TEntity entity)
        {
            _entities.Remove(entity);

        }

        public async Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.FirstOrDefaultAsync(predicate);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
