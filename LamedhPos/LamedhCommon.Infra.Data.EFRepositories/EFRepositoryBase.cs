using LamedhPos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Infras.Data.EFRepositories
{
    public abstract class EFRepositoryBase<TEntity, TContext> 
        where TEntity : EntityBase 
        where TContext : DbContext, new()
    {
        protected TContext posContext;
        private DbSet<TEntity> dbSet;

        public EFRepositoryBase()
        {
            posContext = new TContext();
            dbSet = GetDbSet();
        }

        public int GetCount()
        {
            return dbSet.Count();
        }

        public TEntity GetById(int id)
        {
            return dbSet.Single(e => e.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet;
        }

        public void Save(TEntity entity)
        {
            if (entity.Id == 0)
                dbSet.Add(entity);
            else
            {
                dbSet.Attach(entity);
                posContext.Entry(entity).State = EntityState.Modified;
            }
            posContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            dbSet.Remove(entity);
            posContext.SaveChanges();
        }

        public void Dispose()
        {
            posContext.Dispose();
        }

        protected abstract DbSet<TEntity> GetDbSet();
    }
}
