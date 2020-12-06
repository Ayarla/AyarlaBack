using Abp.Authorization;
using Ayarla.Authorization.Roles;
using Ayarla.Authorization.Users;

namespace Ayarla.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
