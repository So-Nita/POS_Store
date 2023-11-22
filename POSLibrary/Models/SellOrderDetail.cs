using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class SellOrderDetail
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? SellOrderId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductImage { get; set; }

    public string? Size { get; set; }

    public int? Items { get; set; }

    public decimal? Price { get; set; }

    public double? Qty { get; set; }

    public double? Discount { get; set; }

    public string? DiscountType { get; set; }

    public decimal? SubTotal { get; set; }

    public string? ProductCode { get; set; }

    public string? Tax { get; set; }

    public decimal? ItemTax { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? VariantId { get; set; }
}
