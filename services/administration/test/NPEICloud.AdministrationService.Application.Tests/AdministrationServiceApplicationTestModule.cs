using Volo.Abp.Modularity;

namespace NPEICloud.AdministrationService
{
    [DependsOn(
        typeof(AdministrationServiceApplicationModule),
        typeof(AdministrationServiceDomainTestModule)
        )]
    public class AdministrationServiceApplicationTestModule : AbpModule
    {

    }
}