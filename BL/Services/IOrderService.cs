using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Domain;
using DAL.Enum;

namespace BL.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrders(OrderType orderType = OrderType.BUY);
        Task AddOrder(Order order);
    }
}
