using AutoMapper;
using NPEICloud.CatalogService.Products;

namespace NPEICloud.CatalogService
{
    public class CatalogServiceDomainAutoMapperProfile : Profile
    {
        public CatalogServiceDomainAutoMapperProfile()
        {
            CreateMap<Product, ProductEto>();
        }
    }
}
