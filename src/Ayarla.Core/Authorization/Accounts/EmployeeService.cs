using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    public class EmployeeService : FullAuditedEntity<Guid>
    {
        

        public string Service { get; set; }

        public int Price { get; set; }

        public int Time { get; set; }

        public int TypeId { get; set; }
    }
}
