using Abp.Web.Mvc.Controllers;

namespace sessionliang_M_NH.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class sessionliang_M_NHControllerBase : AbpController
    {
        protected sessionliang_M_NHControllerBase()
        {
            LocalizationSourceName = sessionliang_M_NHConsts.LocalizationSourceName;
        }
    }
}