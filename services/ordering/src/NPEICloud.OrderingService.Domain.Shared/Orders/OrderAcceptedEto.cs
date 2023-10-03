using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus;

namespace NPEICloud.OrderingService.Orders;

[Serializable]
[EventName("NPEICloud.Order.Accepted")]
public class OrderAcceptedEto : EtoBase
{
    public Guid OrderId { get; set; }
    public string PaymentStatus { get; set; }
    public BuyerEto Buyer { get; set; }
    public List<OrderItemEto> Items { get; set; }
}