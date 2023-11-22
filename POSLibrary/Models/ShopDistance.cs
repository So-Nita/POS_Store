using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ShopDistance
{
    public int Id { get; set; }

    public int? ShopId { get; set; }

    public string? Distance { get; set; }

    public string? Price { get; set; }

    public DateTime? CreateAt { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }

    public string? DistanceType { get; set; }

    public int? MeasurementId { get; set; }
}
