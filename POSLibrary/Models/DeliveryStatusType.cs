using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class DeliveryStatusType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Status { get; set; }

    public string? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Color { get; set; }
}
