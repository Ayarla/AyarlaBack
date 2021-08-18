using AutoMapper;
using Ayarla.Authorization.Accounts;

namespace Ayarla.AyarlaAccounts.Dto
{
    public class AccountMapProfile : Profile
    {
        public AccountMapProfile()
        {
            CreateMap<AccountDto, Account>();
            CreateMap<Account, AccountDto>();
        }
    }
}