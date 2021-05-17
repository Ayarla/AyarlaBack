using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Ayarla.Authorization.Accounts;
using Ayarla.EmployeeServices.Dto;
using Ayarla.Services.Dto;

namespace Ayarla.EmployeeServices
{
    public class EmployeeServiceAppService : AsyncCrudAppService<EmployeeService,EmployeeServiceDto,Guid,PagedEmployeeServiceResultRequestDto,CreateEmployeeServiceDto,EmployeeServiceDto>,IEmployeeServiceAppService
    {
        private readonly IRepository<Employee, Guid> _employeeRepository;
        
        public EmployeeServiceAppService(
            IRepository<EmployeeService, Guid> repository,
            IRepository<Employee,Guid> employeeRepository) 
            : base(repository)
        {
            _employeeRepository = employeeRepository;
        }

        public override async Task<EmployeeServiceDto> CreateAsync(CreateEmployeeServiceDto input)
        {
            CheckCreatePermission();

            var employeeservice = ObjectMapper.Map<EmployeeService>(input);

            await _employeeRepository.GetAsync(input.EmployeeId);

            await Repository.InsertAsync(employeeservice);
            
            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<EmployeeServiceDto>(employeeservice);



        }
    }
}