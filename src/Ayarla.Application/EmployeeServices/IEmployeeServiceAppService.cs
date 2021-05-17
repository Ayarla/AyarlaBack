using System;
using Abp.Application.Services;
using Ayarla.EmployeeServices.Dto;
using Ayarla.Services.Dto;

namespace Ayarla.EmployeeServices
{
    public interface IEmployeeServiceAppService : IAsyncCrudAppService<EmployeeServiceDto,Guid,PagedEmployeeServiceResultRequestDto,CreateEmployeeServiceDto,EmployeeServiceDto>
    {
        
    }
}