using Abp.Domain.Entities.Auditing;
using System;
using Ayarla.Shared.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    
    public class Employee : FullAuditedEntity<Guid>
    {
        public string Gsm { get; set; }

        public Guid AvailabilityId { get; set; }

        public string EmployeeImage { get; set; }

        public virtual ICollection<EmployeeService> EmployeeServices{ get; set; }

        public string Notes { get; set; }

        public Guid DateId { get; set; }

        public Gender Gender { get; set; }

        public virtual ICollection<WorkTime> WorkTimes { get; set; }
    }
}
