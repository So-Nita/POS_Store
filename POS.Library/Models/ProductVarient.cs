using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ProductVarient
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string? Varient { get; set; }

    public string? Sku { get; set; }

    public double? Price { get; set; }

    public int? Qty { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public double? Cost { get; set; }

    public int? ItemNumber { get; set; }

    public string? Country { get; set; }

    public string? ShelfLife { get; set; }

    public int? DeliveryTypeId { get; set; }

    public double? EstimationGp { get; set; }

    public string? Moq { get; set; }

    public string? Upc { get; set; }

    public string? Picking { get; set; }

    public string? Size { get; set; }

    public double? SaleGp { get; set; }

    public string? Remark { get; set; }

    public string? ReturnPolicy { get; set; }

    public int? IncomeAccountId { get; set; }

    public int? TaxCodeId { get; set; }

    public int? AssetAccountId { get; set; }

    public int? CostOfGoodSoldId { get; set; }
}
