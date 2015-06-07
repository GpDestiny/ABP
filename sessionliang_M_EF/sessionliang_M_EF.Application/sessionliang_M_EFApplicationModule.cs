using System.Reflection;
using Abp.Modules;

namespace sessionliang_M_EF
{
    [DependsOn(typeof(sessionliang_M_EFCoreModule))]
    public class sessionliang_M_EFApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
