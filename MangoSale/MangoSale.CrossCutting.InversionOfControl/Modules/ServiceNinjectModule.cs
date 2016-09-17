using MangoSale.Common.Domain.Services;
using MangoSale.Common.Domain.Services.Interface;
using MangoSale.Domain.Interfaces.Service;
using MangoSale.Domain.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.CrossCutting.InversionOfControl.Modules
{
    public class ServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IService<>)).To(typeof(Service<>));

            Bind<IEmployeeService>().To<EmployeeService>();
        }
    }
}
