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
        public int AcountId { get; set; }

        public string DayOfTheWeek { get; set; }

        public string WorkStartTime { get; set; }

        public string WorkEndTime { get; set; }
    }
}
