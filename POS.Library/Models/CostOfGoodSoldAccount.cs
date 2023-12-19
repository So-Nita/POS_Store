using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class CostOfGoodSoldAccount
{
    public ulong Id { get; set; }

    public string CostOfGoodSold { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }
}
