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
    [AutoMapFrom(typeof(EmployeeAvailability))]
    public class EmployeeAvailabilityDto : FullAuditedEntityDto<Guid>
    {
        public bool Availability { get; set; }
    }
}
