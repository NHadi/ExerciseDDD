using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetByCode(string code);
    }
}
