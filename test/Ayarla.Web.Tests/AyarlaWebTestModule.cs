using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ayarla.EntityFrameworkCore;
using Ayarla.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Ayarla.Web.Tests
{
    [DependsOn(
        typeof(AyarlaWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AyarlaWebTestModule : AbpModule
    {
        public AyarlaWebTestModule(AyarlaEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AyarlaWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AyarlaWebMvcModule).Assembly);
        }
    }
}