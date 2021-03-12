using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AutomaticAcceptanceTest.Authorization;

namespace AutomaticAcceptanceTest
{
    [DependsOn(
        typeof(AutomaticAcceptanceTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AutomaticAcceptanceTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AutomaticAcceptanceTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AutomaticAcceptanceTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
