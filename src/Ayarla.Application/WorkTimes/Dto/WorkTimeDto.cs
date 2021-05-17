using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using Ayarla.Shared.Enums;

namespace Ayarla.WorkTimes.Dto
{
    [AutoMapFrom(typeof(WorkTime))]
    public class WorkTimeDto : EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }

        public Days WorkingDays { get; set; }

        public TimeSpan EmployeeWorkStartTime { get; set; }

        public TimeSpan EmployeeWorkEndTime { get; set; }
    }
}
