using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using Ayarla.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaAccounts.Dto
{
    [AutoMapFrom(typeof(AccountType))]
    public class AccountTypeDto 
    {
        public Gender Gender { get; set; }
    }
}
