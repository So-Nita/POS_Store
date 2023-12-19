using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Cover
{
    public int Id { get; set; }

    public string Source { get; set; } = null!;

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }

    public DateTime? CreatedAt { get; set; }
}
