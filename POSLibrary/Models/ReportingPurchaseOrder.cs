using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ReportingPurchaseOrder
{
    public int Id { get; set; }

    public string? PoNo { get; set; }

    public int? TransactionNo { get; set; }

    public int? PoId { get; set; }

    public string? TransactionDate { get; set; }

    public string? PostDate { get; set; }

    public string? OrderDate { get; set; }

    public string? DeliveryDate { get; set; }

    public string? ShopName { get; set; }

    public string? ReferenceName { get; set; }

    public string? SellFromDate { get; set; }

    public string? SellToDate { get; set; }

    public string? VendorName { get; set; }

    public int? TotalQty { get; set; }

    public double? TotalCost { get; set; }

    public int StatusFilterId { get; set; }

    public string? Remarks { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IsDeleted { get; set; }

    public int? Status { get; set; }

    public int? VendorId { get; set; }

    public int? ReferenceId { get; set; }

    public int? ShopId { get; set; }

    public string? CategoryId { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
