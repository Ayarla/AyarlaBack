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
    [AutoMapFrom(typeof(EmployeeService))]
    public class EmployeeServiceDto : FullAuditedEntityDto<Guid>
    {
        public string Service { get; set; }

        public decimal Price { get; set; }

        public int ServiceTime { get; set; }
    }
}
