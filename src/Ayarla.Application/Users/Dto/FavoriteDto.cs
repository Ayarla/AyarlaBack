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
        public int AccountId { get; set; }
        public int UserId { get; set; }

    }
}
