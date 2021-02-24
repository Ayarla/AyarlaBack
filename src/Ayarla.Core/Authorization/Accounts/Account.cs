using Abp.Domain.Entities.Auditing;
using Ayarla.Authorization.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    
    public class Account : FullAuditedEntity<Guid>
    {
        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Phone3 { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get { return AddressDetail + "," + District + "/" + City; } }

        public string AccountName { get; set; }

        public string AccountImage { get; set; }

        public int AccountTypeId { get; set; }

        public string AccountNotes { get; set; }

        public string AddressDetail { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public int CommentId { get; set; }

        public int OpenCloseTimeId { get; set; }

        public string Location { get; set; }

        public int TimePeriod { get; set; }
    
    }
}
