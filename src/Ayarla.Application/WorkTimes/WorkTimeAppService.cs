using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Ayarla.Authorization.Accounts;
using Ayarla.Services.Dto;
using Ayarla.WorkTimes.Dto;

namespace Ayarla.WorkTimes
{
    public class WorkTimeAppService: AsyncCrudAppService<WorkTime,WorkTimeDto,Guid,PagedWorkTimeResultRequestDto,CreateWorkTimeDto,WorkTimeDto>,IWorkTimeAppService
    {
        private readonly IRepository<Employee, Guid> _employeeRepository;
        
        public WorkTimeAppService(
            IRepository<WorkTime, Guid> worktimeRepository,
            IRepository<Employee,Guid> employeeRepository) 
            : base(worktimeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public override async Task<WorkTimeDto> CreateAsync(CreateWorkTimeDto input)
        {
            CheckCreatePermission();

            var worktime = ObjectMapper.Map<WorkTime>(input);

            await _employeeRepository.GetAsync(input.EmployeeId);

            await Repository.InsertAsync(worktime);
            
            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<WorkTimeDto>(worktime);
        }
    }
}