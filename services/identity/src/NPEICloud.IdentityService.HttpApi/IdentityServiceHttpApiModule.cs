using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace NPEICloud.IdentityService
{
    [DependsOn(
        typeof(IdentityServiceApplicationContractsModule),
        typeof(AbpIdentityHttpApiModule)
    )]
    public class IdentityServiceHttpApiModule : AbpModule
    {
    }
}