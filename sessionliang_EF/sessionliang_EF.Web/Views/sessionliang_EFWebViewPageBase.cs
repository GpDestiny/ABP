using Abp.Web.Mvc.Views;

namespace sessionliang_EF.Web.Views
{
    public abstract class sessionliang_EFWebViewPageBase : sessionliang_EFWebViewPageBase<dynamic>
    {

    }

    public abstract class sessionliang_EFWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected sessionliang_EFWebViewPageBase()
        {
            LocalizationSourceName = sessionliang_EFConsts.LocalizationSourceName;
        }
    }
}