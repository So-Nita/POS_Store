using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Shop
{
    public int Id { get; set; }

    public int ShopTypeId { get; set; }

    public int? ShopDivisionId { get; set; }

    public string Name { get; set; } = null!;

    public string Initial { get; set; } = null!;

    public string? Image { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public string? Address { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public sbyte Status { get; set; }

    public sbyte? IsDeleted { get; set; }

    public string? Code { get; set; }

    public string? CodePrefixOwnerId { get; set; }

    public string? CreateBy { get; set; }

    public string? Cover { get; set; }

    public string? HouseNumber { get; set; }

    public string? Street { get; set; }

    public int? GazetteersCode { get; set; }

    public string? RouteHandle { get; set; }
}
