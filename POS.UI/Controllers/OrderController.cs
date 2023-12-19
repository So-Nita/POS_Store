using POSDesignDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Controllers
{
    public class OrderController : ControllerBase 
    {
        public OrderController()
        {
            
        }
        public Task<Order> CreateOrder(Order order)
        {
            return Task.FromResult(order);
        }
    }
}
