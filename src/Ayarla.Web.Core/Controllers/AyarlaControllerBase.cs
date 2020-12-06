using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Ayarla.Controllers
{
    public abstract class AyarlaControllerBase: AbpController
    {
        protected AyarlaControllerBase()
        {
            LocalizationSourceName = AyarlaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
