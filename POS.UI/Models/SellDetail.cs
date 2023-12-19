using Newtonsoft.Json;
using POSDesignDemo.Models.Response.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models
{
    public class SellDetailResponse
    {
        public SellDetail Result { get; set; }
    }
    public class SellDetail
    {
        public List<OrderResponse> order { get; set; }
        public List<OrderDetail> detail { get; set; }
    }
    
}


