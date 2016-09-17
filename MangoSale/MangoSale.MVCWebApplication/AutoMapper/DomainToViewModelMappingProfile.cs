using AutoMapper;
using MangoSale.Domain.Entities;
using MangoSale.MVCWebApplication.ViewModels;

namespace MangoSale.MVCWebApplication.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<EmployeeViewModel, Employee>();
        }
    }
}