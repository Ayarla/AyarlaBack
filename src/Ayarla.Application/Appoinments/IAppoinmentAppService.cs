using System;
using Abp.Application.Services;
using Ayarla.Appoinments.Dto;

namespace Ayarla.Users.Dto
{
    public interface IAppoinmentAppService : IAsyncCrudAppService<AppoinmentDto,Guid,PagedAppoinmentResultRequestDto,CreateAppoinmentDto,AppoinmentDto>
    {
        
    }
}