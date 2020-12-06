using System.Threading.Tasks;
using Abp.Application.Services;
using Ayarla.Authorization.Accounts.Dto;

namespace Ayarla.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
