using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models.Request.Order
{
    public class OrderProductCreateReq
    {
        public string productId { get; set; } = null!;
        public string productName { get; set; } = null!;
        public string productImage { get; set; } = null!;
        public string qty { get; set; } = null!;
        public string price { get; set; } = null!;
        public string unitPrice { get; set; } = null!;
        public string discount { get; set; } = null!;
        public string subTotal { get; set; } = null!;
        public string productTax { get; set; } = null!;
        public string variantId { get; set; } = null!;
    }
}
