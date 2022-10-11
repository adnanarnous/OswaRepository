using Abp.Authorization;
using OswaTech.Authorization.Roles;
using OswaTech.Authorization.Users;

namespace OswaTech.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
