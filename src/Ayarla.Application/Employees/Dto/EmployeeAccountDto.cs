using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Services.Dto
{
    [AutoMapFrom(typeof(EmployeeAccount))]
    public class EmployeeAccountDto : FullAuditedEntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }

        public Guid AccountId { get; set; }
    }
}
