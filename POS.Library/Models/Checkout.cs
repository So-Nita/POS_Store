using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Checkout
{
    public int Id { get; set; }

    public long? CustomerId { get; set; }

    public double? Discount { get; set; }

    public string? Tax { get; set; }

    public double? Shipping { get; set; }

    public double GrandTotal { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? SaleType { get; set; }
}
