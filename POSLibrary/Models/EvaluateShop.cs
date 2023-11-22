using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class EvaluateShop
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? SellOrderId { get; set; }

    public string? Star { get; set; }

    public DateTime? CreatedAt { get; set; }
}
