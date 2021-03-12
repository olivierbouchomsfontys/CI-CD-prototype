using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AutomaticAcceptanceTest.EntityFrameworkCore
{
    public static class AutomaticAcceptanceTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AutomaticAcceptanceTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AutomaticAcceptanceTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
