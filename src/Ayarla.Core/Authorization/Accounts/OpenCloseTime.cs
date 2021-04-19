using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    public class OpenCloseTime : FullAuditedEntity<Guid>
    {



        public Guid AccountId { get; set; }

        public string DayOfTheWeek { get; set; }

        public TimeSpan AccountWorkStartTime { get; set; }

        public TimeSpan AccountWorkEndTime { get; set; }
    }
}
