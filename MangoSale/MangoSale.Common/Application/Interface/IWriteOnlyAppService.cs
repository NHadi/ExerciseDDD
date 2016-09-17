using MangoSale.Common.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Common.Application.Interface
{
    public interface IWriteOnlyAppService<in TEntity>
    where TEntity : class
    {
        ValidationResult Create(TEntity entity);
        ValidationResult Update(TEntity entity);
        ValidationResult Remove(TEntity entity);
    }
}
