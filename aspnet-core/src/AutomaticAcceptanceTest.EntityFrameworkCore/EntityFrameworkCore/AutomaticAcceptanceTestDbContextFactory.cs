using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AutomaticAcceptanceTest.Configuration;
using AutomaticAcceptanceTest.Web;

namespace AutomaticAcceptanceTest.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AutomaticAcceptanceTestDbContextFactory : IDesignTimeDbContextFactory<AutomaticAcceptanceTestDbContext>
    {
        public AutomaticAcceptanceTestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AutomaticAcceptanceTestDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AutomaticAcceptanceTestDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AutomaticAcceptanceTestConsts.ConnectionStringName));

            return new AutomaticAcceptanceTestDbContext(builder.Options);
        }
    }
}
