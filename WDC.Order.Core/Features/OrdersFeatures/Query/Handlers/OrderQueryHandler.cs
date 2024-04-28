using System;
using AutoMapper;
using MediatR;
using WDC.Orders.Core.Bases.ResponseBase;
using WDC.Orders.Core.Features.OrdersFeatures.Query.Models;
using WDC.Orders.Core.Features.OrdersFeatures.Query.Responses;
using WDC.Orders.Service.OrderServices;

namespace WDC.Orders.Core.Features.OrdersFeatures.Query.Handlers
{
    public class OrderQueryHandler : ResponseHandler , IRequestHandler<GetOrderListQuery , Response<List<OrderResponse>>>,
                                                       IRequestHandler<GetOrderByIdQuery, Response<OrderResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IOrderService _orderService;
        public OrderQueryHandler(IMapper mapper, IOrderService orderService)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        public async Task<Response<List<OrderResponse>>> Handle(GetOrderListQuery request, CancellationToken cancellationToken)
        {
            var orders =await _orderService.GetOrdersListAsync();
            var ordersMapping = _mapper.Map<List<OrderResponse>>(orders);
            return Success(ordersMapping);
        }

        public async Task<Response<OrderResponse>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order =  _orderService.GetOrderById(request.OrderId);
            var ordersMapping = _mapper.Map<OrderResponse>(order);
            return Success(ordersMapping);
        }
    }
}

