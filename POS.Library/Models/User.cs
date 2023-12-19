using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class User
{
    public ulong Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? EmailVerifiedAt { get; set; }

    public string Password { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? Image { get; set; }

    public string UserRole { get; set; } = null!;

    public string? RememberToken { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public long? ShopBranchId { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }

    public int? ShopBranchDetailId { get; set; }

    public int? GroupUserId { get; set; }

    public double? CustomerLat { get; set; }

    public double? CustomerLng { get; set; }

    public string? NotificationToken { get; set; }

    public string? Gender { get; set; }
}
