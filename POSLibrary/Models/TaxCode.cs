using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class TaxCode
{
    public ulong Id { get; set; }

    public string TaxCode1 { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }
}
