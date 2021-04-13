using Abp.Domain.Entities.Auditing;
using Ayarla.Authorization.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Ayarla.Shared.Enums;

namespace Ayarla.Authorization.Accounts
{
    
    public class Account : FullAuditedEntity<Guid>
    {
        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Phone3 { get; set; }
        public string Address { get { return AddressDetail + "," + District + "/" + City; } }

        public string AccountName { get; set; }

        public string AccountImage { get; set; }

        public Gender Gender { get; set; }

        public string AccountNotes { get; set; }

        public string AddressDetail { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public Guid CommentId { get; set; }
        
        [ForeignKey(nameof(OpenCloseTime))]
        public Guid OpenCloseTimeId { get; set; }

        public string Location { get; set; }

        public int TimePeriod { get; set; }
    
    }
}
