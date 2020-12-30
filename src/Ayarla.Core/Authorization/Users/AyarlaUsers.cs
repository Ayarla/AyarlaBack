using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Users
{
    public class AyarlaUsers : FullAuditedEntity<Guid>
    {
        public int Id { get; set; }

        public string Gsm { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int favoriteId { get; set; }

        public int appoinmentId { get; set; }
    }
}
