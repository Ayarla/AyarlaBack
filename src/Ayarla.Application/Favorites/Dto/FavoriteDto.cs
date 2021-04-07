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
    [AutoMapFrom(typeof(Favorite))]
    public class FavoriteDto : FullAuditedEntityDto<Guid>
    {
        public Guid AccountId { get; set; }
        
        public long? UserId { get; set; }

    }
}
