using System;
using MediatR;
using WDC.Orders.Core.Bases.ResponseBase;
using WDC.Orders.Core.Features.OrdersFeatures.Query.Responses;

namespace WDC.Orders.Core.Features.OrdersFeatures.Query.Models
{
    public class GetOrderListQuery  :IRequest<Response<List<OrderResponse>>>
    {
    }
}

