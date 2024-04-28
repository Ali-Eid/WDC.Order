using System;
using MediatR;
using WDC.Orders.Core.Bases.ResponseBase;
using WDC.Orders.Core.Features.OrdersFeatures.Query.Responses;

namespace WDC.Orders.Core.Features.OrdersFeatures.Query.Models
{

    public class GetOrderByIdQuery : IRequest<Response<OrderResponse>>
    {
        public int OrderId { get; set; }

        public GetOrderByIdQuery(int OrderId)
        {
            this.OrderId = OrderId;
        }
    }
}

