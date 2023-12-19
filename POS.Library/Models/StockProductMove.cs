using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class StockProductMove
{
    public int Id { get; set; }

    public int? StockProductId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Price { get; set; }

    public decimal? UpdateQty { get; set; }

    public int? StockStorageDetailId { get; set; }

    public int? CurrencyId { get; set; }

    public int? ShopBranchDetailId { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Description { get; set; }

    public int? CreateBy { get; set; }

    public string? ActionType { get; set; }

    public int? ActionBy { get; set; }

    public bool? Status { get; set; }

    public int? VariantId { get; set; }

    public double? Cost { get; set; }

    public int? StockBranchProductId { get; set; }

    public int? SellOrderId { get; set; }

    public virtual Currency? Currency { get; set; }
}
