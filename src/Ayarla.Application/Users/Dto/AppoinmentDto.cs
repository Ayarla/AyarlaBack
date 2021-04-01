using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Users.Dto
{
    [AutoMapFrom(typeof(Appoinment))]
    public class AppoinmentDto : FullAuditedEntityDto<Guid>
    {
        

        public Guid EmployeeId { get; set; }

        public static long? UserId { get; set; }

        public DateTime DayTime { get; set; }
        
        public Guid ServiceId { get; set; }
    }
}
