using System;
using AutoMapper;
using MediatR;
using WDC.Orders.Core.Bases.ResponseBase;
using WDC.Orders.Core.Features.OrdersFeatures.Command.Models;
using WDC.Orders.Core.Features.OrdersFeatures.Query.Responses;
using WDC.Orders.Data.Entities;
using WDC.Orders.Service.OrderServices;

namespace WDC.Orders.Core.Features.OrdersFeatures.Command.Handlers
{
    public class OrderCommandHandler  : ResponseHandler , IRequestHandler<CreateOrderCommand , Response<OrderResponse>>,
                                                          IRequestHandler<UpdateOrderCommand, Response<string>>,
                                                          IRequestHandler<DeleteOrderCommand, Response<string>>
    {
        private readonly IMapper _mapper;
        private readonly IOrderService _orderService;
        public OrderCommandHandler(IMapper mapper, IOrderService orderService)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _orderService.GetOrderById(request.OrderId);
            if (order == null) return NotFound<string>("The order is not exist");

            await _orderService.DeleteOrder(order);

            return Success<string>("Deleted successfully");
        }

        public async Task<Response<OrderResponse>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request);
            var newOrder =  await _orderService.CreateOrder(order);
            var orderMapping = _mapper.Map<OrderResponse>(newOrder);
            return Success(orderMapping);
        }

        public async Task<Response<string>> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _orderService.GetOrderById(request.OrderId);
            if (order == null) return NotFound<string>("The order is not exist");

            var orderUpdate = _mapper.Map<Order>(request);

           await _orderService.UpdateOrder(orderUpdate);

            return Success<string>("Updated successfully");
        }
    }
}

