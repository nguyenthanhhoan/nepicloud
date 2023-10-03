using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace NPEICloud.CmskitService.EntityFrameworkCore;

[ConnectionStringName(CmskitServiceDbProperties.ConnectionStringName)]
public interface ICmskitServiceDbContext : IEfCoreDbContext
{
}