using System;
using WDC.Orders.Data.Entities;

namespace WDC.Orders.Service.OrderServices
{
    public interface IOrderService 
    {
        public Task<List<Order>> GetOrdersListAsync();

        public Order? GetOrderById(int Id);

        public Task<Order> CreateOrder(Order order);

        public Task UpdateOrder(Order order);

        public Task DeleteOrder(Order order);
    }
}

