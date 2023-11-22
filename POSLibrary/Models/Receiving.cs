using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Receiving
{
    public int Id { get; set; }

    public string? PoNo { get; set; }

    public int? TransactionNo { get; set; }

    public string? TransactionDate { get; set; }

    public string? PostDate { get; set; }

    public int? ShopId { get; set; }

    public int? TotalQty { get; set; }

    public double? TotalCost { get; set; }

    public int? StatusFilterId { get; set; }

    public string? Remarks { get; set; }

    public int? VendorId { get; set; }

    public string? ReferenceName { get; set; }

    public string? CategoryId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IsDeleted { get; set; }

    public int? Status { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
