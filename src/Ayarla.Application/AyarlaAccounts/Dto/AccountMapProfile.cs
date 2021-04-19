using AutoMapper;
using Ayarla.Authorization.Accounts;

namespace Ayarla.AyarlaAccounts.Dto
{
    
    public class AccountMapProfile : Profile
    {
        public AccountMapProfile()
        {
            CreateMap<Account, PagedAccountResultDto>();
            CreateMap<Account, AccountDto>()
                .ForMember(o => o.OpenCloseTimes, opt => opt.Ignore())
                .ForMember(o => o.Gender, opt => opt.Ignore());
            
            
            CreateMap<PagedAccountResultDto, Account>();
            CreateMap<PagedAccountResultDto, Account>()
                .ForMember(o => o.OpenCloseTimes, opt => opt.Ignore())
                .ForMember(o => o.Gender, opt => opt.Ignore());
        }

    }
}