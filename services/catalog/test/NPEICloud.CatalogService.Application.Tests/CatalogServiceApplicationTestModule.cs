using Volo.Abp.Modularity;

namespace NPEICloud.CatalogService
{
    [DependsOn(
        typeof(CatalogServiceApplicationModule),
        typeof(CatalogServiceDomainTestModule)
        )]
    public class CatalogServiceApplicationTestModule : AbpModule
    {

    }
}