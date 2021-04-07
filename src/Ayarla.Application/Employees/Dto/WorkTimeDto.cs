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
    [AutoMapFrom(typeof(WorkTime))]
    public class WorkTimeDto : FullAuditedEntityDto<Guid>
    {
        public Guid AccountId { get; set; }

        public string DayOfTheWeek { get; set; }

        public TimeSpan EmployeeWorkStartTime { get; set; }

        public TimeSpan EmployeeWorkEndTime { get; set; }
    }
}
