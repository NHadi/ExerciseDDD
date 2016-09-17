using MangoSale.Common.Domain.Services;
using MangoSale.Domain.Entities;
using MangoSale.Domain.Interfaces.Repository;
using MangoSale.Domain.Interfaces.Repository.ReadOnly;
using MangoSale.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Domain.Services
{
    public class EmployeeService : Service<Employee>, IEmployeeService
    {
        public EmployeeService(IEmployeeRepository repository, IEmployeeReadOnlyRepository readOnlyRepository) 
            : base(repository, readOnlyRepository)
        {
        }
    }
}
