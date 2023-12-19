using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class CheckOutDetail
{
    public ulong Id { get; set; }

    public long? CheckOutId { get; set; }

    public long? ProductId { get; set; }

    public string? Choices { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public double Tax { get; set; }

    public double? Discount { get; set; }

    public string? ProductName { get; set; }

    public string? Thumbnail { get; set; }

    public long? ShopId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? ShopInfo { get; set; }

    public double? ShippingCost { get; set; }

    public string? ShippingType { get; set; }
}
