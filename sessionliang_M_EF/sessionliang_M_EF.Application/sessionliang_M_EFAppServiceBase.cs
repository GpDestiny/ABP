using Abp.Application.Services;

namespace sessionliang_M_EF
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class sessionliang_M_EFAppServiceBase : ApplicationService
    {
        protected sessionliang_M_EFAppServiceBase()
        {
            LocalizationSourceName = sessionliang_M_EFConsts.LocalizationSourceName;
        }
    }
}