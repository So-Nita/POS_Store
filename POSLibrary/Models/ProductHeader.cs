using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ProductHeader
{
    public int Id { get; set; }

    public string? HeaderId { get; set; }

    public string? HeaderName { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }
}
