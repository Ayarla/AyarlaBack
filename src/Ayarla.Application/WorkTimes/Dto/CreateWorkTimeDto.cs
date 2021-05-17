using System;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using Ayarla.Shared.Enums;

namespace Ayarla.Services.Dto
{
    [AutoMapTo(typeof(WorkTime))]
    public class CreateWorkTimeDto
    {
        public Guid EmployeeId { get; set; }

        public Days WorkingDays { get; set; }

        public TimeSpan EmployeeWorkStartTime { get; set; }

        public TimeSpan EmployeeWorkEndTime { get; set; }
    }
}