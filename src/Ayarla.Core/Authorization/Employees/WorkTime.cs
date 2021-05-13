using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ayarla.Shared.Enums;

namespace Ayarla.Authorization.Accounts
{
    public class WorkTime : FullAuditedEntity<Guid>
    {
        public Guid EmployeeId { get; set; }

        public Days Days { get; set; }

        public TimeSpan EmployeeWorkStartTime { get; set; }

        public TimeSpan EmployeeWorkEndTime { get; set; }
    }
}
