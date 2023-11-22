using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class StockBranchProduct
{
    public int Id { get; set; }

    public int? ActionBy { get; set; }

    public int? ShopBranchDetailId { get; set; }

    public int No { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? SupplierId { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    public int CreateBy { get; set; }

    public bool? Status { get; set; }

    public int? DeleteBy { get; set; }

    public string? ActionType { get; set; }

    public int? ApproveBy { get; set; }

    public int? ShopBranchId { get; set; }
}
