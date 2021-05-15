using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using Ayarla.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ayarla.Users.Dto;

namespace Ayarla.Services.Dto
{
    [AutoMapFrom(typeof(Employee))]
    public class EmployeeDto : EntityDto<Guid>
    {

        public string Gsm { get; set; }

        public string EmployeeImage { get; set; }

        public string Notes { get; set; }

        public Gender Gender { get; set; }

        public ICollection<EmployeeAccountDto> EmployeeAccounts { get; set; }

        public ICollection<EmployeeAvailabilityDto> EmployeeAvailabilities { get; set; }

        public ICollection<EmployeeServiceDto> EmployeeServices { get; set; }

        public ICollection<WorkingDayDto> WorkingDays { get; set; }

        public ICollection<WorkTimeDto> WorkTimes { get; set; }

    }
}
