using AutoMapper;
using Ayarla.Authorization.Accounts;

namespace Ayarla.EmployeeAccounts.Dto
{
    public class EmployeeAccountMapProfile : Profile
    {
        public EmployeeAccountMapProfile()
        {
            CreateMap<EmployeeAccountDto, EmployeeAccount>();
            CreateMap<EmployeeAccount, EmployeeAccountDto>();
        }
    }
}