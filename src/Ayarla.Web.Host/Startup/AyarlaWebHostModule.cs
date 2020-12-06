using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ayarla.Configuration;

namespace Ayarla.Web.Host.Startup
{
    [DependsOn(
       typeof(AyarlaWebCoreModule))]
    public class AyarlaWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AyarlaWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AyarlaWebHostModule).GetAssembly());
        }
    }
}
