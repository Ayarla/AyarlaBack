using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Ayarla.Authorization;
using Ayarla.Authorization.Accounts;
using Ayarla.AyarlaAccounts.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Abp;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Linq.Extensions;
using Abp.Modules;
using Microsoft.EntityFrameworkCore;

namespace Ayarla.AyarlaAccounts
{
    [DependsOn(typeof(AbpAutoMapperModule))]
    [AbpAuthorize(PermissionNames.Pages_Accounts)]
    public class AyarlaAccountAppService : AsyncCrudAppService<Account, AccountDto, Guid,PagedAccountResultRequestDto,CreateAccountDto,AccountDto>, IAyarlaAccountAppService
    {
        private readonly IRepository<OpenCloseTime, Guid> _openclosetimeRepository;
        private readonly IRepository<Account, Guid> _accountRepository;
        public AyarlaAccountAppService(
            IRepository<Account, Guid> accountRepository,
            IRepository<OpenCloseTime,Guid> openclosetimeRepository) 
            : base(accountRepository)
        {
            _openclosetimeRepository = openclosetimeRepository;
            _accountRepository = accountRepository;
        }

        public override async Task<AccountDto> CreateAsync(CreateAccountDto input)
        {
            CheckCreatePermission();
            var account = ObjectMapper.Map<Account>(input);

            account.Id = SequentialGuidGenerator.Instance.Create();

            account.UserId = AbpSession.UserId;

            await Repository.InsertAndGetIdAsync(account);

            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<AccountDto>(account);
        }

        public async Task<PagedResultDto<AccountDto>> GetAllAccounts(PagedAccountResultRequestDto input)
        {
            var accountQuery = _accountRepository.GetAll()
                .Include(o => o.OpenCloseTimes);
            
            var accounts =await accountQuery.PageBy(input).ToListAsync();

            return new PagedResultDto<AccountDto>(accountQuery.Count(), ObjectMapper.Map<List<AccountDto>>(accounts));
        }
        
        
    }
}
