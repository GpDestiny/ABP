using System.Reflection;
using Abp.Modules;

namespace sessionliang_M_NH
{
    [DependsOn(typeof(sessionliang_M_NHCoreModule))]
    public class sessionliang_M_NHApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
