using System;
using Abp.Application.Services;

namespace Ayarla.Users.Dto
{
    public interface IAppoinmentAppService : IAsyncCrudAppService<AppoinmentDto,Guid,PagedAppoinmentResultRequestDto,CreateAppoinmentDto,AppoinmentDto>
    {
        
    }
}