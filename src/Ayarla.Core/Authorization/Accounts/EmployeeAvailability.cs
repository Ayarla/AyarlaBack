using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    
    public class EmployeeAvailability : FullAuditedEntity<Guid>
    {
        

        public Boolean Availability { get; set; }
    }
}
