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
    
    public class ServiceType : FullAuditedEntity<Guid>
    {
        public TypeService Type { get; set; }
    }
}
