using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ayarla.Shared.Enums;

namespace Ayarla.Authorization.Accounts
{
    public class OpenCloseTime : FullAuditedEntity<Guid>
    {

        public Guid AccountId { get; set; }

        public Days Days { get; set; }

        public TimeSpan AccountWorkStartTime { get; set; }

        public TimeSpan AccountWorkEndTime { get; set; }
    }
}
