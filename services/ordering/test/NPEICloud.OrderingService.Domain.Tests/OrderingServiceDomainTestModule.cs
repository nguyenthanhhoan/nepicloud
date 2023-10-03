﻿using NPEICloud.OrderingService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NPEICloud.OrderingService
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(OrderingServiceEntityFrameworkCoreTestModule)
        )]
    public class OrderingServiceDomainTestModule : AbpModule
    {
        
    }
}
