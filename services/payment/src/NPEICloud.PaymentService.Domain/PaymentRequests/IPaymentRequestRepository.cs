using System;
using Volo.Abp.Domain.Repositories;

namespace NPEICloud.PaymentService.PaymentRequests
{
    public interface IPaymentRequestRepository : IBasicRepository<PaymentRequest, Guid>
    {
    }
}
