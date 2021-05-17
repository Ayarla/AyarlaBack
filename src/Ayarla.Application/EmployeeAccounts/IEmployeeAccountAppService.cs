using System;
using Abp.Application.Services;
using Ayarla.EmployeeAccounts.Dto;
using Ayarla.Services.Dto;

namespace Ayarla.EmployeeAccounts
{
    public interface IEmployeeAccountAppService : IAsyncCrudAppService<EmployeeAccountDto,Guid,PagedEmployeeAccountResultRequestDto,CreateEmployeeAccountDto,EmployeeAccountDto>
    {
        
    }
}