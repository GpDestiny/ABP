using System.Reflection;
using Abp.Modules;

namespace sessionliang_EF
{
    public class sessionliang_EFCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
