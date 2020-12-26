using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    public class Appoinment
    {
        public int Id { get; set; }

        public int ServiceId { get; set; }

        public int EmployeeId { get; set; }

        public int UserId { get; set; }

        public string Day { get; set; }

        public string Time { get; set; }

    }
}
