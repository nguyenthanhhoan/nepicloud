using NPEICloud.CatalogService.Localization;
using Volo.Abp.Application.Services;

namespace NPEICloud.CatalogService
{
    /* Inherit your application services from this class.
     */
    public abstract class CatalogServiceAppService : ApplicationService
    {
        protected CatalogServiceAppService()
        {
            LocalizationResource = typeof(CatalogServiceResource);
        }
    }
}
