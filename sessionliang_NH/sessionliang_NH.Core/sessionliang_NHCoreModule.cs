using System.Reflection;
using Abp.Modules;

namespace sessionliang_NH
{
    public class sessionliang_NHCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
