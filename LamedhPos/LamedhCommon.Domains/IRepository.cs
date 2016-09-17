using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public interface IRepository<TEntity>
    {
        int GetCount();
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Search(string key);
        void Save(TEntity entity);
        void Delete(int id);
    }
}
