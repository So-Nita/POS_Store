using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class StockProductAssign
{
    public int Id { get; set; }

    public int? StockProductId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Price { get; set; }

    public decimal? UpdateQty { get; set; }

    public int? CurrencyId { get; set; }

    public int? ShopBranchDetailId { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Description { get; set; }

    public int CreateBy { get; set; }

    public string? ActionType { get; set; }

    public int? ActionBy { get; set; }

    public bool? Status { get; set; }
}
