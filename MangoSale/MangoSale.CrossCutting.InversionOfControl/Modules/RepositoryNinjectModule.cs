using MangoSale.Common.Domain.Repository.EntityFramework;
using MangoSale.Common.Domain.Repository.EntityFramework.Interface;
using MangoSale.Data.Context;
using MangoSale.Data.Repositories;
using MangoSale.Data.Repositories.Dapper;
using MangoSale.Data.Repositories.EntityFramework;
using MangoSale.Data.Repositories.EntityFramework.Common;
using MangoSale.Domain.Entities;
using MangoSale.Domain.Interfaces.Repository;
using MangoSale.Domain.Interfaces.Repository.ReadOnly;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.CrossCutting.InversionOfControl.Modules
{
    public class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepository<>)).To(typeof(Repository<>));

            Bind<IEmployeeRepository>().To<EmployeeRepository>();
            Bind<IEmployeeReadOnlyRepository>().To<EmployeeDapperRepository>();
            Bind<IReadOnlyRepository<Employee>>().To<EmployeeDapperRepository>();
        }
    }
}
