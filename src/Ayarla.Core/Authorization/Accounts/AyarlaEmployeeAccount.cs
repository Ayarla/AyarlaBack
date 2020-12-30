using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    public class AyarlaEmployeeAccount : FullAuditedEntity<Guid>
    {
        public int Id { get; set; }

        public int employeeId { get; set; }

        public int acoountId { get; set; }

        public int authorizationId { get; set; }
    }
}
