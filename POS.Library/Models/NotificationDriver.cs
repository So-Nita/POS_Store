using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class NotificationDriver
{
    public int Id { get; set; }

    public int? DriverId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
