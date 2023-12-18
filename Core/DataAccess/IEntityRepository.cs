using Entities.Abstracts;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>>? predicate = null,
                              Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = true);
        T? Get(Expression<Func<T, bool>> predicate,
               Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
               bool enableTracking = true);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
