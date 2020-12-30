using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    public class AyarlaEmployeeAvailability : FullAuditedEntity<Guid>
    {
        public int Id { get; set; }

        public string Availability { get; set; }
    }
}
