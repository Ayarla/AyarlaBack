using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    public class AyarlaAppoinment : FullAuditedEntity<Guid>
    {
        public int Id { get; set; }

        public int serviceId { get; set; }

        public int employeeId { get; set; }

        public int userId { get; set; }

        public string Day { get; set; }

        public string Time { get; set; }
    }
}
