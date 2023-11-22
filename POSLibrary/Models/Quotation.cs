using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Quotation
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateOnly Date { get; set; }

    public string Ref { get; set; } = null!;

    public int CustomerId { get; set; }

    public double? TaxRate { get; set; }

    public double? TaxNet { get; set; }

    public double? Discount { get; set; }

    public double? Shipping { get; set; }

    public double GrandTotal { get; set; }

    public int? QuotationStatusTypeId { get; set; }

    public sbyte? IsDeleted { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int? ShopId { get; set; }
}
