using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Delivery
{
    public int Id { get; set; }

    public int DriverId { get; set; }

    public int? SellOrderId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? DeliveryNumber { get; set; }

    public int DeliveryStatusTypeId { get; set; }
}
