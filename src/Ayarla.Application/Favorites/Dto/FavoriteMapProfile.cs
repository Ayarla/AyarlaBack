using AutoMapper;
using Ayarla.Authorization.Users;

namespace Ayarla.Favorites.Dto
{
    public class FavoriteMapProfile : Profile
    {
        public FavoriteMapProfile()
        {
            CreateMap<FavoriteDto, Favorite>();
            CreateMap<Favorite, FavoriteDto>();
        }
    }
}