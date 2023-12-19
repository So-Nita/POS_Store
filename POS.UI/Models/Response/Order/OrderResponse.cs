using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models.Response.Order
{
    public class OrderResponse
    {
        public int order_id { get; set; }
        public string cashier { get; set; } = "";
        public string order_date { get; set; }
        public double? total { get; set; }
        public double discount_price { get; set; }
        public double received { get; set; }
    }
}
