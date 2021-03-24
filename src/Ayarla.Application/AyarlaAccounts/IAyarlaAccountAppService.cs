using Abp.Application.Services;
using Ayarla.AyarlaAccounts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Ayarla.Roles.Dto;
using Ayarla.Users.Dto;

namespace Ayarla.AyarlaAccounts
{
    public interface IAyarlaAccountAppService : IAsyncCrudAppService<AccountDto,Guid,PagedAccountResultRequestDto>
    {

    }
}
