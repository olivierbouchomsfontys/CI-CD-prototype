using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AutomaticAcceptanceTest.Configuration;

namespace AutomaticAcceptanceTest.Web.Host.Startup
{
    [DependsOn(
       typeof(AutomaticAcceptanceTestWebCoreModule))]
    public class AutomaticAcceptanceTestWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AutomaticAcceptanceTestWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AutomaticAcceptanceTestWebHostModule).GetAssembly());
        }
    }
}
