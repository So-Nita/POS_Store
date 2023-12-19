using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Slider
{
    public ulong Id { get; set; }

    public string? Name { get; set; }

    public string? Image { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public long? ShopId { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? Description { get; set; }

    public bool? Status { get; set; }

    public bool? IsDeleted { get; set; }

    public int? Order { get; set; }
}
