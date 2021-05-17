using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Ayarla.Authorization.Accounts;
using Ayarla.EmployeeAccounts.Dto;
using Ayarla.Services.Dto;

namespace Ayarla.EmployeeAccounts
{
    public class EmployeeAccountAppService : AsyncCrudAppService<EmployeeAccount,EmployeeAccountDto,Guid,PagedEmployeeAccountResultRequestDto,CreateEmployeeAccountDto,EmployeeAccountDto>,IEmployeeAccountAppService
    {
        private readonly IRepository<Account, Guid> _accountRepository;
        private readonly IRepository<Employee, Guid> _employeeRepository;
        
        public EmployeeAccountAppService(
            IRepository<EmployeeAccount, Guid> repository,
            IRepository<Account,Guid> accountRepository,
            IRepository<Employee,Guid> employeeRepository) 
            : base(repository)
        {
            _accountRepository = accountRepository;
            _employeeRepository = employeeRepository;
        }

        public  override async Task<EmployeeAccountDto> CreateAsync(CreateEmployeeAccountDto input)
        {
            var employeeAccount = ObjectMapper.Map<EmployeeAccount>(input);

            await _accountRepository.GetAsync(input.AccountId);

            await _employeeRepository.GetAsync(input.EmployeeId);

            await Repository.InsertAsync(employeeAccount);
            
            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<EmployeeAccountDto>(employeeAccount);

        }
    }
}