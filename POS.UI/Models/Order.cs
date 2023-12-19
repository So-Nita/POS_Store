using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public string ShopId { get; set; } = "";
        public double GrandTotal { get; set; }
        public string saleType { get; set; } = "";
    }
}
