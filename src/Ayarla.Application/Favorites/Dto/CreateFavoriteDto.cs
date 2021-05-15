using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Users;

namespace Ayarla.Users.Dto
{
    [AutoMapTo(typeof(Favorite))]
    public class CreateFavoriteDto
    {
        public Guid AccountId { get; set; }
    }
}