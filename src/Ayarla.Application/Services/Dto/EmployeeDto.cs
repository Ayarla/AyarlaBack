using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Services.Dto
{
    [AutoMapFrom(typeof(Employee))]
    public class EmployeeDto : FullAuditedEntityDto<Guid>
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string Gsm { get; set; }

        public string EmployeeImage { get; set; }

        public string Notes { get; set; }

        public enum Gender
        {
            Female = 1,
            Male = 2,
        }

        public ICollection<EmployeeAccountDto> EmployeeAccounts { get; set; }

        public ICollection<EmployeeAvailabilityDto> EmployeeAvailabilities { get; set; }

        public ICollection<EmployeeAppoinmentDto> EmployeeAppoinments { get; set; }

        public ICollection<EmployeeServiceDto> EmployeeServices { get; set; }

        public ICollection<ServiceTypeDto> ServiceTypes { get; set; }

        public ICollection<WorkingDayDto> WorkingDays { get; set; }

        public ICollection<WorkTimeDto> WorkTimes { get; set; }

    }
}
