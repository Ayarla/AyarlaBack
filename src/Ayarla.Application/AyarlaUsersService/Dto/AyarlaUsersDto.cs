using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaUsersService
{
    [AutoMapFrom(typeof(AyarlaUsers))]
    public class AyarlaUsersDto : FullAuditedEntityDto<Guid>
    {
        public string Gsm { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int favoriteId { get; set; }
        public int appoinmentId { get; set; }
    }
}
