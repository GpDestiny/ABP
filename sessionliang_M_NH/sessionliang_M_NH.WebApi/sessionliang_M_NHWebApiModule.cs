using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace sessionliang_M_NH
{
    [DependsOn(typeof(AbpWebApiModule), typeof(sessionliang_M_NHApplicationModule))]
    public class sessionliang_M_NHWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(sessionliang_M_NHApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
