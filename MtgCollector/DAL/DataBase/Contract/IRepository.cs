using System.Collections.Generic;
using DAL.DataBase.Models;

namespace DAL.DataBase.Contract
{
    public interface IRepository<TEntity>
        where TEntity: class, IEntity
    {
        List<TEntity> Get();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(int id);
    }
}
