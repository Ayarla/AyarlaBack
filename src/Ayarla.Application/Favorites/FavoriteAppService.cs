using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Ayarla.Authorization;
using Ayarla.Authorization.Accounts;
using Ayarla.Authorization.Users;
using Ayarla.AyarlaUsersService;
using Ayarla.Favorites.Dto;
using Ayarla.Users.Dto;
using Microsoft.EntityFrameworkCore;

namespace Ayarla.Favorites
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    
    public class FavoriteAppService : AsyncCrudAppService<Favorite,FavoriteDto,Guid,PagedFavoriteResultRequestDto,CreateFavoriteDto,FavoriteDto>,IFavoriteAppService
    {
        
        private readonly IRepository<Account,Guid> _accountRepository;
        private readonly IRepository<User, long> _userRepository;
        
        public FavoriteAppService(
            IRepository<Favorite, Guid> favoriteRepository,
            IRepository<Account,Guid> accountRepository,
            IRepository<User,long> userRepository) 
            : base(favoriteRepository)
        {
            _userRepository = userRepository;
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

        public async Task<PagedResultDto<FavoriteDto>> GetAllFavorite(PagedFavoriteResultRequestDto input)
        {
 
            var favoriteQuery = Repository.GetAll()
                .Where(o => o.UserId == AbpSession.UserId);

            var favorite = await favoriteQuery.PageBy(input).ToListAsync();

            return new PagedResultDto<FavoriteDto>(favoriteQuery.Count(),
                ObjectMapper.Map<List<FavoriteDto>>(favorite));
        }
    }
}