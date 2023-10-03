using NPEICloud.CatalogService.MongoDB;
using Xunit;

namespace NPEICloud.CatalogService;

[CollectionDefinition(CatalogServiceTestConsts.CollectionDefinitionName)]
public class CatalogServiceDomainCollection : CatalogServiceMongoDbCollectionFixtureBase
{

}