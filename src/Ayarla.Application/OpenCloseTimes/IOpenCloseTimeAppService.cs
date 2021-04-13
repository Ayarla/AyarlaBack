using System;
using Abp.Application.Services;
using Ayarla.AyarlaAccounts.Dto;
using Ayarla.Services.Dto;
using OpenCloseTimeDto = Ayarla.AyarlaAccounts.Dto.OpenCloseTimeDto;

namespace Ayarla.OpenCloseTimes
{
    public interface IOpenCloseTimeAppService : IAsyncCrudAppService<OpenCloseTimeDto,Guid,PagedOpenClosedTimeResultRequestDto,CreateOpenCloseTimeDto,OpenCloseTimeDto>
    {
        
    }
}