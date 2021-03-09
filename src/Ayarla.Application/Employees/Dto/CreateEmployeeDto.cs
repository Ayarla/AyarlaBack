using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Ayarla.Authorization.Accounts;

namespace Ayarla.Services.Dto
{
    [AutoMapTo(typeof(Employee))]
    
    public class CreateEmployeeDto : IShouldNormalize
    {
        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(AbpUserBase.MaxSurnameLength)]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmployeeMail{ get; set; }
        
        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }
        
        [Required]
        public string[] RoleNames { get; set; }
        
        public bool IsActive { get; set; }
        
        
        public void Normalize()
        {
            if (RoleNames == null)
            {
                RoleNames = new string[0];
            }
        }

        
    }
}