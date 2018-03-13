using Abp.Authorization;
using mLizard.Authorization.Roles;
using mLizard.Authorization.Users;

namespace mLizard.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
