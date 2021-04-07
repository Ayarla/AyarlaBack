using System;
using Abp.Application.Services;
using Ayarla.AyarlaUsersService;
using Ayarla.Favorites.Dto;
using Ayarla.Users.Dto;

namespace Ayarla.Favorites
{
    public interface IFavoriteAppService : IAsyncCrudAppService<FavoriteDto,Guid,PagedFavoriteResultRequestDto,CreateFavoriteDto,FavoriteDto>
    {
        
    }
}