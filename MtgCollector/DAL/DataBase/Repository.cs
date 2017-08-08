using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using DAL.DataBase.Contract;
using DAL.DataBase.Models;

namespace DAL.DataBase
{
    public class Repository<TEntity> : IRepository<TEntity>, IDisposable
        where TEntity : class, IEntity
    {
        private MtgCollectorDbContext _dbContext;
        private DbSet<TEntity> _dbSet;

        public Repository()
        {
            _dbContext = new MtgCollectorDbContext();
            _dbSet = _dbContext.Set<TEntity>();
        }

        public List<TEntity> Get()
        {
            return _dbSet.ToList();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbSet.AddOrUpdate(entity);
        }

        public void Delete(int id)
        {
            TEntity dbEntity = _dbSet.Find(id);
            if (dbEntity == null)
            {
                return;
            }
            _dbSet.Remove(dbEntity);
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
