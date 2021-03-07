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
    public class UserAppoinmentDto : FullAuditedEntityDto<Guid>
    {
        

        public int EmployeeId { get; set; }

        public int UserId { get; set; }

        public string Day { get; set; }

        public string Time { get; set; }
    }
}
