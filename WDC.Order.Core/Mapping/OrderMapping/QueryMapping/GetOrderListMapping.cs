using System;
using AutoMapper;
using WDC.Orders.Core.Features.OrdersFeatures.Query.Responses;
using WDC.Orders.Data.Entities;

namespace WDC.Orders.Core.Mapping.OrderMapping
{
    public partial class OrderProfile : Profile
    {
        void GetOrderListMapping()
        {
            CreateMap<Order , OrderResponse>().ForMember(dest=>dest.OrderId , opt=>opt.MapFrom(src=>src.Id));
        }
    }
}
