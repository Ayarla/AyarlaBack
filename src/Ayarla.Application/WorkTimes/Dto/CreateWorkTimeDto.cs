using System;
using Ayarla.Shared.Enums;

namespace Ayarla.Services.Dto
{
    public class CreateWorkTimeDto
    {
        public Guid EmployeeId { get; set; }

        public Days WorkingDays { get; set; }

        public TimeSpan EmployeeWorkStartTime { get; set; }

        public TimeSpan EmployeeWorkEndTime { get; set; }
    }
}