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
        

        public int UserId { get; set; }

        public string UserComment { get; set; }

        public int AccountId { get; set; }

        public int Rating { get; set; }
    }
}
