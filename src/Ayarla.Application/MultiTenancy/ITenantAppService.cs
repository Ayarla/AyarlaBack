using Abp.Application.Services;
using Ayarla.MultiTenancy.Dto;

namespace Ayarla.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

