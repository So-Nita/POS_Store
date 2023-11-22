using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class QuotationDetail
{
    public int Id { get; set; }

    public double Price { get; set; }

    public int? SaleUnitId { get; set; }

    public double? TaxNet { get; set; }

    public string? TaxMethod { get; set; }

    public double? Discount { get; set; }

    public string? DiscountMethod { get; set; }

    public double Total { get; set; }

    public double Quantity { get; set; }

    public int ProductId { get; set; }

    public int? ProductVariantId { get; set; }

    public int QuotationId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
