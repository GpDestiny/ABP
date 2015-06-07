using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using sessionliang_M_EF.EntityFramework;

namespace sessionliang_M_EF
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(sessionliang_M_EFCoreModule))]
    public class sessionliang_M_EFDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<sessionliang_M_EFDbContext>(null);
        }
    }
}
