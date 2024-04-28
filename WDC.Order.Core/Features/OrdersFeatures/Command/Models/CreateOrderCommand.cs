using System;
using MediatR;
using WDC.Orders.Core.Bases.ResponseBase;
using WDC.Orders.Core.Features.OrdersFeatures.Query.Responses;

namespace WDC.Orders.Core.Features.OrdersFeatures.Command.Models
{
    public class CreateOrderCommand : IRequest<Response<OrderResponse>>
    {
        public string Address { get; set; }

        public int Quantity { get; set; }
    }
}

