using System;
namespace WDC.Orders.Core.Features.OrdersFeatures.Query.Responses
{
    public class OrderResponse
    {
        public int OrderId { get; set; }

        public string Address { get; set; }

        public int Quantity { get; set; }

        public string CreatedAt { get; set; }
    }
}

