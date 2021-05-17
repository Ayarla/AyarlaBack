using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaAccounts.Dto
{
    [AutoMapFrom(typeof(OpenCloseTime))]
    public class OpenCloseTimeDto :EntityDto<Guid>
    {
        
        public Guid AccountId { get; set; }

        public string DayOfTheWeek { get; set; }

        public TimeSpan AccountWorkStartTime { get; set; }

        public TimeSpan AccountWorkEndTime { get; set; }
    }
}
