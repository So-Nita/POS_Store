using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class SellInvoice
{
    public int Id { get; set; }

    public string? InvoiceNumber { get; set; }

    public int? SellOrdersId { get; set; }

    public int? SellBy { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool? Status { get; set; }

    public string? Description { get; set; }

    public bool? IsPaid { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Ref { get; set; }
}
