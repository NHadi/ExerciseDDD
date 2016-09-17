using MangoSale.Common.Domain.Repository.EntityFramework.Interface;
using MangoSale.Common.Domain.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Common.Domain.Services
{
    public class ReadOnlyService<TEntity> : IReadOnlyService<TEntity>
        where TEntity : class
    {
        #region Constructor

        private readonly IReadOnlyRepository<TEntity> _readOnlyRepository;

        public ReadOnlyService(
            IReadOnlyRepository<TEntity> readOnlyRepository)
        {
            _readOnlyRepository = readOnlyRepository;
        }

        #endregion

        #region Properties

        protected IReadOnlyRepository<TEntity> ReadOnlyRepository
        {
            get { return _readOnlyRepository; }
        }

        #endregion

        public virtual TEntity Get(int id)
        {
            return _readOnlyRepository.Get(id);
        }

        public virtual IEnumerable<TEntity> All()
        {
            return _readOnlyRepository.All();
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _readOnlyRepository.Find(predicate);
        }
    }
}
