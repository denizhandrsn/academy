using DataAccess.Abstracts;
using Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContext : DbContext , new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }


        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate,
               Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
               bool enableTracking = true)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> queryable = context.Set<TEntity>();
                if (!enableTracking) queryable.AsNoTracking();
                if (include is not null) queryable = include(queryable);
                return queryable.SingleOrDefault(predicate);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate = null,
                              Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool enableTracking = true)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> queryable = context.Set<TEntity>();
                if (!enableTracking) queryable.AsNoTracking();
                if (include is not null) queryable = include(queryable);
                return queryable.ToList();
            }
        }



        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }




    }
}
