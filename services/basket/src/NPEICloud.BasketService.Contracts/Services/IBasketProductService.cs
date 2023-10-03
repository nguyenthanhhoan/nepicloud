using System;
using System.Threading.Tasks;
using NPEICloud.CatalogService.Products;
using JetBrains.Annotations;

namespace NPEICloud.BasketService.Services;

public interface IBasketProductService
{
    [ItemNotNull]
    Task<ProductDto> GetAsync(Guid productId);
}