using System;
using AutoMapper;
using WDC.Orders.Core.Features.OrdersFeatures.Command.Models;
using WDC.Orders.Data.Entities;

namespace WDC.Orders.Core.Mapping.OrderMapping
{
    public partial class OrderProfile : Profile
    {
       void CreateOrderMapping()
        {
            CreateMap<CreateOrderCommand, Order>();
        }
    }
}

