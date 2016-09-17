using LamedhPos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Infras.Data.EFRepositories
{
    public class LamedhPosContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }

        public LamedhPosContext()
            : base("Server=.\\SQLEXPRESS;Database=LamedhPos;User Id=sa;Password=f4aith..")
        {
        }
    }
}
