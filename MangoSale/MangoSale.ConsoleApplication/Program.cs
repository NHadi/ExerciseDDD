using MangoSale.Application;
using MangoSale.Application.Interface;
using MangoSale.CrossCutting.InversionOfControl;
using MangoSale.Data.Repositories;
using MangoSale.Domain.Entities;
using MangoSale.Domain.Interfaces.Service;
using MangoSale.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoSale.ConsoleApplication
{
    class Program
    { 
        public static void Main(string[] args)
        {                                    
            try
            {
                

               
                var data = new Employee();
                data.Name = "Test";
                data.Code = "T01";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        public void start() 
        {
            var ioc = new IoC();



        }

    }
}
