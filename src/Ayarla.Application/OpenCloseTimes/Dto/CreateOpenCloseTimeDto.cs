using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Ayarla.Authorization.Accounts;

namespace Ayarla.AyarlaAccounts.Dto
{
    [AutoMapTo(typeof(OpenCloseTime))]
    
    public class CreateOpenCloseTimeDto 
    {
        public Guid AccountId { get; set; }

        public string DayOfTheWeek { get; set; }

        public TimeSpan AccountWorkStartTime { get; set; }

        public TimeSpan AccountWorkEndTime { get; set; }
    }
}