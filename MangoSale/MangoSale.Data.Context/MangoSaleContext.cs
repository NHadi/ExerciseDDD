using MangoSale.Common.Infrastructure.Data.Context.Config;
using MangoSale.Data.Context.Config;
using MangoSale.Data.Context.Mapping;
using MangoSale.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Data.Context
{
    public class MangoSaleContext : BaseDbContext
    {
        static MangoSaleContext()
        {
            Database.SetInitializer(new ContextInitializer());
        }

        public MangoSaleContext()
            //: base("Server=.\\SQLSERVER2012;Database=MangoSale;User Id=sa;Password=P@55w0rd")
            : base("MangoSaleEntities")            
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new EmployeeMap());
        }

        #region DbSet

        public DbSet<Employee> Employees { get; set; }

        #endregion
    }
}
