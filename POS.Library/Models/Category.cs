using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Category
{
    public ulong Id { get; set; }

    public int ParentCategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public long? ShopId { get; set; }
}
