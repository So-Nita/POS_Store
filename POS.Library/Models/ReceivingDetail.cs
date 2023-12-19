using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ReceivingDetail
{
    public int Id { get; set; }

    public int? ReceivingId { get; set; }

    public int? ProductId { get; set; }

    public int? VariantId { get; set; }

    public int? SubcatoryId { get; set; }

    public int? OrderQty { get; set; }

    public double? Cost { get; set; }

    public double? TotalCost { get; set; }

    public DateTime? CreateDate { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }

    public double? Price { get; set; }

    public int? PoQty { get; set; }
}
