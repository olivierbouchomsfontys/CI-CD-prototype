using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using AutomaticAcceptanceTest.Authorization.Roles;
using AutomaticAcceptanceTest.Authorization.Users;
using AutomaticAcceptanceTest.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace AutomaticAcceptanceTest.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
