using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace sessionliang_NH
{
    [DependsOn(typeof(AbpWebApiModule), typeof(sessionliang_NHApplicationModule))]
    public class sessionliang_NHWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(sessionliang_NHApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
