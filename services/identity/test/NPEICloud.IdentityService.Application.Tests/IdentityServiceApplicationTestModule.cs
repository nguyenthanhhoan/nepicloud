using Volo.Abp.Modularity;

namespace NPEICloud.IdentityService
{
    [DependsOn(
        typeof(IdentityServiceApplicationModule),
        typeof(IdentityServiceDomainTestModule)
        )]
    public class IdentityServiceApplicationTestModule : AbpModule
    {

    }
}