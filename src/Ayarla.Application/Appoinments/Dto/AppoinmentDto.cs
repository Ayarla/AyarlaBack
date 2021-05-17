using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;

namespace Ayarla.Appoinments.Dto
{
    [AutoMapFrom(typeof(Appoinment))]
    public class AppoinmentDto : FullAuditedEntityDto<Guid>
    {
        

        public Guid EmployeeId { get; set; }

        public long? UserId { get; set; }

        public DateTime DayTime { get; set; }
        
        public Guid ServiceId { get; set; }
    }
}
