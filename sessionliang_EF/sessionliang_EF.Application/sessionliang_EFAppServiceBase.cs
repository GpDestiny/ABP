using Abp.Application.Services;

namespace sessionliang_EF
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class sessionliang_EFAppServiceBase : ApplicationService
    {
        protected sessionliang_EFAppServiceBase()
        {
            LocalizationSourceName = sessionliang_EFConsts.LocalizationSourceName;
        }
    }
}