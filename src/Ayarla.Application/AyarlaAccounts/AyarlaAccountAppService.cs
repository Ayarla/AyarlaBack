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
using Abp;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ayarla.AyarlaAccounts
{
    [AbpAuthorize(PermissionNames.Pages_Accounts)]
    public class AyarlaAccountAppService : AsyncCrudAppService<Account, AccountDto, Guid,PagedAccountResultRequestDto,CreateAccountDto,AccountDto>, IAyarlaAccountAppService
    {
        private readonly IRepository<OpenCloseTime, Guid> _openclosetimeRepository;
        public AyarlaAccountAppService(
            IRepository<Account, Guid> accountRepository,
            IRepository<OpenCloseTime,Guid> openclosetimeRepository) 
            : base(accountRepository)
        {
            _openclosetimeRepository = openclosetimeRepository;
        }

        public override async Task<AccountDto> CreateAsync(CreateAccountDto input)
        {
            CheckCreatePermission();
            var account = ObjectMapper.Map<Account>(input);

            var accountId = SequentialGuidGenerator.Instance.Create();

            account.Id = accountId;

            await Repository.InsertAndGetIdAsync(account);

            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<AccountDto>(account);
        }

 
    }
}
