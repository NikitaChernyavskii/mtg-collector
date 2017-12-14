using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DAL.DataBase.Contract;
using DAL.DataBase.Models;

namespace DAL.DataBase
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        public List<TEntity> Get(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            using (var context = new MtgCollectorDbContext())
            {
                IQueryable<TEntity> entities = context.Set<TEntity>();
                foreach (var includeProperty in includeProperties)
                {
                    entities = entities.Include(includeProperty);
                }

                return entities.ToList();
            }
        }

        public void Add(TEntity entity)
        {
            using (var context = new MtgCollectorDbContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new MtgCollectorDbContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            using (var context = new MtgCollectorDbContext())
            {
                TEntity dbEntity = context.Set<TEntity>().Find(id);
                if (dbEntity == null)
                {
                    return;
                }
                context.Set<TEntity>().Remove(dbEntity);
                context.SaveChanges();
            }
        }

    }
}
