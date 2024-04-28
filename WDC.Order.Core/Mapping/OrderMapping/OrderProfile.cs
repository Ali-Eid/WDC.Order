using System;
using AutoMapper;

namespace WDC.Orders.Core.Mapping.OrderMapping
{
    public partial class OrderProfile : Profile
    {
        public OrderProfile()
        {
            GetOrderListMapping();
            CreateOrderMapping();
            UpdateOrderMapping();
        }
    }
}

