using System.Reflection;
using Abp.Modules;

namespace sessionliang_M_EF
{
    public class sessionliang_M_EFCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
