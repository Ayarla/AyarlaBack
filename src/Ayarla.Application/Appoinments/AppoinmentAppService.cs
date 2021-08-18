using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Ayarla.Appoinments.Dto;
using Ayarla.Authorization;
using Ayarla.Authorization.Accounts;
using Ayarla.Users.Dto;
using Microsoft.EntityFrameworkCore;

namespace Ayarla.Appoinments
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    
    public class AppoinmentAppService : AsyncCrudAppService<Appoinment,AppoinmentDto,Guid,PagedAppoinmentResultRequestDto,CreateAppoinmentDto,AppoinmentDto>,IAppoinmentAppService
    {
        
        private readonly IRepository<Employee, Guid> _employeeRepository;
        private readonly IRepository<EmployeeService, Guid> _employeeServicesRepository;
        
        public AppoinmentAppService(
            IRepository<Appoinment, Guid> appoinmentRepository,
            IRepository<Employee,Guid> employeeRepository,
            IRepository<EmployeeService,Guid> employeeServicesRepository) 
            : base(appoinmentRepository)
        {
           
            _employeeRepository = employeeRepository;
            _employeeServicesRepository = employeeServicesRepository;
        }
        
        public override async Task<AppoinmentDto> CreateAsync(CreateAppoinmentDto input)
        {
            CheckCreatePermission();

            var appoinment = ObjectMapper.Map<Appoinment>(input);
            
            appoinment.UserId = AbpSession.UserId;

            await _employeeRepository.GetAsync(input.EmployeeId);

            /*
            _employeeServicesRepository.GetAll()
                .GroupBy(o => o.EmployeeId)
                .Select(t => new
                {
                    TotalPrice = t.Sum(ta => ta.Price),
                    Services = t.ToList()
                });
                */
            
            
                
            appoinment.Services =_employeeServicesRepository.GetAll()
                .Where(o => o.EmployeeId == input.EmployeeId).ToList();
            
            appoinment.TotalPrice = _employeeServicesRepository.GetAll()
                .Where(o => o.EmployeeId == input.EmployeeId).Select(o => o.Price).Sum();
                
                


            await Repository.InsertAsync(appoinment);
            
            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<AppoinmentDto>(appoinment);

        }
/*
        public async Task<PagedResultDto<AppoinmentDto>> GetAllAppoinments(PagedAppoinmentResultRequestDto input)
        {

            var appoinmentQuery = Repository.GetAll()
                .Where(o => o.UserId == AbpSession.UserId);

            var appoinment = await appoinmentQuery.PageBy(input).ToListAsync();

            return new PagedResultDto<AppoinmentDto>(appoinmentQuery.Count(),
                ObjectMapper.Map<List<AppoinmentDto>>(appoinment));
        }
*/
        public override async Task<PagedResultDto<AppoinmentDto>> GetAllAsync(PagedAppoinmentResultRequestDto input)
        {
            var appoinmentQuery = Repository.GetAll()
                .Where(o => o.UserId == AbpSession.UserId);

            var appoinment = await appoinmentQuery.PageBy(input).ToListAsync();

            return new PagedResultDto<AppoinmentDto>(appoinmentQuery.Count(),
                ObjectMapper.Map<List<AppoinmentDto>>(appoinment));
        }

        public override async Task<AppoinmentDto> UpdateAsync(AppoinmentDto input)
        {
            var updatedappoinment = await Repository.UpdateAsync(ObjectMapper.Map<Appoinment>(input));
            
            CurrentUnitOfWork.SaveChanges();
            
            return ObjectMapper.Map<AppoinmentDto>(updatedappoinment);
        }

        public override async Task DeleteAsync(EntityDto<Guid> input)
        {
            CheckDeletePermission();
            
            var appoinment = await Repository.GetAsync(input.Id);

            await Repository.DeleteAsync(appoinment);
        }
    }
}