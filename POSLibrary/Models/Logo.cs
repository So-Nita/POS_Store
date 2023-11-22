using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Logo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Source { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Cover { get; set; }

    public string? Type { get; set; }
}
