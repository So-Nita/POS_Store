using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models
{
    public class Supplier
    {
        public string Id { get; set; } = null!;
        public string? SupplierName { get; set; } = null!;
        public string? Contact { get; set; } = null!;
        public string? Email { get; set; }
        public string? ShopId { get; set; }
        public string? ShopName { get; set; }
        public string? Website { get; set; }
        public string? VendorCode { get; set; } = null!;
    }
    
}
