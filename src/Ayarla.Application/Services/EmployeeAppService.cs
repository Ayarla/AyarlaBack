using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Ayarla.Authorization;
using Ayarla.Authorization.Accounts;
using Ayarla.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Services
{
    [AbpAuthorize(PermissionNames.Pages_Employee)]
    public class EmployeeAppService : AsyncCrudAppService<Employee, EmployeeDto, Guid>, IEmployeeAppService
    {
        public EmployeeAppService(IRepository<Employee, Guid> repository) : base(repository)
        {
        }
    }
}
