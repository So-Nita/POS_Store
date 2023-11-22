using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class Ratting
{
    public ulong Id { get; set; }

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public double? Star { get; set; }

    public string? Comment { get; set; }

    public string? Attachment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public sbyte? Status { get; set; }

    public sbyte? IsDeleted { get; set; }
}
