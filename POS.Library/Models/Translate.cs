using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Translate
{
    public ulong Id { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Language { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
