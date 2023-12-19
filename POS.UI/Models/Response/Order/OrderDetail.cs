using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models.Response.Order
{
    public class OrderDetail
    {
        public string barcode { get; set; }
        public string product_name_kh { get; set; }
        public int qty { get; set; }
        public double product_price { get; set; }
        public double net_price { get; set; }
    }
}
