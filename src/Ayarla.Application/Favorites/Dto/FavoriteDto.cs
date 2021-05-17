using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Users;

namespace Ayarla.Favorites.Dto
{
    [AutoMapFrom(typeof(Favorite))]
    public class FavoriteDto : EntityDto<Guid>
    {
        public Guid AccountId { get; set; }
        
        public long? UserId { get; set; }

    }
}
