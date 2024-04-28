using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WDC.Orders.Api.Controllers.Base;
using WDC.Orders.Core.Features.OrdersFeatures.Command.Models;
using WDC.Orders.Core.Features.OrdersFeatures.Query.Models;
using WDC.Orders.Data.AppMetaData;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WDC.Orders.Api.Controllers
{   
    public class OrderController : AppControllerBase
    {
        [HttpGet(Router.OrderRouting.list)]
        public async Task<IActionResult> GetOrdersList()
        {
            return Ok(await Mediator.Send(new GetOrderListQuery()));
        }
        [HttpGet(Router.OrderRouting.orderById)]
        public async Task<IActionResult> GetOrderById([FromRoute] int Id)
        {
            return NewResult(await Mediator.Send(new GetOrderByIdQuery(Id)));
        }
        [HttpPost(Router.OrderRouting.create)]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
        {
            return NewResult(await Mediator.Send(command));
        }
        [HttpPut(Router.OrderRouting.update)]
        public async Task<IActionResult> UpdateOrder([FromBody] UpdateOrderCommand command)
        {
            return NewResult(await Mediator.Send(command));
        }
        [HttpDelete(Router.OrderRouting.delete)]
        public async Task<IActionResult> DeleteOrder([FromRoute] int Id)
        {
            return NewResult(await Mediator.Send(new DeleteOrderCommand(Id)));
        }
    }
}

