using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace NPEICloud.IdentityService
{
    [DependsOn(
        typeof(IdentityServiceDomainSharedModule),
        typeof(AbpIdentityApplicationContractsModule)
    )]
    public class IdentityServiceApplicationContractsModule : AbpModule
    {
    }
}
