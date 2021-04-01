using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Users
{
    
    public class Comment : FullAuditedEntity<Guid>
    {
        

        public static long? UserId { get; set; }

        public string UserComment { get; set; }

        public Guid AccountId { get; set; }

        public int Rating { get; set; }
    }
}
