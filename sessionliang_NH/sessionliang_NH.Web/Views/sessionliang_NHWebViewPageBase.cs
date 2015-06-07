using Abp.Web.Mvc.Views;

namespace sessionliang_NH.Web.Views
{
    public abstract class sessionliang_NHWebViewPageBase : sessionliang_NHWebViewPageBase<dynamic>
    {

    }

    public abstract class sessionliang_NHWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected sessionliang_NHWebViewPageBase()
        {
            LocalizationSourceName = sessionliang_NHConsts.LocalizationSourceName;
        }
    }
}