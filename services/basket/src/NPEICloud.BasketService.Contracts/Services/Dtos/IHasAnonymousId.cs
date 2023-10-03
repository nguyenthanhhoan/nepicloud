using System;

namespace NPEICloud.BasketService.Services
{
    public interface IHasAnonymousId
    {
        Guid? AnonymousId { get; }
    }
}
