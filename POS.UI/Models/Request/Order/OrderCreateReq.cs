using POSDesignDemo.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models.Request.Order
{
    public class OrderCreateReq
    {
        public string shopId {  get; set; } = string.Empty;
        public string grandTotal { get; set; } = null!; 
        public string saleType { get; set; } = null!;
        public List<OrderProductCreateReq> products { get; set; } = null!;
    }
}
