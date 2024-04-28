using System;
using WDC.Orders.Data.Entities;
using WDC.Orders.Infrastructure.Bases.RepositoryBase;

namespace WDC.Orders.Service.OrderServices
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRepositoryAsync<Order> _orderRepository;
        public OrderService(IGenericRepositoryAsync<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> CreateOrder(Order order)
        {
            var result = await _orderRepository.AddAsync(order);
            return result;

        }

        public async Task DeleteOrder(Order order)
        {
            var trans = _orderRepository.BeginTransaction();
            try
            {
                await _orderRepository.DeleteAsync(order);
                await trans.CommitAsync();
            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();
            }
        }

        public Order? GetOrderById(int Id)
        {
            var result = _orderRepository.GetTableNoTracking().Where(x => x.Id == Id).FirstOrDefault();
            return result ;
        }

        public async Task<List<Order>> GetOrdersListAsync()
        {
            return await Task.FromResult(_orderRepository.GetTableNoTracking().ToList());
        }

        public async Task UpdateOrder(Order order)
        {
           await _orderRepository.UpdateAsync(order);
        }
    }
}

