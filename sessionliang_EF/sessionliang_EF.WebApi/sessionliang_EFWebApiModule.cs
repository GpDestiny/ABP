using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace sessionliang_EF
{
    [DependsOn(typeof(AbpWebApiModule), typeof(sessionliang_EFApplicationModule))]
    public class sessionliang_EFWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(sessionliang_EFApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
