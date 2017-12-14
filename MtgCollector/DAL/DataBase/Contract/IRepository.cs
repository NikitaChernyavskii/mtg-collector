using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DAL.DataBase.Models;

namespace DAL.DataBase.Contract
{
    public interface IRepository<TEntity>
        where TEntity: class, IEntity
    {
        List<TEntity> Get(params Expression<Func<TEntity, object>>[] includeProperties);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(Guid id);
    }
}
