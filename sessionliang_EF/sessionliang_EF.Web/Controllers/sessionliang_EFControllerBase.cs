using Abp.Web.Mvc.Controllers;

namespace sessionliang_EF.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class sessionliang_EFControllerBase : AbpController
    {
        protected sessionliang_EFControllerBase()
        {
            LocalizationSourceName = sessionliang_EFConsts.LocalizationSourceName;
        }
    }
}