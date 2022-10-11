using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OswaTech.Controllers
{
    public abstract class OswaTechControllerBase: AbpController
    {
        protected OswaTechControllerBase()
        {
            LocalizationSourceName = OswaTechConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
