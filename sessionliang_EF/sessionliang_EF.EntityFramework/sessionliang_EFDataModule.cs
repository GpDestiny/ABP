using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using sessionliang_EF.EntityFramework;

namespace sessionliang_EF
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(sessionliang_EFCoreModule))]
    public class sessionliang_EFDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<sessionliang_EFDbContext>(null);
        }
    }
}
