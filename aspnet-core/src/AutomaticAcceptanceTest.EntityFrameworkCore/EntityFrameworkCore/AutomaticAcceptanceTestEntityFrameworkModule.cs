using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using AutomaticAcceptanceTest.EntityFrameworkCore.Seed;

namespace AutomaticAcceptanceTest.EntityFrameworkCore
{
    [DependsOn(
        typeof(AutomaticAcceptanceTestCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class AutomaticAcceptanceTestEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<AutomaticAcceptanceTestDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        AutomaticAcceptanceTestDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        AutomaticAcceptanceTestDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AutomaticAcceptanceTestEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
