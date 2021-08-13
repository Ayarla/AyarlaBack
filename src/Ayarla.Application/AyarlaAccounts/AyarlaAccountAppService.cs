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
using Ayarla.Authorization.Users;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Ayarla.Comments.Dto;

namespace Ayarla.AyarlaAccounts
{
    [DependsOn(typeof(AbpAutoMapperModule))]
    [AbpAuthorize(PermissionNames.Pages_Accounts)]
    public class AyarlaAccountAppService : AsyncCrudAppService<Account, AccountDto, Guid,PagedAccountResultRequestDto,CreateAccountDto,AccountDto>, IAyarlaAccountAppService
    {
        private readonly IRepository<OpenCloseTime, Guid> _openclosetimeRepository;
        private readonly IRepository<Account, Guid> _accountRepository;
        private readonly IRepository<Comment, Guid> _commentRepository;
        public AyarlaAccountAppService(
            IRepository<Account, Guid> accountRepository,
            IRepository<OpenCloseTime,Guid> openclosetimeRepository,
            IRepository<Comment,Guid> commentRepository) 
            : base(accountRepository)
        {
            _openclosetimeRepository = openclosetimeRepository;
            _accountRepository = accountRepository;
            _commentRepository = commentRepository;
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

        public override async Task<PagedResultDto<AccountDto>> GetAllAsync(PagedAccountResultRequestDto input)
        {
            var accountQuery = _accountRepository.GetAll()
                .Include(o => o.OpenCloseTimes);
                
            
            var accounts =await accountQuery.PageBy(input).ToListAsync();
            
            return new PagedResultDto<AccountDto>(accountQuery.Count(), ObjectMapper.Map<List<AccountDto>>(accounts));
        }

        public async Task<AccountDto> GetAllCommentsAsync(AccountDto input)
        {
            var account = ObjectMapper.Map<AccountDto>(input);

            account.CommentNumber = _commentRepository.GetAll()
                .Count(o => o.AccountId == account.Id);


            return ObjectMapper.Map<AccountDto>(account);

        }
    }
}
