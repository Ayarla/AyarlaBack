using AutoMapper;
using Ayarla.Authorization.Accounts;

namespace Ayarla.AyarlaAccounts.Dto
{
    public class OpenCloseTimeMapProfile : Profile
    {
        public OpenCloseTimeMapProfile()
        {
            CreateMap<OpenCloseTimeDto, OpenCloseTime>();
            CreateMap<OpenCloseTime, OpenCloseTimeDto>();
        }
    }
}