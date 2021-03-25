using Abp.Domain.Entities.Auditing;
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
        

        public string Service { get; set; }

        public decimal Price { get; set; }

        public int ServiceTime { get; set; }

        public Guid TypeId { get; set; }
    }
}
