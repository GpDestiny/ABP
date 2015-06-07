using System.Reflection;
using Abp.Modules;

namespace sessionliang_EF
{
    [DependsOn(typeof(sessionliang_EFCoreModule))]
    public class sessionliang_EFApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
