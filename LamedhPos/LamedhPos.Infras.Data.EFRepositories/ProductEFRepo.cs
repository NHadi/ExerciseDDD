using LamedhPos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Infras.Data.EFRepositories
{
    public class ProductEFRepo : EFRepositoryBase<Product, LamedhPosContext>, IDisposable
    {
        public Product GetByCode(string code)
        {
            return posContext.Products.Single(e => e.Code == code);
        }

        protected override DbSet<Product> GetDbSet()
        {
            return posContext.Products;
        }
    }
}
