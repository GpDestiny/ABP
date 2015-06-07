using Abp.Web.Mvc.Views;

namespace sessionliang_M_EF.Web.Views
{
    public abstract class sessionliang_M_EFWebViewPageBase : sessionliang_M_EFWebViewPageBase<dynamic>
    {

    }

    public abstract class sessionliang_M_EFWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected sessionliang_M_EFWebViewPageBase()
        {
            LocalizationSourceName = sessionliang_M_EFConsts.LocalizationSourceName;
        }
    }
}