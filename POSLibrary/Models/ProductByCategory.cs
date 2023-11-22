using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ProductByCategory
{
    public ulong Id { get; set; }

    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string? NameKh { get; set; }

    public string? Type { get; set; }

    public string? Image { get; set; }

    public double? Price { get; set; }

    public string Status { get; set; } = null!;

    public string? Description { get; set; }

    public string? ExpirationDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public long? ShopId { get; set; }

    public string Currency { get; set; } = null!;

    public string? Barcode { get; set; }

    public double Cost { get; set; }

    public int Qty { get; set; }

    public int Amount { get; set; }

    public string? ImageThumbnail { get; set; }

    public string? Filename { get; set; }

    public string? Pathfile { get; set; }

    public string? Path { get; set; }

    public int? CurrencyId { get; set; }

    public int? CreateBy { get; set; }

    public float? UnitPrice { get; set; }

    public float? Discount { get; set; }

    public string? DiscountType { get; set; }

    public int? Taxation { get; set; }

    public string? Code { get; set; }

    public int? CodePrefixOwnerId { get; set; }

    public int MeasurementId { get; set; }

    public string? ChoiceOptions { get; set; }

    public string? Brand { get; set; }

    public int? VendorId { get; set; }

    public DateTime? LastStockPurchase { get; set; }

    public DateTime? LastSoldDate { get; set; }

    public string? Gp { get; set; }

    public int? ItemCode { get; set; }
}
