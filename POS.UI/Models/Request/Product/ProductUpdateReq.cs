using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models.Request.Product
{
    public class ProductUpdateReq
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public double? Price { get; set; }
        public string? Image { set; get; }
    }
}
