using Abp.Domain.Entities.Auditing;
using Ayarla.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    
    public class EmployeeService : FullAuditedEntity<Guid>
    {
        public Guid EmployeeId { get; set; }

        public string ServiceName { get; set; }

        public decimal Price { get; set; }

        public int ServiceTime { get; set; }

        public TypeService ServiceType { get; set; }

        public DateTime DateTime { get; set; }
    }
}
