using System;
using Abp.Application.Services;
using Ayarla.Services.Dto;
using Ayarla.WorkTimes.Dto;

namespace Ayarla.WorkTimes
{
    public interface IWorkTimeAppService: IAsyncCrudAppService<WorkTimeDto,Guid,PagedWorkTimeResultRequestDto,CreateWorkTimeDto,WorkTimeDto>
    {
        
    }
}