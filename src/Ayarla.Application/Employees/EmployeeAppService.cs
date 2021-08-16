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
using Abp;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Ayarla.Services
{
    [AbpAuthorize(PermissionNames.Pages_Employee)]
    public class EmployeeAppService : AsyncCrudAppService<Employee, EmployeeDto, Guid,PagedEmployeeResultRequestDto,CreateEmployeeDto,EmployeeDto>, IEmployeeAppService
    {
        public EmployeeAppService(IRepository<Employee, Guid> employeeRepository) : base(employeeRepository)
        {
        }


        public override async Task<EmployeeDto> CreateAsync(CreateEmployeeDto input)
        {
           CheckCreatePermission();

           var employee = ObjectMapper.Map<Employee>(input);

           employee.Id = SequentialGuidGenerator.Instance.Create();

           employee.UserId = AbpSession.UserId;
           
           await Repository.InsertAndGetIdAsync(employee);
           
           CurrentUnitOfWork.SaveChanges();

           return ObjectMapper.Map<EmployeeDto>(employee);
        }

        public async Task<PagedResultDto<EmployeeDto>> GetAllEmployees(PagedEmployeeResultRequestDto input)
        {
            var employeeQuery = Repository.GetAll()
                .Include(o => o.EmployeeServices)
                .Include(o => o.WorkTimes);

                var employees = await employeeQuery.PageBy(input).ToListAsync();

            return new PagedResultDto<EmployeeDto>(employeeQuery.Count(),
                ObjectMapper.Map<List<EmployeeDto>>(employees));
        }

        /*
        public async Task<PagedResultDto<EmployeeDto>> GetAllAsync(PagedEmployeeResultRequestDto input)
        {
            var employeeQuery = Repository.GetAll()
                .Include(o => o.EmployeeServices)
                .Include(o => o.WorkTimes);

            var employees = await employeeQuery.PageBy(input).ToListAsync();

            return new PagedResultDto<EmployeeDto>(employeeQuery.Count(),
                ObjectMapper.Map<List<EmployeeDto>>(employees));
        }*/
    }
}
