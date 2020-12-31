using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaUsersService
{
    public interface IAyarlaUsersAppService : IAsyncCrudAppService<AyarlaUsersDto,Guid,AyarlaFavoriteDto,AyarlaCommentDto,AyarlaUsersDto>
    {
    }
}
