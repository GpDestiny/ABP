using System.Reflection;
using Abp.Modules;

namespace sessionliang_M_NH
{
    public class sessionliang_M_NHCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
