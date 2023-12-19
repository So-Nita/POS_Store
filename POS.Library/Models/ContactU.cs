using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ContactU
{
    public ulong Id { get; set; }

    public int ShopId { get; set; }

    public string Message { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
