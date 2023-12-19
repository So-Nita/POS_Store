using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class PurchaseOrderStatus
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }
}
