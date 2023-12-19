using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models.Request.Product
{
    public class ProductCreateReq
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public string CateoryId { get; set; } = null!;
        public string Image { get; set; } = null!;
    }
}
