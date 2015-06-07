using System.Configuration;
using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.NHibernate;
using FluentNHibernate.Cfg.Db;

namespace sessionliang_NH
{
    [DependsOn(typeof(AbpNHibernateModule), typeof(sessionliang_NHCoreModule))]
    public class sessionliang_NHDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            Configuration.Modules.AbpNHibernate().FluentConfiguration
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(Configuration.DefaultNameOrConnectionString))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()));
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}