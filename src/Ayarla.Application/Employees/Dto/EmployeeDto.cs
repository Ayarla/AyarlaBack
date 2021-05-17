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

        public Guid AvailabilityId { get; set; }

        public string EmployeeImage { get; set; }
        
        public virtual ICollection<EmployeeService> EmployeeServices{ get; set; }

        public string Notes { get; set; }

        public Guid DateId { get; set; }

        public Gender Gender { get; set; }

        public virtual ICollection<WorkTime> WorkTimes { get; set; }
    }
}
