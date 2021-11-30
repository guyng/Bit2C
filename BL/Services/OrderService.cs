using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Hubs;
using DAL;
using DAL.Domain;
using DAL.Enum;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace BL.Services
{
    public class OrderService: IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IHubContext<OrderHub> _orderHubContext;

        public OrderService(IRepository<Order> orderRepository, IHubContext<OrderHub> orderHubContext)
        {
            _orderRepository = orderRepository;
            _orderHubContext = orderHubContext;
        }


        public Task<List<Order>> GetOrders(OrderType orderType = OrderType.BUY)
        {
            return _orderRepository.Query().Where(o => o.OrderType == orderType)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();
        }

        public async Task AddOrder(Order order)
        {
            if (order == null)
            {
                return;
            }
            order.OrderDate = DateTime.Now;
            await _orderRepository.InsertAsync(order);
            await _orderHubContext.Clients.All.SendAsync("reloadOrders", order.OrderType);
        }
    }
}
