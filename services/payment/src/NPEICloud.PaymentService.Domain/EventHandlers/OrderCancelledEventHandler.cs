﻿using NPEICloud.OrderingService.Orders;
using NPEICloud.PaymentService.PaymentRequests;
using Serilog;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;


namespace NPEICloud.PaymentService.EventHandlers
{
    public class OrderCancelledEventHandler : IDistributedEventHandler<OrderCancelledEto>, ITransientDependency
    {
        private readonly IPaymentRequestRepository _paymentRepository;

        public OrderCancelledEventHandler(IPaymentRequestRepository paymenRepository)
        {
            _paymentRepository = paymenRepository;
        }

        public async Task HandleEventAsync(OrderCancelledEto eventData)
        {
            var payment = await _paymentRepository.GetAsync(eventData.PaymentRequestId);
            Log.Information($"Cancelled the order: {payment.OrderId} payment:{payment.Id}");
        }
    }
}
