using System.Threading.Tasks;
using BL.Services;
using DAL.Domain;
using DAL.Enum;
using Microsoft.AspNetCore.Mvc;

namespace Bit2C.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders([FromQuery]OrderType orderType = OrderType.BUY)
        {
            var orders = await _orderService.GetOrders(orderType);
            return Ok(orders);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody] Order order)
        {
            await _orderService.AddOrder(order);
            return Ok();
        }
    }
}
