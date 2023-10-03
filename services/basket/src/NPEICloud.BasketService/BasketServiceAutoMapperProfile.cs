using AutoMapper;
using NPEICloud.CatalogService.Grpc;
using NPEICloud.CatalogService.Products;

namespace NPEICloud.BasketService;

public class BasketServiceApplicationAutoMapperProfile : Profile
{
    public BasketServiceApplicationAutoMapperProfile()
    {
        CreateMap<ProductEto, ProductDto>();
        CreateMap<ProductResponse, ProductDto>();
    }
}