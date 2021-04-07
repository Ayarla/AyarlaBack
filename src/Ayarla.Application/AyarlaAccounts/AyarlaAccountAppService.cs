using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Ayarla.Authorization;
using Ayarla.Authorization.Accounts;
using Ayarla.AyarlaAccounts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaAccounts
{
    [AbpAuthorize(PermissionNames.Pages_Accounts)]
    public class AyarlaAccountAppService : AsyncCrudAppService<Account, AccountDto, Guid,PagedAccountResultRequestDto>, IAyarlaAccountAppService
    {
        public AyarlaAccountAppService(IRepository<Account, Guid> accountRepository) : base(accountRepository)
        {
        }
    }
}
