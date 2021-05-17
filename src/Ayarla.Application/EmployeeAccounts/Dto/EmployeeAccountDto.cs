using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;

namespace Ayarla.EmployeeAccounts.Dto
{
    [AutoMapFrom(typeof(EmployeeAccount))]
    public class EmployeeAccountDto : EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }

        public Guid AccountId { get; set; }
    }
}
