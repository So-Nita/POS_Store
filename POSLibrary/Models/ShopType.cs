using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ShopType
{
    public ulong Id { get; set; }

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public sbyte? IsDeleted { get; set; }
}
