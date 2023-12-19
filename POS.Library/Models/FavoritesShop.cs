using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class FavoritesShop
{
    public ulong Id { get; set; }

    public string CustomerId { get; set; } = null!;

    public string ShopId { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }
}
