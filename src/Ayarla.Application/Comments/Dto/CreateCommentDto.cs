using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Ayarla.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaUsersService
{
    [AutoMapTo(typeof(Comment))]
    
    public class CreateCommentDto : FullAuditedEntity<Guid>
    {
        
        
        public string Comment { get; set; }
        public Guid AccountId { get; set; }
        
        public int Rating { get; set; }
    }
}
