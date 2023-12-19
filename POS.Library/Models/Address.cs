using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Address
{
    public ulong Id { get; set; }

    public string CustomerId { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Location { get; set; } = null!;

    public string LocationType { get; set; } = null!;

    public string? Image { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public double Lat { get; set; }

    public double Lng { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }

    public string? Note { get; set; }
}
