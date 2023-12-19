using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Promotion
{
    public ulong Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public string ProductId { get; set; } = null!;

    public long? Promotion1 { get; set; }

    public string StartDate { get; set; } = null!;

    public string EndDate { get; set; } = null!;

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public string? Description { get; set; }

    public string? Other { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? PromotionQty { get; set; }

    public int? PromotionPercent { get; set; }

    public int? PromotionsTypeId { get; set; }

    public int? ShopId { get; set; }

    public int? SubCategoryId { get; set; }
}
