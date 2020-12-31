using Abp.Application.Services;
using Abp.Domain.Repositories;
using Ayarla.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaUsersService
{
    public class AyarlaUsersAppService : AsyncCrudAppService<AyarlaUsers, AyarlaUsersDto, Guid, AyarlaFavoriteDto, AyarlaCommentDto, AyarlaUsersDto>, IAyarlaUsersAppService
    {
        public AyarlaUsersAppService(IRepository<AyarlaUsers, Guid> repository) : base(repository)
        {
        }
    }
}
