using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Static
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string Status { get; set; } = null!;
}
