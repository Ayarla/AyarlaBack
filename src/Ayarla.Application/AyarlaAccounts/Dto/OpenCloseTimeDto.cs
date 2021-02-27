using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaAccounts.Dto
{
    [AutoMapFrom(typeof(OpenCloseTime))]
    public class OpenCloseTimeDto : FullAuditedEntityDto<Guid>
    {
        public int AcountId { get; set; }

        public string DayOfTheWeek { get; set; }

        public TimeSpan AccountWorkStartTime { get; set; }

        public TimeSpan AccountWorkEndTime { get; set; }
    }
}
