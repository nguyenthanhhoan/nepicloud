﻿using NPEICloud.CatalogService.MongoDB;
using System;
using NPEICloud.Shared.Hosting.Microservices.DbMigrations.MongoDb;
using Volo.Abp.Data;
using Volo.Abp.DistributedLocking;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;

namespace NPEICloud.CatalogService.DbMigrations;

public class CatalogServiceDatabaseMigrationChecker : PendingMongoDbMigrationsChecker<CatalogServiceMongoDbContext>
{
    public CatalogServiceDatabaseMigrationChecker(
        IUnitOfWorkManager unitOfWorkManager,
        IServiceProvider serviceProvider,
        ICurrentTenant currentTenant,
        IDataSeeder dataSeeder,
        IAbpDistributedLock distributedLockProvider)
        : base(
            unitOfWorkManager,
            serviceProvider,
            currentTenant,
            dataSeeder,
            distributedLockProvider,
            CatalogServiceDbProperties.ConnectionStringName)
    {
    }
}