using Abp.Application.Services;

namespace sessionliang_M_NH
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class sessionliang_M_NHAppServiceBase : ApplicationService
    {
        protected sessionliang_M_NHAppServiceBase()
        {
            LocalizationSourceName = sessionliang_M_NHConsts.LocalizationSourceName;
        }
    }
}