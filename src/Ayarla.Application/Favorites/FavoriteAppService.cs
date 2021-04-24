using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Ayarla.Authorization;
using Ayarla.Authorization.Accounts;
using Ayarla.Authorization.Users;
using Ayarla.AyarlaUsersService;
using Ayarla.Favorites.Dto;
using Ayarla.Users.Dto;

namespace Ayarla.Favorites
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    
    public class FavoriteAppService : AsyncCrudAppService<Favorite,FavoriteDto,Guid,PagedFavoriteResultRequestDto,CreateFavoriteDto,FavoriteDto>,IFavoriteAppService
    {
        
        private readonly IRepository<Account,Guid> _accountRepository;
        
        public FavoriteAppService(
            IRepository<Favorite, Guid> favoriteRepository,
            IRepository<Account,Guid> accountRepository) 
            : base(favoriteRepository)
        {
            
            _accountRepository = accountRepository;
        }
        
        
        public override async Task<FavoriteDto> CreateAsync(CreateFavoriteDto input)
        {
            var favorite = ObjectMapper.Map<Favorite>(input);

            favorite.UserId = AbpSession.UserId;
            
            await _accountRepository.GetAsync(input.AccountId);
            
            await Repository.InsertAsync(favorite);
            
            CurrentUnitOfWork.SaveChanges();
            
            return ObjectMapper.Map<FavoriteDto>(favorite);

        }
    }
}