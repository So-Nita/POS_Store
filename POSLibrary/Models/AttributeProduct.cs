using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class AttributeProduct
{
    public ulong Id { get; set; }

    public string ProductId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public sbyte? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? AttributeId { get; set; }

    public sbyte? IsDeleted { get; set; }

    public int? VarientId { get; set; }

    public string? VarientName { get; set; }
}
