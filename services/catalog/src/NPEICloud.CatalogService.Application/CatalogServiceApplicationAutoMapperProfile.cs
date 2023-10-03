using AutoMapper;
using NPEICloud.CatalogService.Grpc;
using NPEICloud.CatalogService.Products;

namespace NPEICloud.CatalogService
{
    public class CatalogServiceApplicationAutoMapperProfile : Profile
    {
        public CatalogServiceApplicationAutoMapperProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Product, ProductResponse>();
        }
    }
}
