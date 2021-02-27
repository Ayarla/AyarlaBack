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
        

        public int ServiceId { get; set; }

        public int EmployeeId { get; set; }

        public int UserId { get; set; }

        public DateTime DayTime { get; set; }
    }
}
