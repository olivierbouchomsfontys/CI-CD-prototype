using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AutomaticAcceptanceTest.Authorization.Roles;
using AutomaticAcceptanceTest.Authorization.Users;
using AutomaticAcceptanceTest.MultiTenancy;

namespace AutomaticAcceptanceTest.EntityFrameworkCore
{
    public class AutomaticAcceptanceTestDbContext : AbpZeroDbContext<Tenant, Role, User, AutomaticAcceptanceTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AutomaticAcceptanceTestDbContext(DbContextOptions<AutomaticAcceptanceTestDbContext> options)
            : base(options)
        {
        }
    }
}
