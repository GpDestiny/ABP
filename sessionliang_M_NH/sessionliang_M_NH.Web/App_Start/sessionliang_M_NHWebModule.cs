using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Localization;
using Abp.Localization.Sources.Xml;
using Abp.Modules;

namespace sessionliang_M_NH.Web
{
    [DependsOn(typeof(sessionliang_M_NHDataModule), typeof(sessionliang_M_NHApplicationModule), typeof(sessionliang_M_NHWebApiModule))]
    public class sessionliang_M_NHWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Add/remove languages for your application
            Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
            Configuration.Localization.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flag-tr"));

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new XmlLocalizationSource(
                    sessionliang_M_NHConsts.LocalizationSourceName,
                    HttpContext.Current.Server.MapPath("~/Localization/sessionliang_M_NH")
                    )
                );

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<sessionliang_M_NHNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
