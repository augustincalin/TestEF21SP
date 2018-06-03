using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAggregateRepository<TAggregate>
    {
        Task<IEnumerable<TAggregate>> GetAllAsync();
        Task<IEnumerable<TAggregate>> FindAsync(Expression<Func<TAggregate, bool>> predicate);
    }
}
