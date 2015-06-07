using Abp.Application.Services;

namespace sessionliang_NH
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class sessionliang_NHAppServiceBase : ApplicationService
    {
        protected sessionliang_NHAppServiceBase()
        {
            LocalizationSourceName = sessionliang_NHConsts.LocalizationSourceName;
        }
    }
}