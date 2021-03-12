using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AutomaticAcceptanceTest.Configuration;
using AutomaticAcceptanceTest.EntityFrameworkCore;
using AutomaticAcceptanceTest.Migrator.DependencyInjection;

namespace AutomaticAcceptanceTest.Migrator
{
    [DependsOn(typeof(AutomaticAcceptanceTestEntityFrameworkModule))]
    public class AutomaticAcceptanceTestMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AutomaticAcceptanceTestMigratorModule(AutomaticAcceptanceTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AutomaticAcceptanceTestMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AutomaticAcceptanceTestConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AutomaticAcceptanceTestMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
