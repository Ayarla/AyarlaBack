using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Domain.AccountModels
{
    public class EmployeeAccount
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int AcoountId { get; set; }

        public int AuthorizationId { get; set; }

    }
}
