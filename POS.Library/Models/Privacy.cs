﻿using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Privacy
{
    public ulong Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
