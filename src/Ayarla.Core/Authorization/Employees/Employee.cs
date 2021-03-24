using Abp.Domain.Entities.Auditing;
using System;
using Ayarla.Shared.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Accounts
{
    
    public class Employee : FullAuditedEntity<Guid>
    {
        

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string EmployeeMail{ get; set; }  

        public string Password { get; set; }

        public string Gsm { get; set; }

        public int AvailabilityId { get; set; }

        public string EmployeeImage { get; set; }

        public int WorkingDays { get; set; }

        public int ServiceId { get; set; }

        public string Notes { get; set; }

        public int DateId { get; set; }

        public Gender Gender { get; set; }

        public int AccountId { get; set; }

        public int AppoinmentId { get; set; }

        public int WorkTimeId { get; set; }
        
        public UserType UserType { get; set; }
    }
}
