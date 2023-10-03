using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using NPEICloud.CatalogService;
using NPEICloud.OrderingService;
using NPEICloud.CmskitService;

namespace NPEICloud.AdministrationService
{
    [DependsOn(
        typeof(CatalogServiceApplicationContractsModule),
        typeof(AdministrationServiceDomainSharedModule),
        typeof(AbpPermissionManagementApplicationContractsModule),
        typeof(AbpSettingManagementApplicationContractsModule),
        typeof(OrderingServiceApplicationContractsModule),
        typeof(CmskitServiceApplicationContractsModule)
    )]
    public class AdministrationServiceApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
