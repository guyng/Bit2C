using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Enum;

namespace DAL.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public OrderType OrderType { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
