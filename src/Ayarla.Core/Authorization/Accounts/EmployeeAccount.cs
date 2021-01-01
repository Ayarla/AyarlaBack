using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    public class EmployeeAccount : FullAuditedEntity<Guid>
    {
        

        public int EmployeeId { get; set; }

        public int AccountId { get; set; }

    }
}
