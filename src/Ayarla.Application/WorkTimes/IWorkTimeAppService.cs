using System;
using Abp.Application.Services;
using Ayarla.Services.Dto;

namespace Ayarla.WorkTimes
{
    public interface IWorkTimeAppService: IAsyncCrudAppService<WorkTimeDto,Guid,PagedWorkTimeResultRequestDto,CreateWorkTimeDto,WorkTimeDto>
    {
        
    }
}