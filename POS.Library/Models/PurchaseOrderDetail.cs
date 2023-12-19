using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class PurchaseOrderDetail
{
    public int Id { get; set; }

    public int? PoId { get; set; }

    public int? ProductId { get; set; }

    public int? VariantId { get; set; }

    public int? ItemNumber { get; set; }

    public long? Barcode { get; set; }

    public string? NameEng { get; set; }

    public string? NameKh { get; set; }

    public int? SubcatoryId { get; set; }

    public int? OrderQty { get; set; }

    public double? Cost { get; set; }

    public double? TotalCost { get; set; }

    public DateTime? CreateDate { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }

    public double? Price { get; set; }

    public string? ReceivingStatus { get; set; }

    public int? SaleHistory { get; set; }
}
