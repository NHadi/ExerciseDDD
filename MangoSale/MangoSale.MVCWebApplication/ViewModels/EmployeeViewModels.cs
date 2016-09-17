using AutoMapper;
using MangoSale.Domain.Entities;

namespace MangoSale.MVCWebApplication.ViewModels
{
    public class EmployeeViewModel
    {
        public string Name { get; set; }

        public static EmployeeViewModel ToViewModel(Employee employee)
        {
            return Mapper.Map<EmployeeViewModel>(employee);
        }
    }
}