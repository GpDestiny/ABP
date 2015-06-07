using Abp.Web.Mvc.Views;

namespace sessionliang_M_NH.Web.Views
{
    public abstract class sessionliang_M_NHWebViewPageBase : sessionliang_M_NHWebViewPageBase<dynamic>
    {

    }

    public abstract class sessionliang_M_NHWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected sessionliang_M_NHWebViewPageBase()
        {
            LocalizationSourceName = sessionliang_M_NHConsts.LocalizationSourceName;
        }
    }
}