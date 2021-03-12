using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AutomaticAcceptanceTest.Controllers
{
    public abstract class AutomaticAcceptanceTestControllerBase: AbpController
    {
        protected AutomaticAcceptanceTestControllerBase()
        {
            LocalizationSourceName = AutomaticAcceptanceTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
