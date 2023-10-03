using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace NPEICloud.IdentityService
{
    [DependsOn(
        typeof(IdentityServiceDomainModule),
        typeof(IdentityServiceApplicationContractsModule),
        typeof(AbpIdentityApplicationModule)
        )]
    public class IdentityServiceApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<IdentityServiceApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<IdentityServiceApplicationModule>(validate: true);
            });
        }
    }
}
