using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string SupplierName { get; set; } = null!;

    public string? Contact { get; set; }

    public string? Email { get; set; }

    public string? HomeNumber { get; set; }

    public string? Hotline { get; set; }

    public string? Street { get; set; }

    public string? Latlng { get; set; }

    public string? GazetteersCode { get; set; }

    public string? Address { get; set; }

    public int? CreateBy { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? Status { get; set; }

    public string? Website { get; set; }

    public DateTime CreateDate { get; set; }

    public string? VendorCode { get; set; }

    public int? ShopId { get; set; }

    public int? SupplierCode { get; set; }
}
