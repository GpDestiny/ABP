using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Localization;
using Abp.Localization.Sources.Xml;
using Abp.Modules;

namespace sessionliang_M_EF.Web
{
    [DependsOn(typeof(sessionliang_M_EFDataModule), typeof(sessionliang_M_EFApplicationModule), typeof(sessionliang_M_EFWebApiModule))]
    public class sessionliang_M_EFWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Add/remove languages for your application
            Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
            Configuration.Localization.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flag-tr"));

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new XmlLocalizationSource(
                    sessionliang_M_EFConsts.LocalizationSourceName,
                    HttpContext.Current.Server.MapPath("~/Localization/sessionliang_M_EF")
                    )
                );

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<sessionliang_M_EFNavigationProvider>();
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
