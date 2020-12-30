using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    public class AyarlaAccount : FullAuditedEntity<Guid>
    {
        public int Id { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Phone3 { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string OpenAddress { get; set; }

        public string BusinessName { get; set; }

        public string BusinessImage { get; set; }

        public int businessTypeId { get; set; }

        public string AccountNotes { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public int OpenCloseTime { get; set; }

        public int commentId { get; set; }

        public string Location { get; set; }

        public int TimePeriod { get; set; }
    }
}
