﻿using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Notification
{
    public Guid Id { get; set; }

    public string Type { get; set; } = null!;

    public string NotifiableType { get; set; } = null!;

    public ulong NotifiableId { get; set; }

    public string Data { get; set; } = null!;

    public DateTime? ReadAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? Status { get; set; }

    public int? SeenBy { get; set; }
}
