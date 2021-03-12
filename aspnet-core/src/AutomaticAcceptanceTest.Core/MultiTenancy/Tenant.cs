using Abp.MultiTenancy;
using AutomaticAcceptanceTest.Authorization.Users;

namespace AutomaticAcceptanceTest.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
