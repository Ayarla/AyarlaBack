using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    
    public class Appoinment : FullAuditedEntity<Guid>
    {
        public List<EmployeeService> Services { get; set; }

        public Guid EmployeeId { get; set; }
        
        public Guid AccountId { get; set; }
        public long? UserId { get; set; }

        public DateTime DayTime { get; set; }
        
        public decimal TotalPrice { get; set; }
    }
}
