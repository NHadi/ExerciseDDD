using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Data.Repositories.Dapper.Common
{
    public class Repository : IDisposable
    {
        public IDbConnection MangoSaleConnection
        {
            get { return new SqlCeConnection(ConfigurationManager.ConnectionStrings["MangoSaleEntities"].ConnectionString); }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
