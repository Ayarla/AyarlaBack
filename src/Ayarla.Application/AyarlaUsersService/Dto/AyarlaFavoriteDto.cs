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
    [AutoMapFrom(typeof(AyarlaFavorite))]
    public class AyarlaFavoriteDto : FullAuditedEntityDto<Guid>
    {
        public int accountId { get; set; }
        public int userId { get; set; }

    }
}
