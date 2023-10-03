using NPEICloud.OrderingService.OrderItems;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace NPEICloud.OrderingService.Orders;

public class DashboardDto: EntityDto
{
    public List<TopSellingDto> TopSellings { get; set; }
    public List<PaymentDto> Payments { get; set; }
    public List<OrderStatusDto> OrderStatusDto { get; set; }
}