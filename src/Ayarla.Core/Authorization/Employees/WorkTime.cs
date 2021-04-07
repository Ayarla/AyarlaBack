using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    public class WorkTime : FullAuditedEntity<Guid>
    {
        public Guid AccountId { get; set; }

        public string DayOfTheWeek { get; set; }

        public TimeSpan EmployeeWorkStartTime { get; set; }

        public TimeSpan EmployeeWorkEndTime { get; set; }
    }
}
