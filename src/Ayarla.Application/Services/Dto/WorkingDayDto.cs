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
    [AutoMapFrom(typeof(WorkingDay))]
    public class WorkingDayDto : FullAuditedEntityDto<Guid>
    {
        public string Days { get; set; }
    }
}
