using Abp.Web.Mvc.Controllers;

namespace sessionliang_NH.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class sessionliang_NHControllerBase : AbpController
    {
        protected sessionliang_NHControllerBase()
        {
            LocalizationSourceName = sessionliang_NHConsts.LocalizationSourceName;
        }
    }
}