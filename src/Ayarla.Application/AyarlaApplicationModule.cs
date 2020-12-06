using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ayarla.Authorization;

namespace Ayarla
{
    [DependsOn(
        typeof(AyarlaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AyarlaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AyarlaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AyarlaApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
