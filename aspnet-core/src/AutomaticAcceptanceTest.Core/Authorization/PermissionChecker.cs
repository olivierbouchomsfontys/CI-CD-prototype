using Abp.Authorization;
using AutomaticAcceptanceTest.Authorization.Roles;
using AutomaticAcceptanceTest.Authorization.Users;

namespace AutomaticAcceptanceTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
