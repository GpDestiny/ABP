using System.Reflection;
using Abp.Modules;

namespace sessionliang_NH
{
    [DependsOn(typeof(sessionliang_NHCoreModule))]
    public class sessionliang_NHApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
