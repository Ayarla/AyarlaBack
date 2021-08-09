using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using Ayarla.Shared.Enums;

namespace Ayarla.Services.Dto
{
    [AutoMapTo(typeof(Employee))]
    public class CreateEmployeeDto
    {
        public long? UserId { get; set; }
        
        public string Gsm { get; set; }

        public string EmployeeImage { get; set; }

        public string Notes { get; set; }

        public Gender Gender { get; set; }

       
    }
}