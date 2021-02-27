using Abp.Application.Services;
using Ayarla.AyarlaAccounts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaAccounts
{
    public interface IAyarlaAccountAppService : IAsyncCrudAppService<AccountDto,Guid>
    {
    }
}
