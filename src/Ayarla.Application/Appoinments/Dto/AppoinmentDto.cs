using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using Ayarla.EmployeeServices.Dto;

namespace Ayarla.Appoinments.Dto
{
    [AutoMapFrom(typeof(Appoinment))]
    public class AppoinmentDto : EntityDto<Guid>
    {
        
        public Guid AccountId { get; set; }
        
        public Guid EmployeeId { get; set; }

        public long? UserId { get; set; }

        public DateTime DayTime { get; set; }
        
        public List<EmployeeServiceDto> Services { get; set; }
        
        public decimal TotalPrice { get; set; }
    }
}
