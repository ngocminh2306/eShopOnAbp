using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace EShopOnAbp.OrderingService.Orders;

public class OrderDto : EntityDto<Guid>
{
    public DateTime OrderDate { get; set; }
    public int OrderNo {get;set;}
    public int OrderStatusId { get; set; }
    public string OrderStatus { get; set; }
    public int PaymentTypeId { get; set; }
    public string PaymentType { get; set; }
    public BuyerDto Buyer { get; set; }
    public OrderAddressDto Address { get; set; } = new();
    public List<OrderItemDto> Items { get; set; } = new();
}