using Abp.Web.Mvc.Controllers;

namespace sessionliang_M_EF.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class sessionliang_M_EFControllerBase : AbpController
    {
        protected sessionliang_M_EFControllerBase()
        {
            LocalizationSourceName = sessionliang_M_EFConsts.LocalizationSourceName;
        }
    }
}