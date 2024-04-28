using System;
using MediatR;
using WDC.Orders.Core.Bases.ResponseBase;
using WDC.Orders.Core.Features.OrdersFeatures.Query.Responses;

namespace WDC.Orders.Core.Features.OrdersFeatures.Command.Models
{
    public class DeleteOrderCommand : IRequest<Response<string>>
    {
        public int OrderId { get; set; }
        public DeleteOrderCommand( int OrderId)
        {
            this.OrderId = OrderId;
        }
    }
}

