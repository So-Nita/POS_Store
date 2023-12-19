using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class TrackDriver
{
    public long Id { get; set; }

    public long? OrderId { get; set; }

    public long? DriverId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
