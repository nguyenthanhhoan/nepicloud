using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace NPEICloud.CatalogService.MongoDB
{
    [ConnectionStringName(CatalogServiceDbProperties.ConnectionStringName)]
    public interface ICatalogServiceMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
