using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Ayarla.Authorization;
using Ayarla.Authorization.Accounts;

namespace Ayarla.Users.Dto
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    
    public class AppoinmentAppService : AsyncCrudAppService<Appoinment,AppoinmentDto,Guid,PagedAppoinmentResultRequestDto,CreateAppoinmentDto,AppoinmentDto>,IAppoinmentAppService
    {
        private readonly IAbpSession _abpSession;
        private readonly IRepository<Employee, Guid> _employeeRepository;
        
        public AppoinmentAppService(
            IRepository<Appoinment, Guid> repository,
            IAbpSession abpSession,
            IRepository<Employee,Guid> employeeRepository) 
            : base(repository)
        {
            _abpSession = abpSession;
            _employeeRepository = employeeRepository;
        }
        
        public override async Task<AppoinmentDto> CreateAsync(CreateAppoinmentDto input)
        {
            CheckCreatePermission();

            var appoinment = ObjectMapper.Map<Appoinment>(input);
            
            AppoinmentDto.UserId = AbpSession.UserId;

            var employee = await _employeeRepository.GetAsync(input.EmployeeId);

            await Repository.InsertAsync(appoinment);
            
            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<AppoinmentDto>(appoinment);

        }
    }
}