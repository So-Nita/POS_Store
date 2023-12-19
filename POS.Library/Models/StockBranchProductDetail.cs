using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class StockBranchProductDetail
{
    public int Id { get; set; }

    public int? StockProductMoveId { get; set; }

    public int? StockBranchProductId { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? Status { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ProStatus { get; set; }

    public string? StockBranchProductDetail1 { get; set; }

    public int? CreateBy { get; set; }
}
