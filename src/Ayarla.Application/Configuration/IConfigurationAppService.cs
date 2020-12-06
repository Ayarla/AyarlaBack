using System.Threading.Tasks;
using Ayarla.Configuration.Dto;

namespace Ayarla.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
