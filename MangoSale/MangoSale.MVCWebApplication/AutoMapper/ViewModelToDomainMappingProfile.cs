using AutoMapper;
using MangoSale.Domain.Entities;
using MangoSale.MVCWebApplication.ViewModels;

namespace MangoSale.MVCWebApplication.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<EmployeeViewModel, Employee>();
        }
    }
}