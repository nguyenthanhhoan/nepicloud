using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus;

namespace NPEICloud.PaymentService.PaymentRequests;

[EventName("NPEICloud.Payment.Completed")]
public class PaymentCompletedEto : EtoBase
{
    public PaymentRequestDto PaymentRequest { get; set; }
}