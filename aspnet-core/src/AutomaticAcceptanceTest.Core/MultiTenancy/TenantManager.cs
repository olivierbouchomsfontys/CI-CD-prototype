using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using AutomaticAcceptanceTest.Authorization.Users;
using AutomaticAcceptanceTest.Editions;

namespace AutomaticAcceptanceTest.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
