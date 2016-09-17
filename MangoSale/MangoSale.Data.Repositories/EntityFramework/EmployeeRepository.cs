using MangoSale.Common.Domain.Repository.EntityFramework;
using MangoSale.Data.Context;
using MangoSale.Domain.Entities;
using MangoSale.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.Data.Repositories.EntityFramework
{
    public class EmployeeRepository : Repository<MangoSaleContext, Employee>, IEmployeeRepository
    {

    }
}
