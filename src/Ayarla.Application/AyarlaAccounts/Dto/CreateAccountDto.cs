using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Ayarla.Authorization.Accounts;

namespace Ayarla.AyarlaAccounts.Dto
{
    [AutoMapTo(typeof(Account))]
    public class CreateAccountDto : IShouldNormalize
    {
        
        
        
        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string Email { get; set; }
        
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