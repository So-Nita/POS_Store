using System;
using System.Collections.Generic;

namespace POSLibrary.Models;

public partial class AttributeValue
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string? AttrValue { get; set; }

    public int? Status { get; set; }

    public int? IsDelete { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
