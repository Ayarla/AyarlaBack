using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Users
{
    public class Favorite : FullAuditedEntity<Guid>
    {
        

        public int AccountId { get; set; }

        public int UserId { get; set; }
    }
}
