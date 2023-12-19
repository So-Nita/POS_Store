using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class NotificationCustomer
{
    public ulong Id { get; set; }

    public string Title { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string? Description { get; set; }

    public sbyte? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public sbyte? IsDeleted { get; set; }

    public int? ProductId { get; set; }

    public int? PromotionId { get; set; }

    public int? SellOrderId { get; set; }
}
