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
    public class AggregateRepository<TAggregate> : IAggregateRepository<TAggregate> where TAggregate: class
    {
        protected readonly DbContext _context;
        protected readonly DbQuery<TAggregate> _entities;
        public AggregateRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Query<TAggregate>();
        }
        public async Task<IEnumerable<TAggregate>> FindAsync(Expression<Func<TAggregate, bool>> predicate)
        {
            return await Task.FromResult<IEnumerable<TAggregate>>(_entities.Where(predicate));
        }

        public async Task<IEnumerable<TAggregate>> GetAllAsync()
        {
            return await Task.FromResult<IEnumerable<TAggregate>>(_entities);
        }
    }
}
