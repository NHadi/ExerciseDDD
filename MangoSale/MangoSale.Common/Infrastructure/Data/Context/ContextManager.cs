using MangoSale.Common.Infrastructure.Data.Context.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Common.Infrastructure.Data.Context
{
    public class ContextManager<TContext> : IContextManager<TContext>
        where TContext : IDbContext, new()
    {
        protected TContext context;

        public ContextManager()
        {
            context = new TContext();
        }

        public IDbContext GetContext()
        {
            return context as IDbContext;
        }

        public void Finish()
        {
            (context as IDbContext).Dispose();
        }
    }
}
