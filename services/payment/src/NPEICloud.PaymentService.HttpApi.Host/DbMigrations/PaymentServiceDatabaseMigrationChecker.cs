﻿using NPEICloud.PaymentService.EntityFrameworkCore;
using System;
using NPEICloud.Shared.Hosting.Microservices.DbMigrations.EfCore;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;
using Volo.Abp.DistributedLocking;

namespace NPEICloud.PaymentService.DbMigrations;

public class PaymentServiceDatabaseMigrationChecker : PendingEfCoreMigrationsChecker<PaymentServiceDbContext>
{
    public PaymentServiceDatabaseMigrationChecker(
        IUnitOfWorkManager unitOfWorkManager,
        IServiceProvider serviceProvider,
        ICurrentTenant currentTenant,
        IDistributedEventBus distributedEventBus,
        IAbpDistributedLock abpDistributedLock)
        : base(
            unitOfWorkManager,
            serviceProvider,
            currentTenant,
            distributedEventBus,
            abpDistributedLock,
            PaymentServiceDbProperties.ConnectionStringName)
    {
    }
}