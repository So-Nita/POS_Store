using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Favorite
{
    public ulong Id { get; set; }

    public string CustomerId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }
}
