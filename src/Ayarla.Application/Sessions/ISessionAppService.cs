using System.Threading.Tasks;
using Abp.Application.Services;
using Ayarla.Sessions.Dto;

namespace Ayarla.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
