using POSLibrary.DataModels.Product;
using POSLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary.DataModels.SellOrder
{
    public class SellOrderResponse : IResponse
    {
        public ulong OrderId { get; set; }    
        public int? CustomerId { get; set; }
        public long? CustomerAddressId { get; set; }
        public long? ShopId { get; set; }
        public long? PaymentMethodId { get; set; }
        public Double? TotalPrice { get; set; }
        public decimal? DeliveryPrice { get; set; }
        public string? SaleType { get; set; }
        public string? DeliveryStatus { get; set; }
        public double Tax { get; set; }
        public decimal? GrandTotal { get; set; }
        public double? Received { get; set; }
        public double? Changed { get; set; }
        public string? DeliveryInstruction { get; set; }
        public IEnumerable<ProductPurchaseResponse> Products = null!;
    }
    public class ProductPurchaseResponse
    {
        public int? ProductId { get; set; }  
        public string? ProductName { get; set; } = null!;
        public string? ProductImage { get; set; } = null!;
        public double? Qty { get; set; }  
        public decimal? Price { get; set; }  
        public decimal? UnitPrice { get; set; } = null!;
        public double? Discount { get; set; } = null!;
        public decimal? SubTotal { get; set; } = null!;
        public string? ProductTax { get; set; } = null!;
        public int? VariantId { get; set; } = null!;
    }
}
