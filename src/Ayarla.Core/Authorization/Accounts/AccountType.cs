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
    
    public class AccountType : FullAuditedEntity<Guid>
    {
        
        public Gender Gender { get; set; }
    }
}
