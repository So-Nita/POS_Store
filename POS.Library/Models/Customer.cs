using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public int ShopId { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string Phone { get; set; } = null!;

    public string GazetteersCode { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public sbyte? IsDeleted { get; set; }

    public sbyte? Status { get; set; }

    public string? VatNumber { get; set; }

    public string? StreetNumber { get; set; }

    public string? HomeNumber { get; set; }
}
