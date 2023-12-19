using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.DataModels.Request
{
    public class ProductOrderReq
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int Qty { get; set; }
        public Double Price { get; set; }
        public double SubTotal { get;set; }
    }
}
