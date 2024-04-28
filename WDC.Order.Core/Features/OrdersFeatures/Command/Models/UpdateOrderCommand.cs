using System;
using MediatR;
using WDC.Orders.Core.Bases.ResponseBase;
using WDC.Orders.Core.Features.OrdersFeatures.Query.Responses;

namespace WDC.Orders.Core.Features.OrdersFeatures.Command.Models
{
    public class UpdateOrderCommand : IRequest<Response<string>>
    {
        public int OrderId { get; set; }

        public string Address { get; set; }

        public int Quantity { get; set; }
    }
}

