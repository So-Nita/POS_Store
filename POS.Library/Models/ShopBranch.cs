using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class ShopBranch
{
    public int Id { get; set; }

    public int? ShopId { get; set; }

    public string? Contact { get; set; }

    public string? Shop { get; set; }

    public string? Branch { get; set; }

    public string? Address { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? Status { get; set; }

    public int? CodePrefixOwnerId { get; set; }

    public int? Code { get; set; }
}
