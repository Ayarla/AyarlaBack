using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Ayarla.Authorization.Accounts;
using Ayarla.AyarlaAccounts.Dto;


namespace Ayarla.OpenCloseTimes
{
    public class OpenCloseTimeAppService : AsyncCrudAppService<OpenCloseTime,OpenCloseTimeDto,Guid,PagedOpenClosedTimeResultRequestDto,CreateOpenCloseTimeDto,OpenCloseTimeDto>,IOpenCloseTimeAppService
    {
        private readonly IRepository<Account,Guid> _accountRepository;
        
        public OpenCloseTimeAppService(
            IRepository<OpenCloseTime, Guid> openCloseTimeRepository,
            IRepository<Account,Guid> accountRepository) 
            : base(openCloseTimeRepository)
        {
            _accountRepository = accountRepository;
        }

        public override async Task<OpenCloseTimeDto> CreateAsync(CreateOpenCloseTimeDto input)
        {
            CheckCreatePermission();

            var openclosetime = ObjectMapper.Map<OpenCloseTime>(input);
            
             await _accountRepository.GetAsync(input.AccountId);

             await Repository.InsertAsync(openclosetime);

             CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<OpenCloseTimeDto>(openclosetime);
        }
        
    }
}