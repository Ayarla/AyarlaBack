using AutoMapper;
using Ayarla.Authorization.Accounts;

namespace Ayarla.EmployeeServices.Dto
{
    public class EmployeeServiceMapProfile : Profile
    {
        public EmployeeServiceMapProfile()
        {
            CreateMap<EmployeeServiceDto, EmployeeService>();
            CreateMap<EmployeeService, EmployeeServiceDto>();
        }
        
    }
}