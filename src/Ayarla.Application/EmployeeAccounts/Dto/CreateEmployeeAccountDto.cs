using System;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;

namespace Ayarla.Services.Dto
{
    [AutoMapTo(typeof(EmployeeAccount))]
    public class CreateEmployeeAccountDto
    {
        public Guid EmployeeId { get; set; }

        public Guid AccountId { get; set; }
        
    }
}